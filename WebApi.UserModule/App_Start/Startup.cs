using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.OAuth;
using NHibernate.AspNet.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using WebApi.UserModule.Providers;
using Owin;

namespace WebApi.UserModule
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        public static Func<UserManager<IdentityUser>> UserManagerFactory { get; set; }

        static Startup()
        {
            PublicClientId = "self";

            UserManagerFactory = () => new UserManager<IdentityUser>(new UserStore<IdentityUser>(NhibernateHelper.GetSession()));

            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/Token"),                
                Provider = new ApplicationOAuthProvider(PublicClientId, UserManagerFactory),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                AllowInsecureHttp = true
            };
        }

        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthOptions);
        }
    }
}