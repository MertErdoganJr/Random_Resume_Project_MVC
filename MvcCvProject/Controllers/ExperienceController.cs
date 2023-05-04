using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;

namespace MvcCvProject.Controllers
{
    public class ExperienceController : Controller
    {
        EcperienceRepository repo = new EcperienceRepository();
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(TblExperience p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            TblExperience t = repo.Find(x=>x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            TblExperience t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult UpdateExperience(TblExperience p)
        {
            TblExperience t = repo.Find(x => x.ID == p.ID);
            t.Title = p.Title;
            t.SecondTitle = p.SecondTitle;
            t.Date = p.Date;
            t.Description = p.Description;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}