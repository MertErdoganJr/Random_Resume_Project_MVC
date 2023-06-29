using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcCvProject.Controllers
{
    public class AboutController : Controller
    {
        DbCvEntities db = new DbCvEntities();
        GenericRepository<TblAbout> repo = new GenericRepository<TblAbout>();

        [HttpGet]
        public ActionResult Index()
        {
            var About = repo.List();
            return View(About);
        }

        [HttpPost]
        public ActionResult Index(TblAbout p)
        {
            var t = repo.Find(x=>x.ID == 1);
            t.Name = p.Name;
            t.Surname = p.Surname;
            t.Address = p.Address;
            t.Email = p.Email;
            t.Phone = p.Phone;
            t.Description = p.Description;
            t.Image = p.Image;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}