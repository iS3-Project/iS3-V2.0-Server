using iS3.Core.Model;
using iS3.Core.Server.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core
{
    public class CoreContext : iS3Context
    {
        private string tableprefix = "Project_";
        public override string TablePrefix
        {
            get { return tableprefix; }
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    ////TreeDefinition 
        //    //modelBuilder.Entity<TreeDefinition>().MapToStoredProcedures().ToTable(tableprefix + "TreeDefinition");  //映射表名
        //    //modelBuilder.Entity<TreeDefinition>().HasKey(t => t.ID);                                                //定义主键
        //    //modelBuilder.Entity<TreeDefinition>().Ignore(t => t.Chillds);                                           //设置不映射
        //    //modelBuilder.Entity<ObjectsDefinition>().Ignore(t => t.Filter);

        //    //modelBuilder.Entity<ObjectsDefinition>().MapToStoredProcedures().ToTable(tableprefix + "ObjectsDefinition");
        //    //modelBuilder.Entity<ObjectsDefinition>().HasKey(t => t.ID);

        //}
        public CoreContext(string project) : base(project)
        {
        }
        public CoreContext() : base()
        {
        }
        public virtual DbSet<ProjectLocation> ProjectLocation { get; set; }
        public virtual DbSet<ObjectsDefinition> ObjectsDefinition { get; set; }
        //public virtual DbSet<DataSourceInfo> DataSourceInfo { get; set; }
        public virtual DbSet<TreeDefinition> TreeDefinition { get; set; }
        public virtual DbSet<DGObjectMeta> DGObjectMeta { get; set; }
        //public virtual DbSet<UserToken> UserToken { get; set; }
        //public virtual DbSet<User> User { get; set; }
        //public virtual DbSet<Log> Log { get; set; }
        //public virtual DbSet<ProjectInfo> ProjectInfo { get; set; }


        //public virtual DbSet<UnitInfo> UnitInfo { get; set; }
        //public virtual DbSet<PersonnelInfo> PersonnelInfo { get; set; }
        //public virtual DbSet<DataSourceType> DataSourceType { get; set; }
        //public virtual DbSet<GISDef> GISDef { get; set; }
        //public virtual DbSet<EngineeringMap> EngineeringMap { get; set; }
        //public virtual DbSet<LayerDef> LayerDef { get; set; }

        //public virtual DbSet<ObjRef> ObjRef { get; set; }
    }
}
