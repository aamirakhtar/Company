using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    //MVC by default expects controller with the name Home and action with the name Index
    public class HomeController : Controller
    {
        public string index()
        {
            return "Welcome from home/index";
        }
    }
}