using MvcCvProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcCvProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            DbCvEntities db = new DbCvEntities();
            var UserInfo = db.TblAdmin.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (UserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(UserInfo.UserName, false);
                Session["KullaniciAdi"] = UserInfo.UserName.ToString();
                return RedirectToAction("Index", "About");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}