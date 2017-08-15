using MVC5UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5UI.Controllers
{
    public class DataAnnotationsController : Controller
    {
        private MVC5UI_Model db = new MVC5UI_Model();

        // GET: DataAnnotations
        public ActionResult Index()
        {
            List<Account> accountList = db.Account.ToList();

            List<Role> roleList = db.Role.ToList();
            List<SelectListItem> roleSelectList = new List<SelectListItem>();
            roleSelectList.AddRange(new SelectList(roleList, "Id", "RoleName", 1));

            List<Status> statusList = db.Status.ToList();
            List<SelectListItem> statusSelectList = new List<SelectListItem>();
            statusSelectList.AddRange(new SelectList(statusList, "Id", "StatusName", 1));

            ViewBag.accountList = accountList;
            ViewBag.roleSelectList = roleSelectList;
            ViewBag.statusSelectList = statusSelectList;

            return View();
        }

        // Post: DataAnnotations
        [HttpPost]
        public ActionResult Index(Account account)
        {
            if (ModelState.IsValid)
            {
                db.Account.Add(account);
                db.SaveChanges();
            }
            List<Account> accountList = db.Account.ToList();

            List<Role> roleList = db.Role.ToList();
            List<SelectListItem> roleSelectList = new List<SelectListItem>();
            roleSelectList.AddRange(new SelectList(roleList, "Id", "RoleName", 1));

            List<Status> statusList = db.Status.ToList();
            List<SelectListItem> statusSelectList = new List<SelectListItem>();
            statusSelectList.AddRange(new SelectList(statusList, "Id", "StatusName", 1));

            ViewBag.accountList = accountList;
            ViewBag.roleSelectList = roleSelectList;
            ViewBag.statusSelectList = statusSelectList;

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}