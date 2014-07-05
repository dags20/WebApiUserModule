using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.UserModule.Models;
using WebApi.UserModule.Services;
using WebApi.UserModule.ViewModels;

namespace WebApi.UserModule.Controllers
{
    public class AccountabilityController : ApiController
    {
        private readonly AccountabilityServices accountabilityServices;

        public AccountabilityController() 
        {
            this.accountabilityServices = new AccountabilityServices();        
        }

        [HttpPost]
        public string RegisterUser(RegisterUserViewModel viewModel)
        {
            // TODO: Add precondition here;
            try 
            {
                var result = accountabilityServices.RegisterUser(
                                                viewModel.Name, 
                                                viewModel.Password);
                if (result)
                    return "Ok";
 
            }catch(Exception e){

                //Somethign went wrong here and needs to be logged.
            }            
            
            return "There was a problem creating the account.";
        }
        
        public string GetAllUser()
        {
            var UserName = "Diego Test";

            return UserName;
        }
    }
}
