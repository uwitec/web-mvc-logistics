
 //Web Api启用Session的方法 在Global.asax.cs中添加以下方法
protected void Application_PostAuthorizeRequest()
{
    // WebApi SessionState
    var routeData = RouteTable.Routes.GetRouteData(new HttpContextWrapper(HttpContext.Current));
    if (routeData != null && routeData.RouteHandler is HttpControllerRouteHandler)
        HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
}
 
//启用框架配置 在Global.asax.cs的Application_Start中添加以下代码行
protected void Application_Start()
{
	FramewrokConfig.Register();
}