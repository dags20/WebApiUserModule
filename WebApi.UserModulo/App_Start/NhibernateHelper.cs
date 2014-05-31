using System;
using System.IO;
using System.Linq;
using NHibernate.AspNet.Identity;
using NHibernate.AspNet.Identity.Helpers;
using WebApi.UserModule.Models;
using NHibernate.Cfg;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using System.Collections.Generic;

namespace WebApi.UserModule
{
    public class NhibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISession GetSession() 
        {
            return _sessionFactory.OpenSession();        
        }

        public static void Configure()
        {
            if (_sessionFactory == null) {

                var configuration = new Configuration();
                configuration.Configure();

                _sessionFactory = configuration.BuildSessionFactory();
            }
        }
    }
}