using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public string Index()
        {
            return GetAllCustomers();
        }

        [NonAction]
        public string GetAllCustomers()
        {
            //El @ es para que te tme todos los parámetros, toma literalmente como lo escribes
            return @"
                <ul>
                    <li>José</li>
                    <li>Juan</li>
                    <li>Gaby</li>
                    <li>Pepe</li>
                </ul>";
        }

        public ActionResult MyView()
        {
            return View();
        }
    }
}