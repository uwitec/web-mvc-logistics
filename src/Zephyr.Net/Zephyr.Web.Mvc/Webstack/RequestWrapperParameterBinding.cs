using System.Collections.Specialized;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;
using Zephyr.Core;

namespace Zephyr.Web.Mvc
{
    public class RequestWrapperParameterBinding : HttpParameterBinding
    {
        private struct AsyncVoid { }
        public RequestWrapperParameterBinding(HttpParameterDescriptor desc) : base(desc) { }
        public override Task ExecuteBindingAsync(ModelMetadataProvider metadataProvider, HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            // Set the binding result here
            var request = System.Web.HttpUtility.ParseQueryString(actionContext.Request.RequestUri.Query);
            var requestWrapper = RequestWrapper.Instance().SetValue(request);
            if (!string.IsNullOrEmpty(request["_xml"]))
            {
                var xmlType = request["_xml"].Split('.');
                var xmlPath = string.Format("~/Views/Shared/Xml/{0}.xml", xmlType[xmlType.Length - 1]);
                if (xmlType.Length > 1)
                    xmlPath = string.Format("~/Areas/{0}/Views/Shared/Xml/{1}.xml", xmlType);

                requestWrapper.LoadXmlFile(xmlPath);
            }

            SetValue(actionContext, requestWrapper);

            // now, we can return a completed task with no result
            TaskCompletionSource<AsyncVoid> tcs = new TaskCompletionSource<AsyncVoid>();
            tcs.SetResult(default(AsyncVoid));
            return tcs.Task;
        }
    }
}