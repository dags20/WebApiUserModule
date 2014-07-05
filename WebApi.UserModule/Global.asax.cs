using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApi.UserModule
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            NhibernateHelper.Configure();
        }


        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // TODO: This needs to be removed from any production site.
            // Problem on chrome with the cross site resources
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
        }
    }
}
