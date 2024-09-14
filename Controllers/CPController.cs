using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ChangePassword.Models;

namespace MVC_ChangePassword.Controllers
{
    public class CPController : Controller
    {
        db_mvc_changepasswordEntities _db = new db_mvc_changepasswordEntities();
        public ActionResult AddCP()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddCP(changepassword _cp)
        {
            if(_cp.newpassword == _cp.confirmnewpassword)
            {
                int ID = Convert.ToInt32(Session["IDD"]);
                var data = _db.tblregistrations.Find(ID);
                if (data.password == _cp.oldpassword)
                {
                    data.password = _cp.newpassword;
                    _db.Entry(data).State = System.Data.Entity.EntityState.Modified;
                    _db.SaveChanges();
                    ViewBag.msg = "Password has been changed Successfully!!!";
                }

                else
                {
                    ViewBag.msg = " old Password donot match!!";
                }

            }

            else
            {
                ViewBag.msg = " Password donot match!!";
            }

            
            return View();
        }

    }
}