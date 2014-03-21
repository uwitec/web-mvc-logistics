/*************************************************************************
 * 文件名称 ：ServiceBaseDelete.cs                          
 * 描述说明 ：定义数据服务基类中的删除处理
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

namespace Zephyr.Core
{
    public partial class ServiceBase<T> where T : ModelBase, new()
    {
        protected virtual bool OnBeforeDelete(DeleteEventArgs arg)
        {
            return true;
        }

        protected virtual void OnAfterDelete(DeleteEventArgs arg)
        {

        }

        public int Delete(ParamDelete param)
        {
            var result = 0;
            Logger("删除记录", () =>
            {
                db.UseTransaction(true);
                var rtnBefore = this.OnBeforeDelete(new DeleteEventArgs() { db = db, data = param.GetData() });
                if (!rtnBefore) return;
                result = BuilderParse(param).Execute();
                this.OnAfterDelete(new DeleteEventArgs() { db = db, data = param.GetData(),executeValue = result });
                db.Commit();
            });
            return result;
        }
    }
}
