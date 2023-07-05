using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        GenericRepository<TblAdmin> repo = new GenericRepository<TblAdmin>();
        public ActionResult Index()
        {
            var list = repo.List();
            return View(list);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(TblAdmin p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAdmin(int id)
        {
            TblAdmin t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            TblAdmin t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult UpdateAdmin(TblAdmin p)
        {
            TblAdmin t = repo.Find(x => x.ID == p.ID);
            t.UserName = p.UserName;
            t.Password = p.Password;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}