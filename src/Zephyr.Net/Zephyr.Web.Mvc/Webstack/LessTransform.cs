using System;
using System.Web.Optimization;
using dotless.Core;

namespace Zephyr.Web.Mvc
{
    public class LessTransform : IBundleTransform
    {
        public void Process(BundleContext context, BundleResponse response)
        {
            var compiled = Less.Parse(response.Content);
            if (string.IsNullOrEmpty(compiled))
                throw new Exception("less文件中语法有错误！");
            response.Content = compiled;
            response.ContentType = "text/css";
        }
    }
}