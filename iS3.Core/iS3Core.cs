using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
 * This file defines iS3 Server core classes (MiniServer-OS).
 * 
 * 1. iS3Area, iS3Domain, iS3Project and iS3Territory are core conceptual classes
 *      in iS3 Server.
 *    Think iS3Territory as a land, and it is divided into iS3Domains horizontally,
 *      and divided into iS3Projects vertically, which are all based on iS3Area.
 *      Therefore, iS3Domain may contains many iS3Projects, and vice versa.
 *    Take a company as example, the company is working on a land, i.e., iS3Territory.
 *      iS3Domains are company's departments which are in charge of every aspects
 *      of the company. 
 *      iS3Projects are site works the company is taking care of. Typically, the
 *      project management will go through many departments of the company, 
 *      here is iS3Domain.
 *      
 * 2. iS3AreaHandle, iS3DomainHandle, iS3ProjectHandle and iS3TerritoryHandle are 
 *      handles to iS3Area, iS3Domain, iS3Project and iS3Territory, respectively.
 *    Handle is used to uniquely identify and operate the above classes.
 *    Handle is also stored in the main database, to keep track of those classes
 *      and their relationships.
 *      
 * 3. iS3MainDbContext inherits from System.Data.Entity.DbContext, known as 
 *      EntityFramework. It read/stores handles to the main database, 
 *      and maintains the relationship between handles.
 *      
 * 4. MiniServer is a static class, and hosts static methods, which could be thought
 *      as providing OS-like operation functions, such as create/get territory, domain
 *      and project.
 *    MiniServer also host global Territories data:
 *      Dictionary<string, iS3Territory> Territories
 *    Each member (iS3Territory object) in Territories hosts all domain and project data.
 *      Therefore, it maintains a state of territory, and it is a 'digital twin' of 
 *      the real 'land'.
 *    Note: The territory has only one state. As a rule, the state should be maintained
 *      by Admin, not by User. In other words, User use WebAPI to get/add data,
 *      and get services, but should not change the runtime state of the territory.
 *      Admin can change the runtime state of the territory. In cases that a user
 *      put data into database and then another user retrieve the new data, is not
 *      considered as changing the runtime state of the territory. This changes
 *      the database state, not the runtime state.
 * 
 */

namespace iS3.Core
{
    // iS3Area Handle
    //
    public class iS3AreaHandle
    {
        [Key]
        public int object_id { get; set; }
        // ID of the area
        public int ID { get; set; }
        // Name of the area
        public string Name { get; set; }
        // Description of the area
        public string Description { get; set; }
        //FullName of the area
        public string FullName { get; set; }
        // Type of the area
        [NotMapped]
        public string Type { get; set; }

        // Indicates if the area is the default
        [NotMapped]
        public bool Default { get; set; }

        // Parent area ID
        [NotMapped]
        public string ParentID { get; set; }

        // Database name
        [NotMapped]
        public string DbName { get; set; }
    }

    // iS3DomainHandle: iS3Domain Handle
    // Sealed class, do not inherit
    //
    public sealed class iS3DomainHandle : iS3AreaHandle
    {
        public iS3DomainHandle()
        {
        }
    }

    // iS3ProjectHandle: iS3Project Handle
    // Sealed class, do not inherit
    //
    public sealed class iS3ProjectHandle : iS3AreaHandle
    {
        public iS3ProjectHandle()
        {
        }
    }

    // iS3TerritoryHandle: iS3Territory Handle
    // Sealed class, do not inherit
    //
    public sealed class iS3TerritoryHandle : iS3AreaHandle
    {
        public ICollection<iS3DomainHandle> DomainHandles { get; set; }
        public ICollection<iS3ProjectHandle> ProjectHandles { get; set; }

        public iS3TerritoryHandle()
        {
            DomainHandles = new List<iS3DomainHandle>();
            ProjectHandles = new List<iS3ProjectHandle>();
        }
        
        public iS3DomainHandle GetDomainHandle(string NameOrID)
        {
            iS3DomainHandle result = null;
            bool exist = DomainHandles.Any(c => c.ID == int.Parse(NameOrID));
            if (exist)
            {
                result = DomainHandles.First(c => c.ID == int.Parse(NameOrID));
            }
            else
            {
                exist = DomainHandles.Any(c => c.Name == NameOrID);
                if (exist)
                {
                    result = DomainHandles.First(c => c.Name == NameOrID);
                }
            }
            return result;
        }
    }

    public class iS3Area
    {
        public iS3AreaHandle AreaHandle { get; set; }
        public iS3Area (iS3AreaHandle handle)
        {
            AreaHandle = handle;
        }
    }

    public class iS3Domain : iS3Area
    {
        public iS3DomainHandle DomainHandle { get; set; }
        public iS3Domain(iS3DomainHandle handle) : base(handle)
        {
            DomainHandle = handle;
        }
    }

    public class iS3Project : iS3Area
    {
        public iS3ProjectHandle ProjectHandle { get; set; }
        public iS3Project(iS3ProjectHandle handle) : base(handle)
        {
            ProjectHandle = handle;
        }
    }

    public class iS3Territory : iS3Area
    {
        public iS3TerritoryHandle TerritoryHandle { get; set; }

        public ICollection<iS3Domain> Domains { get; set; }
        public ICollection<iS3Project> Projects { get; set; }

        public iS3Territory(iS3TerritoryHandle handle) : base(handle)
        {
            TerritoryHandle = handle;

            Domains = new List<iS3Domain>();
            Projects = new List<iS3Project>();
        }
    }

    public  class iS3RolesInArea
    {
        public string UserName { get; set; }
        public string AreaName { get; set; }
        public string Roles { get; set; }
    }

    // Main database of the server context
    //
    public class iS3MainDbContext : DbContext
    {
        public iS3MainDbContext() :
            base(MiniServer.DefaultDatabase)
        {
            //Database.SetInitializer<iS3MainDbContext>(new CreateDatabaseIfNotExists<iS3MainDbContext>());
            //Database.SetInitializer<iS3MainDbContext>(new DropCreateDatabaseIfModelChanges<iS3MainDbContext>());
            Database.SetInitializer<iS3MainDbContext>(new DropCreateDatabaseAlways<iS3MainDbContext>());
        }

        //public DbSet<iS3Domain> Domains { get; set; }
        public DbSet<iS3TerritoryHandle> TerritoryHandles { get; set; }
    }

    // MiniServer: OS of the server
    //  1. It operates on the default database to store territories, domains and projects.
    //  2. It maintains the relationship between territory and its domains and projects.
    //
    public static class MiniServer
    {
        // Default database name
        //
        public const string DefaultDatabase = "iS3Db";

        // Global territories variable
        //
        public static Dictionary<string, iS3Territory>
            Territories = new Dictionary<string, iS3Territory>();


        #region "Handle methods"
        // Get all territory handles.
        // In other words, get all territories that are hosted on the server.
        //
        public static async Task<ICollection<iS3TerritoryHandle>> GetAllTerritoryHandles()
        {
            ICollection<iS3TerritoryHandle> result = null;
            using (var ctx = new iS3MainDbContext())
            {
                result = await ctx.TerritoryHandles.ToListAsync();
            }
            return result;
        }

        // Get territory handle.
        // Note:
        //     1. If not found, it will try to return the territory which is the default,
        //        i.e., iS3TerritoryHandle.Default==true
        //     2. if ctx is null, default context, i.e., the default database will be used. 
        // 
        public static async Task<iS3TerritoryHandle> getTerritoryHandle(string nameOrID,
            iS3MainDbContext ctx = null)
        {
            iS3TerritoryHandle tHandle = null;
            if (ctx == null)
            {
                using (var ctx_new = new iS3MainDbContext())
                {
                    tHandle = await getTerritoryHandleInternal(nameOrID, ctx_new);
                    
                    // explicit load domain handles
                    //
                    var entry = ctx_new.Entry(tHandle).Collection(t => t.DomainHandles);
                    var isLoaded = entry.IsLoaded;
                    await entry.LoadAsync();
                    isLoaded = entry.IsLoaded;

                    return tHandle;
                }
            }
            else
            {
                tHandle = await getTerritoryHandleInternal(nameOrID, ctx);

                // explicit load domain handles
                //
                var entry = ctx.Entry(tHandle).Collection(t => t.DomainHandles);
                var isLoaded = entry.IsLoaded;
                await entry.LoadAsync();
                isLoaded = entry.IsLoaded;

                return tHandle;
            }
        }

        static async Task<iS3TerritoryHandle> getTerritoryHandleInternal(string nameOrID,
            iS3MainDbContext ctx)
        {
            iS3TerritoryHandle result = null;
            bool exist = await ctx.TerritoryHandles.AnyAsync(c => c.ID == int.Parse(nameOrID));
            if (exist)
            {
                result = await ctx.TerritoryHandles.FirstAsync(c => c.ID == int.Parse(nameOrID));
                return result;
            }
            exist = await ctx.TerritoryHandles.AnyAsync(c => c.Name == nameOrID);
            if (exist)
            {
                result = await ctx.TerritoryHandles.FirstAsync(c => c.Name == nameOrID);
                return result;
            }
            exist = await ctx.TerritoryHandles.AnyAsync(c => c.Default == true);
            if (exist)
            {
                result = await ctx.TerritoryHandles.FirstAsync(c => c.Default == true);
                return result;
            }
            return null;
        }

        // Add a new territory handle:
        //   name,  should be filled
        //   if type is not give, i.e., null, default is iS3SimpleTerritory
        //   if dbName is not given, i.e., null, default database name will be used.
        //
        public static async Task<iS3TerritoryHandle> AddTerritoryHandle(string name,
            string type = null, string dbName = null)
        {
            if (name == null)
            {
                throw new Exception("Argument Null");
            }
            if (type == null)
                type = typeof(iS3SimpleTerritory).ToString();

            using (var ctx = new iS3MainDbContext())
            {
                bool exists = await ctx.TerritoryHandles.AnyAsync(c => c.Name == name);
                if (exists)
                {
                    throw new Exception("Already exists");
                }

                iS3TerritoryHandle newTerritoryHandle = new iS3TerritoryHandle();
                newTerritoryHandle.ID = int.Parse(Guid.NewGuid().ToString());
                newTerritoryHandle.Name = name;
                newTerritoryHandle.Type = type;
                if (dbName == null)
                    newTerritoryHandle.DbName = MiniServer.DefaultDatabase;
                else
                    newTerritoryHandle.DbName = dbName;

                var result = ctx.TerritoryHandles.Add(newTerritoryHandle);
                await ctx.SaveChangesAsync();

                return newTerritoryHandle;
            }
        }


        // Add a new domain handle:
        //   name, type, parentNameOrID  should be filled
        //   if dbName is not given, i.e., null, default database name will be used.
        //
        public static async Task<iS3DomainHandle> AddDomainHandle(string name,
            string type, string parentNameOrID, string dbName = null)
        {
            iS3TerritoryHandle territoryHandle = null;

            using (var ctx = new iS3MainDbContext())
            {
                territoryHandle = await getTerritoryHandle(parentNameOrID, ctx);
                if (territoryHandle == null)
                {
                    throw new Exception("Territory null and no default");
                }

                bool exist = territoryHandle.DomainHandles.Any(c => c.Name == name);
                if (exist)
                {
                    throw new Exception("Already exists");
                }

                iS3DomainHandle domainHandle = new iS3DomainHandle();
                domainHandle.ID = int.Parse(Guid.NewGuid().ToString());
                domainHandle.Name = name;
                domainHandle.Type = type;
                domainHandle.ParentID = territoryHandle.ID.ToString();

                if (domainHandle.DbName == null)
                {
                    if (territoryHandle.DbName != null)
                        domainHandle.DbName = territoryHandle.DbName;
                    else
                        domainHandle.DbName = MiniServer.DefaultDatabase;
                }

                territoryHandle.DomainHandles.Add(domainHandle);
                await ctx.SaveChangesAsync();

                return domainHandle;
            }
        }

        // Get domain handle:
        //   NameOrID: should be filled
        //   ParentNameOrID: if not specified, the default Territory will be assumed
        //
        public static async Task<iS3DomainHandle> GetDomainHandle(string nameOrID,
            string parentNameOrID)
        {
            if (nameOrID == null)
            {
                return null;
            }

            iS3TerritoryHandle territoryHandle = null;
            iS3DomainHandle result = null;
            using (var ctx = new iS3MainDbContext())
            {
                territoryHandle = await getTerritoryHandle(parentNameOrID, ctx);
                if (territoryHandle == null)
                {
                    return null;
                }

                result = territoryHandle.GetDomainHandle(nameOrID);
            }

            return result;
        }
        #endregion

        #region "Helper functions"
        public static void AddTerritory(iS3Territory territory)
        {
            string ID = territory.TerritoryHandle.ID.ToString();
            Territories[ID] = territory;
        }
        public static iS3Territory GetTerritory(string ID)
        {
            return Territories[ID];
        }
        // Get subclasses of specified type T
        //
        public static ICollection<string> GetSubClasses<T>()
        {
            IEnumerable<Type> subclasses =
                   from assembly in AppDomain.CurrentDomain.GetAssemblies()
                   from type in assembly.GetTypes()
                   where type.IsSubclassOf(typeof(T))
                   select type;
            List<string> result = new List<string>();
            foreach (var x in subclasses)
                result.Add(x.ToString());

            return result;
        }

        // Get the type of the specified class name
        //
        public static Type GetType(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type t = assembly.GetType(className);
            if (t != null)
            {
                return t;
            }

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var x in assemblies)
            {
                t = x.GetType(className);
                if (t != null)
                {
                    return t;
                }
            }
            return null;
        }
        #endregion


        // Add territory using the corresponding information in handle
        // Returns the newly added territory handle (not the input one).
        //
        public static async Task<iS3TerritoryHandle> AddTerritory(
            iS3TerritoryHandle territoryHandle)
        {
            iS3TerritoryHandle newHandle =
                await MiniServer.AddTerritoryHandle(territoryHandle.Name, 
                territoryHandle.Type, territoryHandle.DbName);

            Type t = MiniServer.GetType(newHandle.Type);
            iS3Territory territory = (iS3Territory)
                Activator.CreateInstance(t, newHandle);

            MiniServer.AddTerritory(territory);

            return newHandle;
        }

        // Add domain using the corresponding information in handle
        // Returns the newly added domain handle (not the input one).
        //
        public static async Task<iS3DomainHandle> AddDomain(
            iS3DomainHandle domainHandle)
        {
            iS3DomainHandle newHandle =
                await MiniServer.AddDomainHandle(domainHandle.Name, domainHandle.Type,
                domainHandle.ParentID, domainHandle.DbName);
                
            iS3Territory territory = MiniServer.GetTerritory(newHandle.ParentID);

            Type t = MiniServer.GetType(newHandle.Type);
            iS3Domain domain = (iS3Domain)
                Activator.CreateInstance(t, newHandle);

            territory.Domains.Add(domain);

            return newHandle;
        }
    }



}
