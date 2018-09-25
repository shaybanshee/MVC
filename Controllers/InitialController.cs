using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicApp2.Controllers
{
    public class InitialController : Controller
    {
        // GET: Initial
     
        public ActionResult Index()
        {
            return View();
        }
    }
}