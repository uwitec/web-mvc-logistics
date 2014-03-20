using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Web.Trade.Models;
using Zephyr.Web.Trade;

namespace Zephyr.Web.Trade.Controllers
{
    public class TradeBaseApi<TMasterModel, TMasterService, TDetailModel, TDetailService> : ApiController
        where TMasterModel : ModelBase, new()
        where TDetailModel : ModelBase, new()
        where TMasterService : ServiceBase<TMasterModel>, new()
        where TDetailService : ServiceBase<TDetailModel>, new()
    {
        #region 属性
        private TMasterService _masterService;
        private TDetailService _detailService;
        public TMasterService masterService
        { 
            get 
            {
                if (_masterService == null)
                    _masterService = new TMasterService();
                return _masterService;
            } 
        }
        public TDetailService detailService
        {
            get
            {
                if (_detailService == null)
                    _detailService = new TDetailService();
                return _detailService;
            }
        }
        public string projectCode { get { return TradeHelper.GetCurrentProject(); } }
        public string userName { get { return TradeHelper.GetUserName(); } }
        #endregion

        #region 自动完成
        // GET api/trade/send/getbillno
        public virtual List<dynamic> GetJobno(string q)
        {
            var pQuery = ParamQuery.Instance().Select("top 10 Jobno").Where(c => c.And("Jobno", q).Symbol("StartWithPY"));
            return masterService.GetDynamicList(pQuery);
        }
        #endregion

        #region 采播
        // 取得新的主表Bill GET api/trade/send/getnewjobno
        public virtual string GetNewJobno()
        {
            return masterService.GetNewKey("Jobno", "dateplus");
        }

        // 取得新的明细表SNO GET api/trade/send/getnewrowid
        public virtual string GetNewRowId(int id, string Jobno)
        {
            return detailService.GetNewKey("SNO", "maxplus", id, ParamQuery.Instance().Where("Jobno", Jobno));
        }
        #endregion

        #region 查询
        // 查询主表数据列表 GET api/trade/send 
        public virtual dynamic Get(RequestWrapper query)
        {
            //todo
            //if (!query.IsLoadedSettings)
            query.SetXml(string.Format(@"
<settings>
    <select>*</select>
    <from>{0}</from>
    <where>
        <c column='Jobno' ignore='empty'></c>
    </where>
    <orderby>Jobno</orderby>
</settings>", typeof(TMasterModel).Name));
            var pQuery = query.ToParamQuery();
            var result = masterService.GetDynamicListWithPaging(pQuery);
            return result;
        }

        // 取得编辑页面中的主表数据及上一页下一页主键 GET api/trade/send/geteditmaster 
        public virtual dynamic GetEditMaster(string id)
        {
            return new
            {
                form = masterService.GetModel(ParamQuery.Instance().Where("Jobno", id)),
                scrollKeys = masterService.ScrollKeys("Jobno", id, ParamQuery.Instance().Where("ProjectCode", projectCode))
            };
        }

        // 查询明细表 GET api/trade/send/getdetail
        public virtual dynamic GetDetail(string id)
        {
            var query = RequestWrapper
                .InstanceRequest()
                .SetValue("Jobno", id)
                .SetXml(string.Format(@"
<settings>
    <select>A.*, B.*</select>
    <from>{0} A left join trade_scheduler B on B.jobo = A.jobno</from>
    <where><c column='Jobno' symbol='equal'></c></where>
    <orderby>Jobno</orderby>
</settings>", typeof(TDetailModel).Name));

            var pQuery = query.ToParamQuery();
            var result = masterService.GetDynamicListWithPaging(pQuery);
            return result;
        }
        #endregion

        #region 删除
        // 删除 DELETE api/trade/send
        public virtual void Delete(string id)
        {
            var result = masterService.Delete(ParamDelete.Instance().Where("Jobno", id));
            TradeHelper.ThrowHttpExceptionWhen(result <= 0, "单据删除失败[Jobno={0}]，请重试或联系管理员！", id);
        }
        #endregion

        #region 审核
        // 审核 DELETE api/trade/send/audit
        [HttpPost]
        public virtual void Audit(string id, JObject data)
        {
            var status = data["status"].ToString();
            var comment = data["comment"].ToString();
            var result = new TradeService().Audit(typeof(TMasterModel).Name, id, status, comment);
            TradeHelper.ThrowHttpExceptionWhen(result < 0, "单据审核失败[BillNo={0}]，请重试或联系管理员！", id);
        }
        #endregion

        #region 保存
        // 保存 POST api/trade/send
        [HttpPost]
        public virtual void Edit(dynamic data)
        {
            var formWrapper = RequestWrapper.Instance().SetXml(string.Format(@"
<settings>
    <table>{0}</table>
    <where><c column='Jobno'></c></where>
</settings>", typeof(TMasterModel).Name));

            var listWrapper = RequestWrapper.InstanceArray(1);
            listWrapper[0].SetXml(string.Format(@"
<settings>
    <table>{0}</table>
    <where>
        <c column='Jobno'></c>
        <c column='RowId'></c>
    </where>
</settings>", typeof(TDetailModel).Name));
             
            var result = masterService.Edit(data,formWrapper, listWrapper);
        }
        #endregion
    }
}