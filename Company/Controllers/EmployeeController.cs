using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    //All requests will be handelled in controllers
    //Means client(UI/View) will send requests and their responses will be handelled in controller
    //In case of MVC, we call classes which inherit from controller as controller, and functions as actions, function parameters as requests and function return values as responses

    public class EmployeeController : Controller
    {
        //Action: action is nothing but a function which handels requests and return responses
        public ViewResult Welcome()
        {
            return View();
        }

        public string WelcomeWithDate()
        {
            return "<b>Welcome</b> to mvc world " + DateTime.Now;
        }

        public string index()
        {
            return "Welcome Ateeque to Employee section";
        }
    }
}