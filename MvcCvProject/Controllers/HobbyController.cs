using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject;
using MvcCvProject.Repositories;
using MvcCvProject.Models.Entity;

namespace MvcCvProject.Controllers
{
    public class HobbyController : Controller
    {
        // GET: Hobby
        GenericRepository<TblHobby> repo = new GenericRepository<TblHobby>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobby = repo.List();
            return View(hobby);
        }

        [HttpPost]
        public ActionResult Index(TblHobby p)
        {
            var t = repo.Find(x => x.ID == 2);
            t.Description1 = p.Description1;
            t.Description2 = p.Description2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}