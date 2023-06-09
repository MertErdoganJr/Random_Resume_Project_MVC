﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        GenericRepository<TblCommunication> repo = new GenericRepository<TblCommunication>();
        public ActionResult Index()
        {
            var message = repo.List();
            return View(message);
        }
    }
}