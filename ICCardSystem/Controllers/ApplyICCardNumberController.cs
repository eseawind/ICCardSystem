using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICCardSystem.Models;
using ICCardSystem.Models.VModels;
using ICCardSystem.Utility;

namespace ICCardSystem.Controllers
{
    public class ApplyICCardNumberController : Controller
    {
        private DALBase baseDAL = new DALBase(new ICModelContainer());
        //
        // GET: /ApplyICCardNumber/

        public ActionResult ICCardNumber()
        {
            var djglList = baseDAL.Get<djgl>().ToList();
            var bdIndex = baseDAL.Get<bhIndex>().ToList().Count;
            ViewBag.djglList = djglList;
            ViewBag.bdIndex = bdIndex;
            return View();
        }

    }
}
