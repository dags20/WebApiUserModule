using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.AspNet.Identity;

namespace WebApi.UserModule.Models
{
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        ///  Creates an <c>ApplicationUser</c>.
        /// </summary>
        /// <param name="name">Name to be assigned to the <c>ApplicationUser</c>.</param>
        public ApplicationUser(string name): base(name)
        {        
        }

        /// <summary>
        ///  Creates an <c>ApplicationUser</c>.
        /// </summary>
        protected ApplicationUser() 
        { 
            // Need it for NHibernate
        }
    }
}