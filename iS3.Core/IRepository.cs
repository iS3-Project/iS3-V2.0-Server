using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core
{
    public interface IRepository<T> where T : class, new()
    {
        Task<T> Create(T model);
        Task<List<T>> BatchCreate(List<T> models);

        Task<T> Update(T model);

        Task<T> Retrieve(int object_id);

        Task<List<T>> RetrieveByObjs(int objsid, string filter);
        Task<T> RetrieveByID(int id);
        Task<T> RetrieveByName(string  name);

        Task<List<T>> RetrieveAll();

        Task<int> Delete(T model);
        Task<int> BatchDelete(List<T> models);

        #region 1.创建对象-Create
        ///// <summary>
        ///// 创建对象
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //Task<string> Create(T model);


        ///// <summary>
        ///// 批处理创建对象
        ///// </summary>
        ///// <param name="models"></param>
        ///// <returns></returns>
        //Task<List<T>> BatchCreate(List<T> models);
        #endregion

        #region 2.更新对象-Update
        ///// <summary>
        ///// 更新对象
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //Task<T> Update(T model);

        ///// <summary>
        ///// 批处理更新对象
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //Task<List<T>> BatchUpdate(List<T> models);

        #endregion

        #region 3.检索对象-Retrieve
        ///// <summary>
        ///// 根据对象全局唯一标识检索对象
        ///// </summary>
        ///// <param name="guid"></param>
        ///// <returns></returns>
        //Task<T> Retrieve(string key);


        ///// <summary>
        ///// 根据条件表达式检索对象
        ///// </summary>
        ///// <param name="expression">条件表达式</param>
        ///// <returns></returns>
        ///// <exception cref = "ArgumentNullException" > source 为 null</exception>
        //Task<T> Retrieve(Expression<Func<T, bool>> expression);

        ///// <summary>
        ///// 根据主键获取
        ///// </summary>
        ///// <param name="key"></param>
        ///// <returns></returns>
        //Task<T> Retrieve(int key);

        ///// <summary>
        ///// 根据对象组和主键获取
        ///// </summary>
        ///// <param name="key"></param>
        ///// <returns></returns>
        //Task<T> Retrieve(int objsid,int key,string filter);

        ///// <summary>
        ///// 根据对象组和主键获取
        ///// </summary>
        ///// <param name="key"></param>
        ///// <returns></returns>
        //Task<List<T>> RetrieveByObjs(int objsid,string filter);

        //Task<List<T>> GetAll();

       // Task<List<T>> GetAll(Expression<Func<T, bool>> expression, Expression<Func<T, dynamic>> sortPredicate, SortOrder sortOrder, int skip, int take, out int total);
        #endregion

        #region 4.删除对象-Delete
        ///// <summary>
        ///// 根据对象全局唯一标识删除对象
        ///// </summary>
        ///// <param name="guid">对象全局唯一标识</param>
        ///// <returns>删除的对象数量</returns>
        //Task<int> Delete(Guid guid);
        ///// <summary>
        ///// 根据主键删除
        ///// </summary>
        ///// <param name="key"></param>
        ///// <returns></returns>
        //Task<int> Delete(T model);
        ///// <summary>
        ///// 根据对象全局唯一标识集合删除对象集合
        ///// </summary>
        ///// <param name="guids">全局唯一标识集合</param>
        ///// <returns>删除的对象数量</returns>
        //Task<int> BatchDelete(IList<Guid> guids);
        #endregion
    }
}
