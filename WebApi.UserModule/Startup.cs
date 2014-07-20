using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;

[assembly: OwinStartupAttribute(typeof(WebApi.UserModule.Startup))]

namespace WebApi.UserModule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            ConfigureAuth(app);
        }

        //private static void ConfigureData()
        //{
        //    var storage = new WebSessionStorage(System.Web.HttpContext.Current.ApplicationInstance);
        //    DataConfig.Configure(storage);
        //}
    }
}