using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ChangePassword.Models;

namespace MVC_ChangePassword.Controllers
{
    public class LoginController : Controller
    {
        db_mvc_changepasswordEntities _db = new db_mvc_changepasswordEntities();
        public ActionResult AddLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLogin(tblregistration _reg)
        {
            var data =(from  a in _db.tblregistrations where a.email==_reg.email && a.password==_reg.password select a ).ToList();
            if (data.Count > 0)
            {
                Session["IDD"] = data[0].rid;
                return RedirectToAction("AddHome","Home1");
            }
            else
            {
                ViewBag.msg = " OOPS!!! Login Failed !!!";
                return View();
            }
        }
    }
}