using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICCardSystem.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            // 登陆判断
            if (Session["user_id"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Admin");
        }

        public ActionResult Index2()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// 首页标题和登陆部分
        /// </summary>
        /// <returns></returns>
        public ActionResult Top()
        {
            // 登陆判断
            if (Session["user_id"] != null)
            {
                ViewBag.username = Session["user_id"];
                return View();
            }
            return RedirectToAction("Login", "Admin");
        }

        /// <summary>
        /// 菜单栏
        /// </summary>
        /// <returns></returns>
        public ActionResult Menu()
        {
            // 登陆判断
            if (Session["user_id"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Admin");
        }
	}
}