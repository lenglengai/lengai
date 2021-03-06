﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Hosting;

using common.core;
using account.core;

namespace webui
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            this._runPreinit();
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            this._runInit();
            this._runStart();
        }

        protected void Application_End() {
            InitService initService_ = __singleton<InitService>._instance();
            initService_._runExit();
        }

        void _runPreinit() {
            string systemPath_ = HostingEnvironment.MapPath(@"~");
            InitService initService_ = __singleton<InitService>._instance();
            initService_._runPreinit(systemPath_);

            AccountService accountService_ = __singleton<AccountService>._instance();
            accountService_._runPreinit();
        }

        void _runInit() {
            InitService initService_ = __singleton<InitService>._instance();
            initService_._runInit();
        }

        void _runStart() {
            InitService initService_ = __singleton<InitService>._instance();
            initService_._runStart();
        }
    }
}