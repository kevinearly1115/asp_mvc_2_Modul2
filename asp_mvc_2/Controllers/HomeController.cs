using asp_mvc_2.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_mvc_2.Controllers
{
    public class HomeController : Controller
    {
        [AuthorizeRoles("Admin")]
        public ActionResult AdminOnly()
        {
            return View();
        }

        public ActionResult UnAuthorized()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Welcome()
        {
            return View();
        }
    }
}