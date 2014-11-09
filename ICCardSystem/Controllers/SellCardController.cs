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
    public class SellCardController : Controller
    {
        private DALBase baseDAL = new DALBase(new ICModelContainer());
        
        //
        // GET: /SellCard/

        public ActionResult FindNewUser()
        {
            var djglList = baseDAL.Get<djgl>().ToList();
            var jdlxList = baseDAL.Get<jdlx>().ToList();
            ViewBag.djglList = djglList;
            ViewBag.jdlxList = jdlxList;
            return View();
        }

        [HttpPost]

        public ActionResult FindNewUser(SearchConditionView searchCondition)
        {
            List<yhxx> yhxxlist = null;
            
            
            if (searchCondition.Condition1 != null )
            {
                yhxxlist = baseDAL.Get<yhxx>().Where(c => c.zz.Contains(searchCondition.Condition1) &&
                    c.zz.Contains(searchCondition.Condition2) && c.zz.Contains(searchCondition.Condition3)).ToList();
            }
            else
            {
                int number = int.Parse(searchCondition.Condition2);
                yhxxlist = baseDAL.Get<yhxx>().Where(c => c.kpbh == number).ToList();
            }

            //ViewBag.yhxxlist = yhxxlist;
            
            
            return Json(yhxxlist)  ;
        }

        [HttpPost]

        public ActionResult UpdateNewUser(yhxx newYhxx)
        {

            int ywbhNum;
            int total = baseDAL.Get<bhIndex>().ToList().Count;
            if (total == 0)
            {
                ywbhNum = 1;
            }
            else
            {

                ywbhNum = total + 1;
            }
            var bhIndex = new bhIndex
            {
                ywbh = ywbhNum,
            };
            baseDAL.AddItem<bhIndex>(bhIndex);
            var newUser = baseDAL.Get<yhxx>().FirstOrDefault(c => c.kpbh == newYhxx.kpbh);
            newUser.hm = newYhxx.hm;
            newUser.tel = newYhxx.tel;
            newUser.ywbh = ywbhNum;
            newUser.gqcs = 1;
            Session["ywbh"] = newUser.ywbh;
            Session["hm"] = newUser.hm;
            Session["zz"] = newUser.zz;
            Session["yhlx"] = newUser.yhlx;
            Session["tel"] = newUser.tel;
            Session["gqcs"] = newUser.gqcs;
            baseDAL.SaveAllChanges();
            

            
            return Json(newUser.ywbh);

        }
  
        public ActionResult NewCardCharge()
        {
            ViewBag.ywbh = Session["ywbh"];
            ViewBag.hm = Session["hm"];
            ViewBag.zz = Session["zz"];
            int yhlxNum = (int)Session["yhlx"];
            var djgl = baseDAL.Get<djgl>().FirstOrDefault(c => c.yhlx == yhlxNum);
            ViewBag.yhlx = djgl.ms;
            ViewBag.tel = Session["tel"];
            ViewBag.gqcs = Session["gqcs"];
            ViewBag.qj = djgl.qj;
            return View();
        }


    }
}
