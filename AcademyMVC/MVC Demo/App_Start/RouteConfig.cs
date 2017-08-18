using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Demo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
            routes.MapRoute(
                "Employee", "Employee/{name}", new
                {
                    controller = "Employee",
                    //La acción es buscar un nombre de empleado
                    action = "Search",
                    //Le mandamos un nombre que va a venir como parte del parámetro
                    name = UrlParameter.Optional

                });
            */

            //Esta es la ruta por default de la aplicación, se pueden cambiar
            routes.MapRoute(
                name: "Default",
                //la acción es la función/método
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
