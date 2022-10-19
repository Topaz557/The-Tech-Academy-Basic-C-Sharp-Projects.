using MVC_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello 1";
            // System.IO.File.WriteAllText(@"C:\Users\andre\Documents\GitHub\parseText\SampleParse1.txt", text);
            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}