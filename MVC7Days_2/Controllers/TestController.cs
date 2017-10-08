using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7Days_2.Controllers
{
    public class Customer
    {
        public string CustomName { get; set; }
        public string Address { get; set; }
    }

    public class TestController : Controller
    {
        // GET: Test
        /*
        public ActionResult Index()
        {
            return View();
        }
        
        public string GetString()
        {
            return "Hallo world is outdated!";
        }
        */
        // sekoj public metod ako ne e oznacen so [NonAction] moze da se povika
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomName = "Customer 1";
            c.Address = "Address 1";
            return c;
        }
        [NonAction]//ne moze da se povika, ne e action method
        public string SimpleMethod()
        {
            return "dsfsdf sdf sdf sdfsdfsdf";
        }
    }
}