using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF_With_Authentication_Client.Models;

namespace WCF_With_Authentication_Client.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            HelloClient hc = new HelloClient();
            ViewBag.Result = hc.HelloWord() ?? "Asses denied";
            return View();
        }
    }
}