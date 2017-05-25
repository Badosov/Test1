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
            var people = new List<Person>();
            foreach (People person in peopleRepo.GetPeople())
            {
                people.Add(new Person()
                {
                    LastName = person.LastName,
                    FirstName = person.FirstName,
                    Patronymic = person.Patronymic
                });
            }


            //var peopleRepo = new PeopleRepo();
            //var people = new List<Person>();
            //var test = peopleRepo.GetPeople();
            //foreach (PeopleMongo person in peopleRepo.GetPeople())
            //{
            //    people.Add(new Person()
            //    {
            //        LastName = person.LastName,
            //        FirstName = person.FirstName,
            //        Patronymic = person.Patronymic
            //    });
            //}
            ViewBag.People = people;
            return View();
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPerson(Person person)
        {
            var newPerson = new People();

            newPerson.LastName = person.LastName;
            newPerson.FirstName = person.FirstName;
            newPerson.Patronymic = person.Patronymic;

            using (var dbCtx = new SoftomateContext())
            {
                dbCtx.People.Add(newPerson);
                dbCtx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}