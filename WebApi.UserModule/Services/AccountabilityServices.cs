using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.UserModule.Models;
using Microsoft.AspNet.Identity;
using NHibernate.AspNet.Identity;
using Microsoft.Owin.Security;

namespace WebApi.UserModule.Services
{
    /// <summary>
    ///  Wrapper services class for <c>Microsoft.AspNet.Identity.UserManager</c>
    ///  Services for the accountability module
    /// </summary>
    public class AccountabilityServices
    {        
        private readonly UserManager<ApplicationUser> userManager;

        public AccountabilityServices() 
        {            
            var userStore = new UserStore<ApplicationUser>(NhibernateHelper.GetSession());
            this.userManager = new UserManager<ApplicationUser>(userStore);
        }

        public bool RegisterUser(string userName, string password)
        {
            var applicationUser = new ApplicationUser(userName);
            var userCreatedStatus = userManager.Create(applicationUser, password);

            // TODO: Will be nice to return any error model from this.
            if (userCreatedStatus.Succeeded)
                return true;
        
            return false;
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }

        private async Task SignInAsync(ApplicationUser user, bool isPersistent)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            var identity = await userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, identity);
        }

        //public bool Login()
        //{
        //    var status = userManager.Si

        //    if (status.Succeeded)
        //        return true;

        //    return false;
        //}

    }
}