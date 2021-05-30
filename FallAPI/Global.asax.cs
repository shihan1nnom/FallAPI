using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Data.Entity;
using FallAPI.Models;

namespace FallAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<ContextoBD>(new InicicializarBD());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
