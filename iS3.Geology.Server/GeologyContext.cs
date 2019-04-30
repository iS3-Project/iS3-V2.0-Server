using iS3.Core.Server;
using iS3.Geology.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace iS3.Geology.Server
{
    public class GeologyContext : iS3Context
    {
        private string tablePrefix = "Geology_";
        public override string TablePrefix { get { return tablePrefix; } }
        public GeologyContext(string project) : base(project)
        { }
        public GeologyContext() : base()
        { }
        public virtual DbSet<AERP> AERP { get; set; }
        public virtual DbSet<AGEO> AGEO { get; set; }
        public virtual DbSet<AWAD> AWAD { get; set; }
        public virtual DbSet<BOHO> BOHO { get; set; }
        public virtual DbSet<CDEM> CDEM { get; set; }
        public virtual DbSet<CONT> CONT { get; set; }
        public virtual DbSet<CORE> CORE { get; set; }
        public virtual DbSet<DISR> DISR { get; set; }
        public virtual DbSet<DMTG> DMTG { get; set; }
        public virtual DbSet<DMTP> DMTP { get; set; }
        public virtual DbSet<DMTT> DMTT { get; set; }
        public virtual DbSet<DPRD> DPRD { get; set; }
        public virtual DbSet<DPRG> DPRG { get; set; }
        public virtual DbSet<EXPA> EXPA { get; set; }
        public virtual DbSet<FDSD> FDSD { get; set; }
        public virtual DbSet<FDST> FDST { get; set; }
        public virtual DbSet<FREZ> FREZ { get; set; }
        public virtual DbSet<GEOE> GEOE { get; set; }
        public virtual DbSet<GEOS> GEOS { get; set; }
        public virtual DbSet<GEPR> GEPR { get; set; }
        public virtual DbSet<GMPG> GMPG { get; set; }
        public virtual DbSet<HDPH> HDPH { get; set; }
        public virtual DbSet<HFTD> HFTD { get; set; }
        public virtual DbSet<HFTG> HFTG { get; set; }
        public virtual DbSet<HFTP> HFTP { get; set; }
        public virtual DbSet<HFTR> HFTR { get; set; }
        public virtual DbSet<HYCH> HYCH { get; set; }
        public virtual DbSet<HYUN> HYUN { get; set; }
        public virtual DbSet<IRSI> IRSI { get; set; }
        public virtual DbSet<PLTG> PLTG { get; set; }
        public virtual DbSet<PLTT> PLTT { get; set; }
        public virtual DbSet<PMTD> PMTD { get; set; }
        public virtual DbSet<PMTG> PMTG { get; set; }
        public virtual DbSet<PUTR> PUTR { get; set; }
        public virtual DbSet<RDEN> RDEN { get; set; }
        public virtual DbSet<RELD> RELD { get; set; }
        public virtual DbSet<RIVR> RIVR { get; set; }
        public virtual DbSet<RMAR> RMAR { get; set; }
        public virtual DbSet<RMCT> RMCT { get; set; }
        public virtual DbSet<RSHD> RSHD { get; set; }
        public virtual DbSet<RSHG> RSHG { get; set; }
        public virtual DbSet<RSVR> RSVR { get; set; }
        public virtual DbSet<RTEN> RTEN { get; set; }
        public virtual DbSet<RUCS> RUCS { get; set; }
        public virtual DbSet<SCPD> SCPD { get; set; }
        public virtual DbSet<SCPG> SCPG { get; set; }
        public virtual DbSet<SDEM> SDEM { get; set; }
        public virtual DbSet<SDEN> SDEN { get; set; }
        public virtual DbSet<SPEC> SPEC { get; set; }
        public virtual DbSet<SPPO> SPPO { get; set; }
        public virtual DbSet<SPTR> SPTR { get; set; }
        public virtual DbSet<SSAT> SSAT { get; set; }
        public virtual DbSet<STRA> STRA { get; set; }
        public virtual DbSet<TDEM> TDEM { get; set; }
        public virtual DbSet<TREG> TREG { get; set; }
        public virtual DbSet<TRET> TRET { get; set; }
        public virtual DbSet<TRIG> TRIG { get; set; }
        public virtual DbSet<TRIT> TRIT { get; set; }
        public virtual DbSet<TSAT> TSAT { get; set; }
        public virtual DbSet<VANE> VANE { get; set; }
        public virtual DbSet<WADD> WADD { get; set; }
        public virtual DbSet<WASH> WASH { get; set; }
        public virtual DbSet<WEAT> WEAT { get; set; }
        public virtual DbSet<WITR> WITR { get; set; }
        public virtual DbSet<WSPA> WSPA { get; set; }

        public virtual DbSet<Borehole> Borehole { get; set; }
        public virtual DbSet<BoreholeStrata> BoreholeStrata { get; set; }
       
        public virtual DbSet<PROJ> PROJ { get; set; }
    }
}