using JQueryValidator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryValidator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string fn = Server.MapPath("~/Save.txt");
            StreamReader f = System.IO.File.OpenText(fn);
            var line = f.ReadLine();

            Person p = new Person();
            var parts =  line.Split(',');
            p.FirstName = parts[0].Split('=')[1];
            p.LastName = parts[1].Split('=')[1];
            

            f.Close();
            return View(p);
        }

        [HttpPost]
        public ActionResult Index(Person person)
        {
            if (ModelState.IsValid)
            {
                string fn = Server.MapPath("~/Save.txt");
                StreamWriter f = System.IO.File.CreateText(fn);
                f.WriteLine("Firstmame = " + person.FirstName + ", Lastname = " + person.LastName);
                f.Close();
            }
            return View(person);
        }
    }
}