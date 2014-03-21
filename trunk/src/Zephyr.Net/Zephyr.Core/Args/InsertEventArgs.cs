﻿/*************************************************************************
 * 文件名称 ：InsertEventArgs.cs                          
 * 描述说明 ：插入事件参数
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using Zephyr.Data;

namespace Zephyr.Core
{
    public class InsertEventArgs
    {
        public IDbContext db { get; set; }
        public ParamInsertData data { get; set; }
        public int executeValue { get; set; }
    }
}
