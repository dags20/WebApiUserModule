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
    }
}
