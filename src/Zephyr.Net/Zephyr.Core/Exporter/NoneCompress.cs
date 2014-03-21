/*************************************************************************
 * 文件名称 ：NoneCompress.cs                          
 * 描述说明 ：空压缩接口实现
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System.IO;

namespace Zephyr.Core
{
    public class NoneCompress: ICompress
    {
        public string Suffix(string orgSuffix)
        {
            return orgSuffix;
        }

        public Stream Compress(Stream fileStream,string fullName)
        {
            return fileStream;
        }
    }
}
