using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ESL.Web.Models.Attribute;

namespace ESL.Web.Areas.Dashboard.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}