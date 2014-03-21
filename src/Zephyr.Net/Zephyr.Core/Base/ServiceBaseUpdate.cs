/*************************************************************************
 * 文件名称 ：ServiceBaseUpdate.cs                          
 * 描述说明 ：定义数据服务基类中的更新处理
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

namespace Zephyr.Core
{
    public partial class ServiceBase<T> where T : ModelBase, new()
    {
        protected virtual bool OnBeforeUpdate(UpdateEventArgs arg)
        {
            return true;
        }

        protected virtual void OnAfterUpdate(UpdateEventArgs arg)
        {

        }

        public int Update(ParamUpdate param)
        {
            var result = 0;
            Logger("更新记录", () =>
            {
                db.UseTransaction(true);
                var rtnBefore = this.OnBeforeUpdate(new UpdateEventArgs() { db = db, data = param.GetData() });
                if (!rtnBefore) return;
                result = BuilderParse(param).Execute();
                this.OnAfterUpdate(new UpdateEventArgs() { db = db, data = param.GetData(), executeValue=result });
                db.Commit();
            });
            return result;
        }
    }
}
