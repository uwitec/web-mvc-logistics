/*************************************************************************
 * 文件名称 ：ICompress.cs                          
 * 描述说明 ：文件压缩接口
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System.IO;

namespace Zephyr.Core
{
    public interface ICompress
    {
        string Suffix(string orgSuffix);
        Stream Compress(Stream fileStream,string fullName);
    }
}
