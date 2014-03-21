/*************************************************************************
 * 文件名称 ：IDataGetter.cs                          
 * 描述说明 ：取得数据接口
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System.Web;

namespace Zephyr.Core
{
    public interface IDataGetter
    {
        object GetData(HttpContext context);
    }
}
