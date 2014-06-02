using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebApi.UserModule.Services;
using WebApi.UserModule.Models;
using WebApi.UserModule.ViewModels;

namespace WebApi.UserModule.Test
{
    [TestFixture]
    public class RegisterUserTest
    {
        [TestFixtureSetUp]
        public void TearUp()
        {
            NhibernateHelper.Configure();        
        }

        [Test]
        public void Test() 
        {
            // Arrange
            var accountability = new AccountabilityServices();
            var viewModel = new RegisterUserViewModel()
            {
                Name = "ThiisaTest",
                Password = "Bob_bob"
            };

            // Act
            var objectUnderTest = accountability.RegisterUser(viewModel.Name, viewModel.Password);

            // Assert
            Assert.IsTrue(objectUnderTest);            
        }
    }
}