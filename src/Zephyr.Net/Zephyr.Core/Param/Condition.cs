/*************************************************************************
 * 文件名称 ：Condition.cs                          
 * 描述说明 ：参数条件定义
 * 
 * 创建信息 : create by liuhuisheng.xm@gmail.com on 2013-11-8

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using Zephyr.Utils;
using Zephyr.Data;

namespace Zephyr.Core
{
    public class Condition
    {
        public string Join { get; set; }
        public string Symbol { get; set; }
        public string Column { get; set; }
        public object[] Values { get; set; }
        public Func<Condition, bool> Ignore { get; set; }
        internal List<Parameter> Parameters { get; set; }

        public string ToSql(IDbContext db, bool withJoin = false)
        {
            var sType = db.Data.Provider.ToString().Split('.').LastOrDefault().Replace("Provider", "");
            var dbType = ConvertHelper.ToEnum<DbType>(sType, DbType.Default);
            return ToSql(dbType, withJoin);
        }

        public string ToSql(DbType dbType, bool withJoin = false)
        {
            var maker = App.DictSql[dbType, this.Symbol];
            if (maker==null)
                throw new Exception(string.Format("未在数据库{0}中注册{1}！",dbType,this.Symbol));

            return Ignore != null && Ignore(this) ? string.Empty : string.Join(" ", withJoin ? Join : string.Empty, maker.Handler(this));
        }
 
        public string GetValue(int index = 0)
        {
            return IsNullOrEmptyValue(index) ? string.Empty : Values[index].ToString();
        }

        public T GetValue<T>(int index = 0)
        {
            return ConvertHelper.To<T>(Values[index]);
        }

        public bool IsNullOrEmptyValue(int index = 0)
        {
            return Values[index] == null || string.IsNullOrEmpty(Values[index].ToString());
        }
    }
}
