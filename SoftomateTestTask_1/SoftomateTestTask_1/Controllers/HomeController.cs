using Softomate.Data;
using Softomate.Entity;
using Softomate.Repo;
using SoftomateTestTask_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SoftomateTestTask_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var peopleRepo = new PeopleRepo();
            ViewBag.People = peopleRepo.GetPeople();
            return View();
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPerson(People person)
        {
            var peopleRepo = new PeopleRepo();
            peopleRepo.AddPeople(person);            
            return RedirectToAction("Index");
        }

 
    }
}