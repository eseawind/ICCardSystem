using System;
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
    public class RechargeController : Controller
    {
        private DALBase baseDAL = new DALBase(new ICModelContainer());
        //
        // GET: /Recharge/

        public ActionResult chongzhi()
        {
            return View();
        }

        [HttpPost]

        public ActionResult chongzhi(yhxx Yhxx)
        {
            DateTime now =  DateTime.Now;
            now.GetDateTimeFormats();
            var yhxx = baseDAL.Get<yhxx>().FirstOrDefault(c => c.ywbh == Yhxx.ywbh);
            if (yhxx.gqzl == null)
            {
                yhxx.gqzl = Yhxx.gqzl;
            }
            else
            {
                yhxx.gqcs = yhxx.gqcs + 1;
                yhxx.gqzl = Yhxx.gqzl + yhxx.gqzl;
             }

            yhxx.gqrq = now;
            baseDAL.SaveAllChanges();
            return Json(yhxx);
        } 


    }
}
