﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Web.Mvc;
using WebMatrix.WebData;
using SpectrumAnalyser.Models.BD;

namespace SpectrumAnalyser.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class InitializeSimpleMembershipAttribute : ActionFilterAttribute
    {
        private static SimpleMembershipInitializer _initializer;
        private static object _initializerLock = new object();
        private static bool _isInitialized;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Ensure ASP.NET Simple Membership is initialized only once per app start
            LazyInitializer.EnsureInitialized(ref _initializer, ref _isInitialized, ref _initializerLock);
        }

        private class SimpleMembershipInitializer
        {
            public SimpleMembershipInitializer()
            {
                Database.SetInitializer<EntityDataModel>(null);

                try
                {
                    WebSecurity.InitializeDatabaseConnection("EntityDataModel", "tbl_1_User", "UserId", "Login", autoCreateTables: true);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Something is wrong", ex);
                }
            }
        }
    }
}
