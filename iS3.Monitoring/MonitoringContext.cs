using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
using System.Data.Entity;

namespace iS3.Monitoring
{
    public class MonitoringContext : iS3Context
    {

        private string tablePrefix = "Project_";
        public override string TablePrefix { get { return tablePrefix; } }
        public MonitoringContext(string project) : base(project)
        {
            Database.SetInitializer<MonitoringContext>(new CreateDatabaseIfNotExists<MonitoringContext>());
        }
        public MonitoringContext() : base()
        { }
        public virtual DbSet<MonGroup> MonGroup { get; set; }
        public virtual DbSet<MonPoint> MonPoint { get; set; }
        public virtual DbSet<MonReading> MonReading { get; set; }

    }
}
