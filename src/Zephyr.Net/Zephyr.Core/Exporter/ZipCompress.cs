/*************************************************************************
 * 文件名称 ：ZipCompress.cs                          
 * 描述说明 ：压缩为ZIP
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System.IO;
using Ionic.Zip;

namespace Zephyr.Core
{
    public class ZipCompress: ICompress
    {
        public string Suffix(string orgSuffix)
        {
            return "zip";
        }

        public Stream Compress(Stream fileStream,string fullName)
        {
            using (var zip = new ZipFile())
            {
                zip.AddEntry(fullName, fileStream);
                Stream zipStream = new MemoryStream();
                zip.Save(zipStream);
                return zipStream;
            }
        }
    }
}
