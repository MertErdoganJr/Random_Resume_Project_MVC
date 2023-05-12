using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class EducationController : Controller
    {
        GenericRepository<TblEducation> repo = new GenericRepository<TblEducation>();
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(TblEducation p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEducation");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var education = repo.Find(x => x.ID == id);
            repo.TDelete(education);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var education = repo.Find(x => x.ID == id);
            return View(education);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation t)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateEducation");
            }
            else
            {
                var education = repo.Find(x => x.ID == t.ID);
                education.Title = t.Title;
                education.SecondTitle = t.SecondTitle;
                education.SecondTitle2 = t.SecondTitle2;
                education.Date = t.Date;
                education.TotalScore = t.TotalScore;
                repo.TUpdate(education);
                return RedirectToAction("Index");
            }
        }
    }
}