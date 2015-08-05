using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelSample.Controllers
{
    public class PopUpController : Controller
    {
        // GET: PopUp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PopUp(/*MyModel model*/)
        {
            // Call a service and set a member on the model with the result
            return PartialView("_PopUp"/*, model*/);
        }

        [HttpPost]
        public ActionResult PopUp(MyModel model)
        {
            return RedirectToAction("Register", "Account");
        }

        [HttpGet]
        public ActionResult GetPopUpPartial()
        {
            return PartialView("_PopUp");
        }
    }

    public class MyModel
    {
        public int Number { get; set; }
    }
}