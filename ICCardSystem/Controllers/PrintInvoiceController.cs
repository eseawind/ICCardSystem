using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICCardSystem.Controllers
{
    public class PrintInvoiceController : Controller
    {
        //
        // GET: /PrintInvoice/

        public ActionResult Print()
        {
            return View();
        }

    }
}
