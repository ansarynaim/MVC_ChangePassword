using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ChangePassword.Models;

namespace MVC_ChangePassword.Controllers
{
    public class Home1Controller : Controller
    {
        db_mvc_changepasswordEntities _db = new db_mvc_changepasswordEntities();
        public ActionResult AddHome()
        {
            int ID = Convert.ToInt32(Session["IDD"]);
            var data = _db.tblregistrations.Where(x=>x.rid==ID).ToList();
            return View(data);
        }
    }
}