using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;

namespace MvcCvProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var valeus = db.TblAbout.ToList();
            return View(valeus);
        }

        public PartialViewResult SocialMedia()
        {
            var values = db.TblSocialMedia.Where(x=>x.Status ==true).ToList();
            return PartialView(values);
        }
        public PartialViewResult Experience()
        {
            var values = db.TblExperience.ToList();
            return PartialView(values);
        }

        public PartialViewResult Education()
        {
            var values = db.TblEducation.ToList();
            return PartialView(values);
        }

        public PartialViewResult Skill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult Hobby()
        {
            var values = db.TblHobby.ToList();
            return PartialView(values);
        }

        public PartialViewResult Certificate()
        {
            var values = db.TblCertificate.ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Contact(TblCommunication t)
        {
            t.Date = DateTime.Parse(DateTime.Now.ToLongDateString());
            db.TblCommunication.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}