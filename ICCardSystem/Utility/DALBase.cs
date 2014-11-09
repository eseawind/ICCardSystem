using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace ICCardSystem.Utility
{
    /// <summary>
    /// 数据访问基础类
    /// </summary>
    public class DALBase
    {
        protected DbContext _DataModelEntity;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="con">上下文</param>
        public DALBase(DbContext con)
        {
            _DataModelEntity = con;
        }

        /// <summary>
        /// 返回指定表的所有行
        /// </summary>
        /// <typeparam name="T">查询的表的实体类型</typeparam>
        public DbSet<T> Get<T>() where T : class, new()
        {
            try
            {
                return _DataModelEntity.Set<T>();
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
                return null;
            }
        }
        /// <summary>
        /// 标记指定记录为待删除状态
        /// </summary>
        /// <param name="item">待删除的元组</param>
        public void DeleteItem(object item)
        {
            _DataModelEntity.Set(item.GetType()).Remove(item);
        }
        /// <summary>
        /// 标记指定的记录集合为待删除状态
        /// </summary>
        /// <param name="items">待删除的元组集合</param>
        /// <returns></returns>
        public void DeleteItems(IList items)
        {
            int orgCount = items.Count;
            for (int i = 0; i < items.Count; i++)
            {
                DeleteItem(items[i]);
                if (orgCount != items.Count)
                    --i;
            }
        }
        /// <summary>
        /// 添加新的记录对象到上下文对象中
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="item">记录</param>
        public bool AddItem<T>(T item) where T : class, new()
        {
            try
            {
                _DataModelEntity.Set<T>().Add(item);
                return true;
            }
            catch (System.Exception ex)
            {
                LogHelper.WriteLog(ex);
                return false;
            }
        }
        /// <summary>
        /// 添加记录集合到上下文对象中
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="items">记录集合</param>
        public bool AddItems<T>(IEnumerable<T> items) where T : class, new()
        {
            try
            {
                var dataSets = _DataModelEntity.Set<T>();
                foreach (T item in items)
                    dataSets.Add(item);
                return true;
            }
            catch (System.Exception ex)
            {
                LogHelper.WriteLog(ex);
                return false;
            }
        }
        /// <summary>
        /// 保存对数据库的修改
        /// </summary>
        public bool SaveAllChanges()
        {
            try
            {
                _DataModelEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
                return false;
            }
        }
    }
}