﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Zephyr.Utils
{
    /// <summary>
    /// <para>　</para>
    /// 　常用工具类——Web.Config操作类
    /// <para>　--------------------------------------------------------------</para>
    /// <para>　GetConfigString：得到AppSettings中的配置字符串信息</para>
    /// <para>　GetConnectionString：得到Connection中配置字符串信息</para>
    /// <para>　GetConfigBool：得到AppSettings中的配置Bool信息</para>
    /// <para>　GetConfigDecimal：得到AppSettings中的配置Decimal信息</para>
    /// <para>　GetConfigDecimal：得到AppSettings中的配置int信息</para>
    /// </summary>
    public class ConfigHelper
    {
        #region Asp.NET的Web.config

        #region 得到AppSettings中的配置字符串信息
        /// <summary>
        /// 得到AppSettings中的配置字符串信息
        /// </summary>
        /// <param name="key">AppSetting中关键字KEY</param>
        /// <returns>AppSettings中的配置字符串信息</returns>
        public static string GetConfigString(string key,string defaults = null)
        {
            var config = ConfigurationManager.AppSettings[key];
            string AppStr = config != null ? config.ToString() : defaults; 
            return AppStr;
        }
        #endregion

        #region 得到Connection中配置字符串信息
        /// <summary>
        /// 得到Connection中配置字符串信息
        /// </summary>
        /// <param name="key">Connection中name的值</param>
        /// <returns>Connection中name的值</returns>
        public static string GetConnectionString(string key)
        {
            var conn = ConfigurationManager.ConnectionStrings[key];
            string ConnStr = conn !=null ? conn.ToString() : null;
            return ConnStr;
        }
        #endregion

        #region 得到AppSettings中的配置Bool信息
        /// <summary>
        /// 得到AppSettings中的配置Bool信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetConfigBool(string key,bool defaults=false)
        {
            bool result = defaults;
            string cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
            {
                try
                {
                    result = bool.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }
            }
            return result;
        }
        #endregion

        #region 得到AppSettings中的配置Decimal信息
        /// <summary>
        /// 得到AppSettings中的配置Decimal信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static decimal GetConfigDecimal(string key,decimal defaults=0)
        {
            decimal result = defaults;
            string cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
            {
                try
                {
                    result = decimal.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }
            }

            return result;
        }
        #endregion

        #region 得到AppSettings中的配置int信息
        /// <summary>
        /// 得到AppSettings中的配置int信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetConfigInt(string key,int defaults=0)
        {
            int result = defaults;
            string cfgVal = GetConfigString(key);
            if (null != cfgVal && string.Empty != cfgVal)
            {
                try
                {
                    result = int.Parse(cfgVal);
                }
                catch (FormatException)
                {
                    // Ignore format exceptions.
                }
            }

            return result;
        }
        #endregion

        #endregion
    }
}
