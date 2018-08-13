﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Loja.MVC5.Web {

    public class MvcApplication : System.Web.HttpApplication {

        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
