/*************************************************************************
 * 文件名称 ：ServiceBaseInsert.cs                          
 * 描述说明 ：定义数据服务基类中的插入处理
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

namespace Zephyr.Core
{
    public partial class ServiceBase<T> where T : ModelBase, new()
    {
        protected virtual bool OnBeforeInsert(InsertEventArgs arg)
        {
            return true;
        }

        protected virtual void OnAfterInsert(InsertEventArgs arg)
        {

        }

        public int Insert(ParamInsert param)
        {
            var result = 0;
            Logger("增加记录", () =>
            {
                db.UseTransaction(true);
                var rtnBefore = this.OnBeforeInsert(new InsertEventArgs() { db = db, data = param.GetData() });
                if (!rtnBefore) return;

                var Identity = ModelBase.GetAttributeFields<T, IdentityAttribute>();
                result = Identity.Count > 0 ? BuilderParse(param).ExecuteReturnLastId<int>() : BuilderParse(param).Execute();

                this.OnAfterInsert(new InsertEventArgs() { db = db, data = param.GetData(),executeValue = result});
                db.Commit();
            });
            return result;
        }
    }
}
