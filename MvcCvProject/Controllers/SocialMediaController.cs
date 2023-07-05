﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        GenericRepository<TblSocialMedia> repo = new GenericRepository<TblSocialMedia>();
        
        public ActionResult Index()
        {
            var data = repo.List();
            return View(data);
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedia p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetPage(int id)
        {
            var account = repo.Find(x => x.ID == id);
            return View(account);
        }

        [HttpPost]
        public ActionResult GetPage(TblSocialMedia p)
        {
            var account = repo.Find(x => x.ID == p.ID);
            account.SocialMediaName = p.SocialMediaName;
            account.Link = p.Link;
            account.Status = true;
            account.Icon = p.Icon;
            repo.TUpdate(account);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var account = repo.Find(x => x.ID == id);
            account.Status = false;
            repo.TUpdate(account);
            return RedirectToAction("Index");
        }
    }
}