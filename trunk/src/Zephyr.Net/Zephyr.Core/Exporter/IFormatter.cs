/*************************************************************************
 * 文件名称 ：IFormatter.cs                          
 * 描述说明 ：字段格式化接口
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

namespace Zephyr.Core
{
    public interface IFormatter
    {
        object Format(object value);
    }
}
