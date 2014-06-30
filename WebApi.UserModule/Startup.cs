using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApi.UserModule.Startup))]

namespace WebApi.UserModule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);            
        }

        //private static void ConfigureData()
        //{
        //    var storage = new WebSessionStorage(System.Web.HttpContext.Current.ApplicationInstance);
        //    DataConfig.Configure(storage);
        //}
    }
}
