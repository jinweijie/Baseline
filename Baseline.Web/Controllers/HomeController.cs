using Baseline.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baseline.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Env = ConfigurationManager.AppSettings["Env"];

            var users = UserRepository.GetAllUsers();
            return View(users);
        }

    }
}
