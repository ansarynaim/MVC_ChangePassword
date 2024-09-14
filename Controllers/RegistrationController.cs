using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ChangePassword.Models;

namespace MVC_ChangePassword.Controllers
{
    public class RegistrationController : Controller
    {
        db_mvc_changepasswordEntities _db = new db_mvc_changepasswordEntities();
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddUser(tblregistration _reg)
        {
            _db.tblregistrations.Add(_reg);
            _db.SaveChanges();
            return View();
        }

        public ActionResult ShowUser()
        {
            var data = _db.tblregistrations.ToList();
            return View(data);
        }
    }
}