using System;
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
    public class FaKaRechargeController : Controller
    {
        private DALBase baseDAL = new DALBase(new ICModelContainer());
        //
        // GET: /FaKaRecharge/

        public ActionResult fakaRecharge()
        {
            return View();
        }

        [HttpPost]

        public String getUserByYwbh(yhxx postYhxx)
        {
            var yhxx = baseDAL.Get<yhxx>().FirstOrDefault(c => c.ywbh == postYhxx.ywbh);
            Session["ywbh"] = yhxx.ywbh;
            Session["hm"] = yhxx.hm;
            Session["zz"] = yhxx.zz;
            Session["yhlx"] = yhxx.yhlx;
            Session["tel"] = yhxx.tel;
            Session["gqcs"] = yhxx.gqcs;
            return "../SellCard/NewCardCharge";


        }

    }
}
