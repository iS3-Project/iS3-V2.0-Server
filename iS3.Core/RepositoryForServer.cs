using iS3.Core;
using iS3.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core

{
    public class RepositoryForServer<T> : IRepository<T> where T : iS3AreaHandle, new()
    {
        #region  反射相关
        //获取对象的domain标签
        //
        static string domainName {get { return new T().GetType().ToString().Split('.')[1]; } }
        // 获取程序集名称
        //
        static string repoNameSpace { get { return string.Format("iS3.{0}.Server.Repository.{1}", domainName, new T().GetType().Name + "_Repo"); } }
        static string contextNameSpace { get { return string.Format("iS3.{0}.{1}", domainName, domainName + "Context"); } }
        static string assemblyName { get { return string.Format("iS3.{0}", domainName); } }
        public string project;
        #endregion
        public iS3Context context { get; set; }

        //统一入口
        public static RepositoryForServer<T> GetInstance(string project)
        {
            try
            {
                //反射获取Context
                //
                string path = repoNameSpace + "," + assemblyName;//命名空间.类型名,程序集
                Type o = Type.GetType(path);//加载类型
                if (o!=null)
                {
                    object obj = Activator.CreateInstance(o,project);
                    (obj as RepositoryForServer<T>).project = project;
                    return obj as RepositoryForServer<T>;
                }
                else
                {
                    RepositoryForServer<T> repo = new RepositoryForServer<T>(project);
                    repo.project = project;
                    return repo;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public RepositoryForServer(string project)
        {
            try
            {
                //反射获取Context
                //
                string path = contextNameSpace + "," + assemblyName;//命名空间.类型名,程序集
                Type o = Type.GetType(path);//加载类型
                object obj = Activator.CreateInstance(o, project); //根据类型创建实例

                context = obj as iS3Context;
            }
            catch(Exception ex)
            {

            }
        }
        public virtual async Task<T> Create(T model)
        {
            try
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Added;
                var createRowCount = context.SaveChanges();
                return createRowCount > 0 ? model : null;
            }
            catch( Exception ex)
            {
                return null;
            }

        }
        public virtual T AddChildren(int objid,List<int> child)
        {
            return null;
        }
        public virtual async Task<List<T>> BatchCreate(List<T> models)
        {
            context.Entry(models).State = System.Data.Entity.EntityState.Added;
            var createRowCount = context.SaveChanges();
            return createRowCount > 0 ? models : null;
        }
        public virtual async Task<T> Update(T model)
        {
            T obj = context.Set<T>().Find((model as iS3AreaHandle).object_id);
            UpdateModelHelp.Update(model, obj);
            context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return obj;
        }

        public virtual async Task<T> Retrieve(int object_id)
        {
            try
            {
                return context.Set<T>().Find(object_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public virtual async Task<T> RetrieveByID(int id)
        {
            try
            {
                return context.Set<T>().Where(x => x.ID == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public virtual async Task<T> RetrieveByName(string name)
        {
            try
            {
                return context.Set<T>().Where(x => x.Name == name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public virtual async Task<List<T>> RetrieveByObjs(int objsid, string filter)
        {
            try
            {
                string sql = DGObjectsFilter.GetDGObjectsSQL(context.Project, context.TablePrefix + new T().GetType().Name, objsid, filter);
                var result = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<T>(sql).ToList();
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public virtual async Task<List<T>> RetrieveAll()
        {
            try
            {
                return context.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }

        public virtual async Task<int> Delete(T model)
        {
            try
            {
                T obj = context.Set<T>().Find((model as iS3AreaHandle).object_id);
                context.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public virtual async Task<int> BatchDelete(List<T> models)
        {
            try
            {
                foreach (T _obj in models)
                {
                    T obj = context.Set<T>().Find((_obj as iS3AreaHandle).object_id);
                    context.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                }
                
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

      
    }
}
