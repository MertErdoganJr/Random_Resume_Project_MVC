using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class SkillController : Controller
    {
        GenericRepository<TblSkill> repo = new GenericRepository<TblSkill>();
        public ActionResult Index()
        {
            var Skills = repo.List();
            return View(Skills);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(TblSkill p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var values = repo.Find(x => x.ID == id);
            repo.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var values = repo.Find(x => x.ID == id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSkill(TblSkill p)
        {
            var values = repo.Find(x => x.ID == p.ID);
            values.Skill = p.Skill;
            values.Progress = p.Progress;
            repo.TUpdate(values);
            return RedirectToAction("Index");

        }
    }
}