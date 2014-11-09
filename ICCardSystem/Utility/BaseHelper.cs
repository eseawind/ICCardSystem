using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICCardSystem.Common;
using ICCardSystem.Models;

namespace ICCardSystem.Utility
{
    /// <summary>
    /// 权限管理类
    /// </summary>
    public sealed class BaseHelper
    {
        // 权限基础初始化
        public static void InitData()
        {
            var _context = new ICModelContainer();
            // 等级
            //try
            //{
            //    if (_context.AdminLevels.Count() == 0)
            //    {
            //        _context.AdminLevels.Add(new AdminLevel() { Id = (byte)AdminLevelEnum.SuperAdmin, Name = "超级管理员" });
            //        _context.AdminLevels.Add(new AdminLevel() { Id = (byte)AdminLevelEnum.Admin, Name = "管理员" });
            //        _context.AdminLevels.Add(new AdminLevel() { Id = (byte)AdminLevelEnum.Operator, Name = "操作员" });
            //        _context.SaveChanges();
            //    }
            //}
            //catch (System.Exception ex) { LogHelper.WriteLog(ex); }
            // 管理员   
            try
            {
                if (_context.Admins.Count() == 0)
                {
                    Console.WriteLine("为系统管理员添加初始化数据");
                    _context.Admins.Add(new Admin() { AdminLevel = 1, Name = "root", Password = "root", WorkId = "root"});
                    _context.Admins.Add(new Admin() { AdminLevel = 1, Name = "admin", Password = "admin", WorkId = "admin" });
                    _context.SaveChanges();
                }
                if (_context.yhxxSet.Count() == 0)
                {
                    Console.WriteLine("为用户信息表添加初始化数据");
                    _context.yhxxSet.Add(new yhxx() { ywbh = 0, zz = "金银湖环湖路畔岛花园210栋2-1-1", zxh = "TX418", yhlx = 0, jdlx = 1 });
                    _context.yhxxSet.Add(new yhxx() { ywbh = 0, zz = "金银湖环湖路畔岛花园210栋1-1-1", zxh = "TX408", yhlx = 0, jdlx = 1 });
                    _context.yhxxSet.Add(new yhxx() { ywbh = 0, zz = "金银湖新澳阳光城10栋2-1-1", zxh = "TX308", yhlx = 0, jdlx = 1 });
                    _context.yhxxSet.Add(new yhxx() { ywbh = 0, zz = "金银湖环湖路畔岛花园104栋2-1-1", zxh = "TX23", yhlx = 0, jdlx = 1 });
                    _context.SaveChanges();
                }
            }
            catch (System.Exception ex) { LogHelper.WriteLog(ex); }
   
        }

        #region 私有成员

        /// <summary>
        /// 管理员权限等级枚举
        /// </summary>
        private enum AdminLevelEnum
        {
            SuperAdmin = 1,         // 超级管理员
            Admin,                  // 管理员
            Operator                // 操作员
        }

        #endregion

    }
}