using Fiap.Apostila06.MVC.Web.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fiap.Apostila06.MVC.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //Configuração da estratégia de criação do BD
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<FarmaciaContext>());
        }
    }
}
