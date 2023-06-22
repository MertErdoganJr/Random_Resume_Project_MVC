using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class CertificateController : Controller
    {
        // GET: Certificate
        GenericRepository<TblCertificate> repo = new GenericRepository<TblCertificate>();
        public ActionResult Index()
        {
            var certificate = repo.List();
            return View(certificate);
        }
    }
}