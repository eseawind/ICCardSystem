using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICCardSystem.Common;
using ICCardSystem.Utility;
using ICCardSystem.Models;

namespace ICCardSystem.Controllers
{
    public class AdminController : Controller
    {
        private DALBase baseDAL = new DALBase(new ICModelContainer());

        /// <summary>
        /// 登陆页面
        /// </summary>
        /// <returns></returns>
        ///
        public ActionResult Login()
        {
            BaseHelper.InitData();
            if (Session["login_err"] == "1")
            {
                ViewBag.loginError = "用户名或密码错误";
            }
            // 返回用户列表
            var userList = baseDAL.Get<Admin>().ToList();
            ViewBag.userList = userList;
            return View();
        }

        /// <summary>
        /// 登陆提交页面
        /// </summary>
        /// <param name="admin">用户信息</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var user = baseDAL.Get<Admin>().FirstOrDefault(
                c => c.Name == admin.Name && c.Password == admin.Password);
            if (user != null)
            {
                Session["user_id"] = admin.Name;
                Session["login_err"] = null;
                return Json(Url.Action("Index", "Home"));
            }
            var userList = baseDAL.Get<Admin>().ToList();
            ViewBag.userList = userList;
            Session["login_err"] = "1";
            return Json(Url.Action("Login", "Admin"));
        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            Session["user_id"] = null;
            Session["authority_id"] = null;
            return RedirectToAction("Login", "Admin");
        }
	}
}