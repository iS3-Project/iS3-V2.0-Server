namespace iS3.Geology.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Geology_AERP",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AERP_ID = c.String(),
                        AERP_TYPE = c.String(),
                        AERP_HEIG = c.String(),
                        AERP_DIP = c.String(),
                        AERP_DTIM = c.String(),
                        AERP_STAFF = c.String(),
                        AERP_CONT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_AGEO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AGEO_ID = c.String(),
                        AGEO_TYPE = c.String(),
                        AGEO_DSRG = c.String(),
                        AGEO_AREA = c.String(),
                        AGEO_EGP = c.String(),
                        AGEO_LAWD = c.String(),
                        AGEO_REM = c.String(),
                        AGEO_DISA = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_AWAD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        AWAD_WTAB = c.Decimal(precision: 18, scale: 2),
                        AWAD_REM = c.String(),
                        AWAD_METH = c.String(),
                        AWAD_LAB = c.String(),
                        AWAD_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_BOHO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        BOHO_ID = c.String(),
                        BOHO_MILE = c.String(),
                        BOHO_ELET = c.Decimal(precision: 18, scale: 2),
                        BOHO_ELEB = c.Decimal(precision: 18, scale: 2),
                        BOHO_DEGR = c.Decimal(precision: 18, scale: 2),
                        BOHO_GRTA = c.Decimal(precision: 18, scale: 2),
                        LOCA_NATE = c.Decimal(precision: 18, scale: 2),
                        LOCA_NATN = c.Decimal(precision: 18, scale: 2),
                        LOCA_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_Borehole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OBJECTID = c.String(),
                        Name = c.String(),
                        FullName = c.String(),
                        Description = c.String(),
                        StratumSection = c.Int(),
                        SectionSequence = c.Int(),
                        BoreholeType = c.String(),
                        TopElevation = c.Double(nullable: false),
                        BoreholeLength = c.Double(nullable: false),
                        Mileage = c.String(),
                        Xcoordinate = c.Double(),
                        Ycoordinate = c.Double(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_BoreholeStrata",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OBJECTID = c.String(),
                        StratumSequenceInBorehole = c.Int(),
                        StratumSectionID = c.Int(),
                        SectionSequenceBorhole = c.Int(),
                        SectionSequenceStrata = c.String(),
                        ElevationOfStratumBottom = c.Double(nullable: false),
                        BoreholeID = c.Int(),
                        StratumID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_CDEM",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        CDEM_UNIT = c.String(),
                        CDEM_NAME = c.String(),
                        CDEM_UP = c.Decimal(precision: 18, scale: 2),
                        CDEM_DOWN = c.Decimal(precision: 18, scale: 2),
                        CDEM_LEFT = c.Decimal(precision: 18, scale: 2),
                        CDEM_RIGH = c.Decimal(precision: 18, scale: 2),
                        CDEM_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_CONT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        CONT_ID = c.Int(),
                        CONT_ELEV = c.Int(),
                        CONT_MEMO = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_CORE",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        CORE_TOP = c.Decimal(precision: 18, scale: 2),
                        CORE_BASE = c.Decimal(precision: 18, scale: 2),
                        CORE_PREC = c.Decimal(precision: 18, scale: 2),
                        CORE_SREC = c.Decimal(precision: 18, scale: 2),
                        CORE_RQD = c.Decimal(precision: 18, scale: 2),
                        CORE_DIAM = c.Decimal(precision: 18, scale: 2),
                        CORE_DURN = c.DateTime(),
                        CORE_DESC = c.String(),
                        CORE_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_DISR",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        AWAD_WTAB = c.Decimal(precision: 18, scale: 2),
                        AWAD_REM = c.String(),
                        AWAD_METH = c.String(),
                        AWAD_LAB = c.String(),
                        AWAD_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_DMTG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        DMTG_TESN = c.String(),
                        DMTG_DATE = c.DateTime(),
                        DMTG_REM = c.String(),
                        DMTG_WAT = c.Decimal(precision: 18, scale: 2),
                        DMTG_GWD = c.String(),
                        DMTG_CONT = c.String(),
                        DMTG_METH = c.String(),
                        DMTG_CREW = c.String(),
                        DMTG_TYPE = c.String(),
                        DMTG_COT = c.String(),
                        DMTG_TDR = c.String(),
                        DMTG_BCVA = c.Decimal(precision: 18, scale: 2),
                        DMTG_BCVB = c.Decimal(precision: 18, scale: 2),
                        DMTG_CFZM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_DMTP",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        DMTG_TESN = c.String(),
                        DMTT_DPTH = c.Decimal(precision: 18, scale: 2),
                        DMTP_REF = c.String(),
                        DMTP_DMID = c.Decimal(precision: 18, scale: 2),
                        DMTP_DKD = c.Decimal(precision: 18, scale: 2),
                        DMTP_DED = c.Decimal(precision: 18, scale: 2),
                        DMTP_DSD = c.String(),
                        DMTP_DQD = c.Decimal(precision: 18, scale: 2),
                        DMTP_DKO = c.Decimal(precision: 18, scale: 2),
                        DMTP_DOCR = c.Decimal(precision: 18, scale: 2),
                        DMTP_DPHI = c.Decimal(precision: 18, scale: 2),
                        DMTP_DVDM = c.Decimal(precision: 18, scale: 2),
                        DMTP_DSU = c.Decimal(precision: 18, scale: 2),
                        DMTP_DGO = c.Decimal(precision: 18, scale: 2),
                        DMTP_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_DMTT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        DMTG_TESN = c.String(),
                        DMTT_DPTH = c.Decimal(precision: 18, scale: 2),
                        DMTT_MTH = c.Decimal(precision: 18, scale: 2),
                        DMTT_PTA = c.Decimal(precision: 18, scale: 2),
                        DMTT_PTB = c.Decimal(precision: 18, scale: 2),
                        DMTT_PTC = c.Decimal(precision: 18, scale: 2),
                        DMTT_APTA = c.Decimal(precision: 18, scale: 2),
                        DMTT_APTB = c.Decimal(precision: 18, scale: 2),
                        DMTT_APTC = c.Decimal(precision: 18, scale: 2),
                        DMTT_SWV = c.Decimal(precision: 18, scale: 2),
                        DMTT_EGAM = c.Decimal(precision: 18, scale: 2),
                        DMTT_ETVS = c.Decimal(precision: 18, scale: 2),
                        DMTT_ISPP = c.Decimal(precision: 18, scale: 2),
                        DMTT_EEFS = c.Decimal(precision: 18, scale: 2),
                        DMTT_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_DPRD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DPRD_ID = c.String(),
                        DPRG_TESN = c.String(),
                        DPRD_MAHN = c.Decimal(precision: 18, scale: 2),
                        DPRD_CORF = c.Decimal(precision: 18, scale: 2),
                        DPRD_MHMN = c.Decimal(precision: 18, scale: 2),
                        DPRD_DENS = c.String(),
                        DPRD_INFA = c.Decimal(precision: 18, scale: 2),
                        DPRD_BEAR = c.Decimal(precision: 18, scale: 2),
                        DPRD_MODF = c.Decimal(precision: 18, scale: 2),
                        DPRD_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_DPRG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DPRG_ID = c.String(),
                        DPRG_TESN = c.String(),
                        DPRG_NUMB = c.String(),
                        DPRG_LOCA = c.String(),
                        DPRG_STRA = c.String(),
                        DPRG_DESC = c.String(),
                        DPRG_TOP = c.Decimal(precision: 18, scale: 2),
                        DPRG_BASE = c.Decimal(precision: 18, scale: 2),
                        DPRG_LEGH = c.Decimal(precision: 18, scale: 2),
                        DPRG_WATER = c.String(),
                        DPRG_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_EXPA",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        AWAD_WTAB = c.Decimal(precision: 18, scale: 2),
                        AWAD_REM = c.String(),
                        AWAD_METH = c.String(),
                        AWAD_LAB = c.String(),
                        AWAD_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_FDSD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        FDSD_TESN = c.String(),
                        FDSD_BDEN = c.Decimal(precision: 18, scale: 2),
                        FDSD_DDEN = c.Decimal(precision: 18, scale: 2),
                        FDSD_NORM = c.Decimal(precision: 18, scale: 2),
                        FDSD_DISA = c.Decimal(precision: 18, scale: 2),
                        FDSD_DISR = c.Decimal(precision: 18, scale: 2),
                        FDSD_RES = c.Decimal(precision: 18, scale: 2),
                        FDSD_RDIS = c.Decimal(precision: 18, scale: 2),
                        FDSD_ADIS = c.Decimal(precision: 18, scale: 2),
                        FDSD_PDEN = c.String(),
                        FDSD_IVR = c.Decimal(precision: 18, scale: 2),
                        FDSD_MCI = c.Decimal(precision: 18, scale: 2),
                        FDSD_MCF = c.Decimal(precision: 18, scale: 2),
                        FDSD_DIA1 = c.Decimal(precision: 18, scale: 2),
                        FDSD_DIA2 = c.Decimal(precision: 18, scale: 2),
                        FDSD_HGT = c.Decimal(precision: 18, scale: 2),
                        FDSD_CRIT = c.String(),
                        FDSD_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_FDST",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        FDST_COND = c.String(),
                        FDST_RCOH = c.Decimal(precision: 18, scale: 2),
                        FDST_RPHI = c.Decimal(precision: 18, scale: 2),
                        FDST_REM = c.String(),
                        FDST_METH = c.String(),
                        FDST_LAB = c.String(),
                        FDST_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_FREZ",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        FREZ_WTAB = c.Decimal(precision: 18, scale: 2),
                        FREZ_REM = c.String(),
                        FREZ_METH = c.String(),
                        FREZ_LAB = c.String(),
                        FREZ_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_GEOE",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GEOE_ID = c.String(),
                        GEOE_SCHAI = c.String(),
                        GEOE_ECHAI = c.String(),
                        GEOE_LGTH = c.Decimal(precision: 18, scale: 2),
                        GEOE_METH = c.String(),
                        GEOE_RESU = c.String(),
                        GEOE_STAR = c.String(),
                        GEOE_ENDD = c.String(),
                        GEOE_CONT = c.String(),
                        GEOE_CREW = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_GEOS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GEOS_ID = c.String(),
                        GEOS_NAME = c.String(),
                        GEOS_TYPE = c.String(),
                        GEOS_GEOM = c.String(),
                        GEOS_COOR1 = c.String(),
                        GEOS_COOR2 = c.String(),
                        GEOS_ATTD = c.String(),
                        GEOS_LGTH = c.Decimal(precision: 18, scale: 2),
                        GEOS_RELA = c.String(),
                        GEOS_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_GEPR",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        LOCA_NATE = c.Decimal(precision: 18, scale: 2),
                        LOCA_NATN = c.Decimal(precision: 18, scale: 2),
                        GEPR_PREC = c.Decimal(precision: 18, scale: 2),
                        GEPR_SREC = c.Decimal(precision: 18, scale: 2),
                        GEPR_RQD = c.Decimal(precision: 18, scale: 2),
                        GEPR_DIAM = c.Decimal(precision: 18, scale: 2),
                        GEPR_DURN = c.DateTime(),
                        GEPR_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_GMPG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        GMPG_ID = c.String(),
                        RSVR_GEOM = c.String(),
                        RSVR_COOR1 = c.String(),
                        RSVR_COOR2 = c.String(),
                        GMPG_DSRG = c.String(),
                        GMPG_FMRS = c.String(),
                        GMPG_TYPE = c.String(),
                        GMPG_CHAR = c.String(),
                        GMPG_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_HDPH",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HDPH_TOP = c.Decimal(precision: 18, scale: 2),
                        HDPH_STAR = c.String(),
                        HDPH_ENDD = c.String(),
                        HDPH_CORX = c.Decimal(precision: 18, scale: 2),
                        HDPH_CORY = c.Decimal(precision: 18, scale: 2),
                        HDPH_CHAI = c.String(),
                        HDPH_WATER = c.Decimal(precision: 18, scale: 2),
                        HDPH_REM = c.String(),
                        HDPH_ORNT = c.Decimal(precision: 18, scale: 2),
                        HDPH_INCL = c.Decimal(precision: 18, scale: 2),
                        HDPH_DIAM = c.String(),
                        HDPH_CONT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_HFTD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        HFTG_TNUM = c.String(),
                        HFTD_DPTH = c.Decimal(precision: 18, scale: 2),
                        HFTD_DIP = c.String(),
                        HFTD_DIR = c.String(),
                        HFTD_TIME = c.String(),
                        HFTD_WELLP = c.String(),
                        HFTD_INRATE = c.String(),
                        HFTD_RERATE = c.String(),
                        HFTD_BULK = c.String(),
                        HFTD_TEMP = c.String(),
                        HFTD_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_HFTG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        HFTG_TNUM = c.String(),
                        HFTG_DATE = c.String(),
                        HFTG_REM = c.String(),
                        HFTG_WAT = c.Decimal(precision: 18, scale: 2),
                        HFTG_GWD = c.String(),
                        HFTG_SET = c.String(),
                        HFTG_CONT = c.String(),
                        HFTG_METH = c.String(),
                        HFTG_CREW = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_HFTP",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        HFTG_TNUM = c.String(),
                        HFTD_DPTH = c.Decimal(precision: 18, scale: 2),
                        HFTP_INUM = c.String(),
                        HFTP_PB = c.String(),
                        HFTP_PR = c.String(),
                        HFTP_ISIP = c.String(),
                        HFTP_PC = c.String(),
                        HFTP_SHMIN = c.String(),
                        HFTP_SHMAX = c.String(),
                        HFTP_SV = c.String(),
                        HFTP_PT = c.String(),
                        HFTP_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_HFTR",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        PROJ_TSSN = c.String(),
                        HTFR_WCPR = c.Decimal(precision: 18, scale: 2),
                        HTFR_PRST = c.String(),
                        HTFR_METI = c.DateTime(),
                        HTFR_TIIN = c.Decimal(precision: 18, scale: 2),
                        HTFR_PRRE = c.Decimal(precision: 18, scale: 2),
                        HTFR_PRLO = c.Decimal(precision: 18, scale: 2),
                        HTFR_TOPR = c.Decimal(precision: 18, scale: 2),
                        HTFR_INWM = c.Decimal(precision: 18, scale: 2),
                        HTFR_INFL = c.Decimal(precision: 18, scale: 2),
                        HTRF_MEMO = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_HYCH",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        HYCH_LOCA = c.String(),
                        HYCH_PH = c.Decimal(precision: 18, scale: 2),
                        HYCH_HARD = c.Decimal(precision: 18, scale: 2),
                        HYCH_K = c.Decimal(precision: 18, scale: 2),
                        HYCH_NA = c.Decimal(precision: 18, scale: 2),
                        HYCH_GA = c.Decimal(precision: 18, scale: 2),
                        HYCH_MG = c.Decimal(precision: 18, scale: 2),
                        HYCH_HCO3 = c.Decimal(precision: 18, scale: 2),
                        HYCH_SO4 = c.String(),
                        HYCH_CL = c.Decimal(precision: 18, scale: 2),
                        HYCH_CHTY = c.String(),
                        HYCH_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_HYUN",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        HYUN_ID = c.String(),
                        HYUN_STCO = c.String(),
                        HYUN_STDE = c.String(),
                        HYUN_STLI = c.String(),
                        HYUN_GRTY = c.String(),
                        HYUN_FLOW = c.String(),
                        HYUN_UNRM = c.String(),
                        HYUN_WAAB = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_IRSI",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AERP_ID = c.String(),
                        IRSI_ID = c.String(),
                        IRSI_MEAN = c.String(),
                        IRSI_PTYPE = c.String(),
                        IRSI_GTYPE = c.String(),
                        IRSI_SIGN = c.String(),
                        IRSI_OIPM = c.String(),
                        IRSI_DIPM = c.String(),
                        IRSI_STAFF = c.String(),
                        IRSI_CONT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_PLTG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        PLTG_DPTH = c.Decimal(precision: 18, scale: 2),
                        PLTG_TESN = c.String(),
                        PLTG_CYC = c.String(),
                        PLTG_PDIA = c.Decimal(precision: 18, scale: 2),
                        PLTG_SEAT = c.Decimal(precision: 18, scale: 2),
                        PLTG_FA0 = c.Decimal(precision: 18, scale: 2),
                        PLTG_FA1 = c.Decimal(precision: 18, scale: 2),
                        PLTG_FA2 = c.Decimal(precision: 18, scale: 2),
                        PLTG_SMOD = c.Decimal(precision: 18, scale: 2),
                        PLTG_EV2 = c.Decimal(precision: 18, scale: 2),
                        PLTG_MOSR = c.Decimal(precision: 18, scale: 2),
                        PLTG_EMOD = c.Decimal(precision: 18, scale: 2),
                        PLTG_DATE = c.DateTime(),
                        PLTG_STAB = c.Decimal(precision: 18, scale: 2),
                        PLTG_STYP = c.String(),
                        PLTG_REM = c.String(),
                        PLTG_ENV = c.String(),
                        PLTG_METH = c.String(),
                        PLTG_CONT = c.String(),
                        PLTG_CRED = c.String(),
                        TEST_STAT = c.String(),
                        GEOL_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_PLTT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        PLTG_DPTH = c.Decimal(precision: 18, scale: 2),
                        PLTG_TESN = c.String(),
                        PLTG_CYC = c.String(),
                        PLTT_STG = c.String(),
                        PLTT_TIME = c.Decimal(precision: 18, scale: 2),
                        PLTT_LOAD = c.Decimal(precision: 18, scale: 2),
                        PLTT_SET1 = c.Decimal(precision: 18, scale: 2),
                        PLTT_SET2 = c.Decimal(precision: 18, scale: 2),
                        PLTT_SET3 = c.Decimal(precision: 18, scale: 2),
                        PLTT_SET4 = c.Decimal(precision: 18, scale: 2),
                        PLTT_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_PMTD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        PMTG_DPTH = c.Decimal(precision: 18, scale: 2),
                        PMTG_TESN = c.String(),
                        PMTD_SEQ = c.Decimal(precision: 18, scale: 2),
                        PMTD_ARM1 = c.Decimal(precision: 18, scale: 2),
                        PMTD_ARM2 = c.Decimal(precision: 18, scale: 2),
                        PMTD_ARM3 = c.Decimal(precision: 18, scale: 2),
                        PMTD_TPC = c.Decimal(precision: 18, scale: 2),
                        PMTD_PPA = c.Decimal(precision: 18, scale: 2),
                        PMTD_PPB = c.Decimal(precision: 18, scale: 2),
                        PMTD_VOL = c.Decimal(precision: 18, scale: 2),
                        PMTD_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_PMTG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        PMTG_DPTH = c.Decimal(precision: 18, scale: 2),
                        PMTG_TESN = c.String(),
                        PMTG_DATE = c.DateTime(),
                        PMTG_WAT = c.Decimal(precision: 18, scale: 2),
                        PMTG_CONT = c.String(),
                        PMTG_CREW = c.String(),
                        PMTG_REF = c.String(),
                        PMTG_TYPE = c.String(),
                        PMTG_DIAM = c.Decimal(precision: 18, scale: 2),
                        PMTG_HO = c.Decimal(precision: 18, scale: 2),
                        PMTG_GI = c.Decimal(precision: 18, scale: 2),
                        PMTG_CU = c.Decimal(precision: 18, scale: 2),
                        PMTG_PL = c.String(),
                        PMTG_AF = c.Decimal(precision: 18, scale: 2),
                        PMTG_AD = c.Decimal(precision: 18, scale: 2),
                        PMTG_AFCV = c.Decimal(precision: 18, scale: 2),
                        PMTG_METH = c.String(),
                        TEST_STAT = c.String(),
                        PMTG_ENV = c.String(),
                        PMTG_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_PROJ",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        EPRO_ID = c.String(),
                        EPRO_TYPE = c.String(),
                        EPRO_SERV = c.String(),
                        EPRO_DSRG = c.String(),
                        EPRO_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_PUTR",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        PUBR_TIME = c.DateTime(),
                        PUBR_ACTI = c.Decimal(precision: 18, scale: 2),
                        PUBR_WATA = c.Decimal(precision: 18, scale: 2),
                        PUBR_DRDO = c.Decimal(precision: 18, scale: 2),
                        PUBR_GUSH = c.Decimal(precision: 18, scale: 2),
                        PUBR_OBPE = c.String(),
                        PUBR_MEMO = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RDEN",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        RDEN_MC = c.Decimal(precision: 18, scale: 2),
                        RDEN_SMC = c.Decimal(precision: 18, scale: 2),
                        RDEN_BDEN = c.Decimal(precision: 18, scale: 2),
                        RDEN_DDEN = c.Decimal(precision: 18, scale: 2),
                        RDEN_PORO = c.Decimal(precision: 18, scale: 2),
                        RDEN_PDEN = c.Decimal(precision: 18, scale: 2),
                        RDEN_TEMP = c.Decimal(precision: 18, scale: 2),
                        RDEN_REM = c.String(),
                        RDEN_METH = c.String(),
                        RDEN_LAB = c.String(),
                        RDEN_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RELD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        RELD_DMAX = c.Decimal(precision: 18, scale: 2),
                        RELD_375 = c.Decimal(precision: 18, scale: 2),
                        RELD_063 = c.Decimal(precision: 18, scale: 2),
                        RELD_020 = c.Decimal(precision: 18, scale: 2),
                        RELD_DMIN = c.Decimal(precision: 18, scale: 2),
                        RELD_REM = c.String(),
                        RELD_METH = c.String(),
                        RELD_LAB = c.String(),
                        RELD_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RIVR",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        FID = c.Int(nullable: false),
                        RIVR_NAME = c.String(),
                        RIVR_LOCA = c.String(),
                        RIVR_SYS = c.String(),
                        RIVR_CFAR = c.String(),
                        RIVR_DRYF = c.String(),
                        RIVR_RAIF = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RMAR",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        RMAR_DATE = c.DateTime(),
                        RMAR_NAME = c.String(),
                        RMAR_DESC = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RMCT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        RMCT_NAME = c.String(),
                        RMCT_CONT = c.Decimal(precision: 18, scale: 2),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RSHD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        RSHD_TESN = c.String(),
                        RSHD_BDEN = c.Decimal(precision: 18, scale: 2),
                        RSHD_DDEN = c.Decimal(precision: 18, scale: 2),
                        RSHD_NORM = c.Decimal(precision: 18, scale: 2),
                        RSHD_DISA = c.Decimal(precision: 18, scale: 2),
                        RSHD_DISR = c.Decimal(precision: 18, scale: 2),
                        RSHD_RES = c.Decimal(precision: 18, scale: 2),
                        RSHD_RDIS = c.Decimal(precision: 18, scale: 2),
                        RSHD_ADIS = c.Decimal(precision: 18, scale: 2),
                        RSHD_PDEN = c.String(),
                        RSHD_IVR = c.Decimal(precision: 18, scale: 2),
                        RSHD_MCI = c.Decimal(precision: 18, scale: 2),
                        RSHD_MCF = c.Decimal(precision: 18, scale: 2),
                        RSHD_DIA1 = c.Decimal(precision: 18, scale: 2),
                        RSHD_DIA2 = c.Decimal(precision: 18, scale: 2),
                        RSHD_HGT = c.Decimal(precision: 18, scale: 2),
                        RSHD_CRIT = c.String(),
                        RSHD_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RSHG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        RSHG_COND = c.String(),
                        RSHG_RCOH = c.Decimal(precision: 18, scale: 2),
                        RSHG_RPHI = c.Decimal(precision: 18, scale: 2),
                        RSHG_REM = c.String(),
                        RSHG_METH = c.String(),
                        RSHG_LAB = c.String(),
                        RSHG_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RSVR",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        RSVR_RWTT = c.String(),
                        RSVR_ENCH = c.String(),
                        RSVR_NAME = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RTEN",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        RTEN_SDIA = c.Decimal(precision: 18, scale: 2),
                        RTEN_LEN = c.Decimal(precision: 18, scale: 2),
                        RTEN_MC = c.Decimal(precision: 18, scale: 2),
                        RTEN_COND = c.String(),
                        RTEN_DURN = c.DateTime(),
                        RTEN_STRA = c.Decimal(precision: 18, scale: 2),
                        RTEN_TENS = c.Decimal(precision: 18, scale: 2),
                        RTEN_MODE = c.String(),
                        RTEN_MACH = c.String(),
                        RTEN_REM = c.String(),
                        RTEN_METH = c.String(),
                        RTEN_LAB = c.String(),
                        RTEN_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_RUCS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        RUCS_SDIA = c.Decimal(precision: 18, scale: 2),
                        RUCS_LEN = c.Decimal(precision: 18, scale: 2),
                        RUCS_MC = c.Decimal(precision: 18, scale: 2),
                        RUCS_COND = c.String(),
                        RUCS_DURN = c.DateTime(),
                        RUCS_STRA = c.Decimal(precision: 18, scale: 2),
                        RUCS_UCS = c.Decimal(precision: 18, scale: 2),
                        RUCS_MODE = c.String(),
                        RUCS_E = c.Decimal(precision: 18, scale: 2),
                        RUCS_MU = c.Decimal(precision: 18, scale: 2),
                        RUCS_ESTR = c.String(),
                        RUCS_ETYP = c.String(),
                        RUCS_MACH = c.String(),
                        RUCS_REM = c.String(),
                        RUCS_METH = c.String(),
                        RUCS_LAB = c.String(),
                        RUCS_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_SCPD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SCPG_TESN = c.String(),
                        SCPD_DPTH = c.Decimal(precision: 18, scale: 2),
                        SCPD_RES = c.Decimal(precision: 18, scale: 2),
                        SCPD_FRES = c.Decimal(precision: 18, scale: 2),
                        SCPD_PWP1 = c.Decimal(precision: 18, scale: 2),
                        SCPD_PWP2 = c.Decimal(precision: 18, scale: 2),
                        SCPD_PWP3 = c.Decimal(precision: 18, scale: 2),
                        SCPD_CON = c.Decimal(precision: 18, scale: 2),
                        SCPD_TEMP = c.Decimal(precision: 18, scale: 2),
                        SCPD_PH = c.Decimal(precision: 18, scale: 2),
                        SCPD_SLP1 = c.Decimal(precision: 18, scale: 2),
                        SCPD_SLP2 = c.Decimal(precision: 18, scale: 2),
                        SCPD_REDX = c.Decimal(precision: 18, scale: 2),
                        SCPD_MAGT = c.Decimal(precision: 18, scale: 2),
                        SCPD_MAGX = c.Decimal(precision: 18, scale: 2),
                        SCPD_MAGY = c.Decimal(precision: 18, scale: 2),
                        SCPD_MAGZ = c.Decimal(precision: 18, scale: 2),
                        SCPD_SMP = c.Decimal(precision: 18, scale: 2),
                        SCPD_NGAM = c.Decimal(precision: 18, scale: 2),
                        SCPD_REM = c.String(),
                        SCPD_FRR = c.Decimal(precision: 18, scale: 2),
                        SCPD_QT = c.Decimal(precision: 18, scale: 2),
                        SCPD_FT = c.Decimal(precision: 18, scale: 2),
                        SCPD_NQT = c.Decimal(precision: 18, scale: 2),
                        SCPD_NFR = c.Decimal(precision: 18, scale: 2),
                        FILE_FSET = c.String(),
                        SCPD_QE = c.Decimal(precision: 18, scale: 2),
                        SCPD_BDEN = c.Decimal(precision: 18, scale: 2),
                        SCPD_CPO = c.Decimal(precision: 18, scale: 2),
                        SCPD_CPOD = c.Decimal(precision: 18, scale: 2),
                        SCPD_QNET = c.Decimal(precision: 18, scale: 2),
                        SCPD_FRRC = c.Decimal(precision: 18, scale: 2),
                        SCPD_EXPP = c.Decimal(precision: 18, scale: 2),
                        SCPD_BQ = c.Decimal(precision: 18, scale: 2),
                        SCPD_ISPP = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_SCPG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SCPG_TESN = c.String(),
                        SCPG_TYPE = c.String(),
                        SCPG_REF = c.String(),
                        SCPG_CSA = c.Decimal(precision: 18, scale: 2),
                        SCPG_RATE = c.Decimal(precision: 18, scale: 2),
                        SCPG_FILT = c.String(),
                        SCPG_FRIC = c.String(),
                        SCPG_WAT = c.Decimal(precision: 18, scale: 2),
                        SCPG_WATA = c.String(),
                        SCPG_REM = c.String(),
                        SCPG_ENV = c.String(),
                        SCPG_CONT = c.String(),
                        SCPG_METH = c.String(),
                        SCPG_CRED = c.String(),
                        SCPG_CAR = c.Decimal(precision: 18, scale: 2),
                        SCPG_SLAR = c.Decimal(precision: 18, scale: 2),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_SDEM",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        SDEM_UNIT = c.String(),
                        SDEM_UP = c.Decimal(precision: 18, scale: 2),
                        SDEM_DOWN = c.Decimal(precision: 18, scale: 2),
                        SDEM_LEFT = c.Decimal(precision: 18, scale: 2),
                        SDEM_RIGH = c.Decimal(precision: 18, scale: 2),
                        SDEM_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_SDEN",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        SDEN_TYPE = c.String(),
                        SDEN_COND = c.String(),
                        SDEN_SMTY = c.String(),
                        SDEN_MC = c.Decimal(precision: 18, scale: 2),
                        SDEN_BDEN = c.Decimal(precision: 18, scale: 2),
                        SDEN_DDEN = c.Decimal(precision: 18, scale: 2),
                        SDEN_REM = c.String(),
                        SDEN_METH = c.String(),
                        SDEN_LAB = c.String(),
                        SDEN_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_SPEC",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SPEC_ID = c.String(),
                        SPEC_TYPE = c.String(),
                        SPEC_DSRG = c.String(),
                        SPEC_AREA = c.String(),
                        SPEC_EGP = c.String(),
                        SPEC_REM = c.String(),
                        SPEC_DISA = c.String(),
                        SPEC_LAWD = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_SPPO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        SPPO_NAME = c.String(),
                        SPPO_NMYN = c.String(),
                        SPPO_RWTT = c.String(),
                        SPPO_GRTY = c.String(),
                        SPPO_TYPE = c.String(),
                        SPPO_CHAR = c.String(),
                        SPPO_RSFL = c.String(),
                        SPPO_DSFL = c.String(),
                        SPPO_WISC = c.String(),
                        SPPO_WSRA = c.String(),
                        SPPO_INTC = c.String(),
                        LOCA_NATE = c.String(),
                        LOCA_NATN = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_SPTR",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SPTR_TOP = c.Decimal(precision: 18, scale: 2),
                        SPTR_SEAT = c.Decimal(precision: 18, scale: 2),
                        SPTR_MAIN = c.Decimal(precision: 18, scale: 2),
                        SPTR_NPEN = c.Decimal(precision: 18, scale: 2),
                        SPTR_NVAL = c.Decimal(precision: 18, scale: 2),
                        SPTR_REP = c.String(),
                        SPTR_CAS = c.Decimal(precision: 18, scale: 2),
                        SPTR_WAT = c.String(),
                        SPTR_TYPE = c.String(),
                        SPTR_HAM = c.String(),
                        SPTR_ERAT = c.Decimal(precision: 18, scale: 2),
                        SPTR_SWP = c.Decimal(precision: 18, scale: 2),
                        SPTR_INC1 = c.Decimal(precision: 18, scale: 2),
                        SPTR_INC2 = c.Decimal(precision: 18, scale: 2),
                        SPTR_INC3 = c.Decimal(precision: 18, scale: 2),
                        SPTR_INC4 = c.Decimal(precision: 18, scale: 2),
                        SPTR_INC5 = c.Decimal(precision: 18, scale: 2),
                        SPTR_INC6 = c.Decimal(precision: 18, scale: 2),
                        SPTR_PEN1 = c.Decimal(precision: 18, scale: 2),
                        SPTR_PEN2 = c.Decimal(precision: 18, scale: 2),
                        SPTR_PEN3 = c.Decimal(precision: 18, scale: 2),
                        SPTR_PEN4 = c.Decimal(precision: 18, scale: 2),
                        SPTR_PEN5 = c.Decimal(precision: 18, scale: 2),
                        SPTR_PEN6 = c.Decimal(precision: 18, scale: 2),
                        SPTR_ROCK = c.String(),
                        SPTR_REM = c.String(),
                        SPTR_ENV = c.String(),
                        SPTR_METH = c.String(),
                        SPTR_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_SSAT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        SSAT_UP = c.Decimal(precision: 18, scale: 2),
                        SSAT_DOWN = c.Decimal(precision: 18, scale: 2),
                        SSAT_LEFT = c.Decimal(precision: 18, scale: 2),
                        SSAT_RIGH = c.Decimal(precision: 18, scale: 2),
                        SSAT_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_STRA",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        STRA_ID = c.String(),
                        STRA_NAME = c.String(),
                        STRA_DESC = c.String(),
                        STRA_GEO1 = c.String(),
                        STRA_GEO2 = c.String(),
                        STRA_STAT = c.String(),
                        STRA_WEA = c.String(),
                        STRA_BTBC = c.String(),
                        STRA_DSRG = c.String(),
                        STRA_DIP = c.Decimal(precision: 18, scale: 2),
                        STRA_DIR = c.Decimal(precision: 18, scale: 2),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_TDEM",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        TDEM_UNIT = c.String(),
                        TDEM_UP = c.Decimal(precision: 18, scale: 2),
                        TDEM_DOWN = c.Decimal(precision: 18, scale: 2),
                        TDEM_LEFT = c.Decimal(precision: 18, scale: 2),
                        TDEM_RIGH = c.Decimal(precision: 18, scale: 2),
                        TDEM_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_TREG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        TREG_TYPE = c.String(),
                        TREG_COND = c.String(),
                        TREG_COH = c.String(),
                        TREG_PHI = c.String(),
                        TREG_FCR = c.String(),
                        TREG_REM = c.String(),
                        TREG_METH = c.String(),
                        TREG_LAB = c.String(),
                        TREG_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_TRET",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        TRET_TESN = c.String(),
                        TRET_SDIA = c.Decimal(precision: 18, scale: 2),
                        TRET_SLEN = c.Decimal(precision: 18, scale: 2),
                        TRET_IMC = c.Decimal(precision: 18, scale: 2),
                        TRET_FMC = c.Decimal(precision: 18, scale: 2),
                        TRET_BDEN = c.Decimal(precision: 18, scale: 2),
                        TRET_DDEN = c.Decimal(precision: 18, scale: 2),
                        TRET_SAT = c.String(),
                        TRET_CONS = c.String(),
                        TRET_CONP = c.Decimal(precision: 18, scale: 2),
                        TRET_CELL = c.Decimal(precision: 18, scale: 2),
                        TRET_PWPI = c.Decimal(precision: 18, scale: 2),
                        TRET_STRR = c.Decimal(precision: 18, scale: 2),
                        TRET_STRN = c.Decimal(precision: 18, scale: 2),
                        TRET_DEVF = c.Decimal(precision: 18, scale: 2),
                        TRET_PWPF = c.Decimal(precision: 18, scale: 2),
                        TRET_STV = c.Decimal(precision: 18, scale: 2),
                        TRET_MODE = c.String(),
                        TRET_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_TRIG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        SPEC_DESC = c.String(),
                        SPEC_PREP = c.String(),
                        TRIG_TYPE = c.String(),
                        TRIG_COND = c.String(),
                        TRIG_REM = c.String(),
                        TRIG_METH = c.String(),
                        TRIG_LAB = c.String(),
                        TRIG_CRED = c.String(),
                        TEST_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_TRIT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        SAMP_TOP = c.Decimal(precision: 18, scale: 2),
                        SAMP_REF = c.String(),
                        SAMP_TYPE = c.String(),
                        SAMP_ID = c.String(),
                        SPEC_REF = c.String(),
                        SPEC_DPTH = c.Decimal(precision: 18, scale: 2),
                        TRIT_TESN = c.String(),
                        TRIT_SDIA = c.Decimal(precision: 18, scale: 2),
                        TRIT_SLEN = c.Decimal(precision: 18, scale: 2),
                        TRIT_IMC = c.Decimal(precision: 18, scale: 2),
                        TRIT_FMC = c.Decimal(precision: 18, scale: 2),
                        TRIT_CELL = c.Decimal(precision: 18, scale: 2),
                        TRIT_DEVF = c.Decimal(precision: 18, scale: 2),
                        TRIT_BDEN = c.Decimal(precision: 18, scale: 2),
                        TRIT_DDEN = c.Decimal(precision: 18, scale: 2),
                        TRIT_STRN = c.Decimal(precision: 18, scale: 2),
                        TRIT_CU = c.Decimal(precision: 18, scale: 2),
                        TRIT_MODE = c.String(),
                        TRIT_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_TSAT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        TSAT_UP = c.Decimal(precision: 18, scale: 2),
                        TSAT_DOWN = c.Decimal(precision: 18, scale: 2),
                        TSAT_LEFT = c.Decimal(precision: 18, scale: 2),
                        TSAT_RIGH = c.Decimal(precision: 18, scale: 2),
                        TSAT_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_VANE",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        VANE_DPTH = c.Decimal(precision: 18, scale: 2),
                        VANE_TESN = c.String(),
                        VANE_TYPE = c.String(),
                        VANE_VANE = c.String(),
                        VANE_IVAR = c.String(),
                        VANE_DATE = c.DateTime(),
                        VANE_REM = c.String(),
                        VANE_ENV = c.String(),
                        VANE_METH = c.String(),
                        VANE_CONT = c.String(),
                        VANE_CRED = c.String(),
                        TEST_STAT = c.String(),
                        GEOL_STAT = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_WADD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LOCA_ID = c.String(),
                        WADD_TOP = c.Decimal(precision: 18, scale: 2),
                        WADD_BASE = c.Decimal(precision: 18, scale: 2),
                        WADD_VOLM = c.Decimal(precision: 18, scale: 2),
                        WADD_METH = c.Decimal(precision: 18, scale: 2),
                        WADD_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_WASH",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        WASH_ID = c.Int(),
                        WASH_HIGH = c.String(),
                        WASH_MEMO = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_WEAT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        WEAT_ID = c.String(),
                        WEAT_GEOM = c.String(),
                        WEAT_COOR1 = c.String(),
                        WEAT_COOR2 = c.String(),
                        WEAT_TYPE = c.String(),
                        WEAT_DESC = c.String(),
                        WEAT_MAP = c.String(),
                        WEAT_MAT = c.Decimal(precision: 18, scale: 2),
                        WEAT_RAIN = c.String(),
                        WEAT_REM = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_WITR",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        WITR_FREQ = c.Int(),
                        WITR_TTTP = c.DateTime(),
                        WITR_TECP = c.DateTime(),
                        WITR_CPTI = c.Decimal(precision: 18, scale: 2),
                        WITR_WAAD = c.Decimal(precision: 18, scale: 2),
                        WITR_MWSE = c.Decimal(precision: 18, scale: 2),
                        WITR_OBPE = c.String(),
                        WITR_MEMO = c.String(),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Geology_WSPA",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJ_ID = c.String(),
                        WSPA_NAME = c.String(),
                        WSPA_CLAS = c.String(),
                        WSPA_AREA = c.Decimal(precision: 18, scale: 2),
                        FILE_FSET = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Geology_WSPA");
            DropTable("dbo.Geology_WITR");
            DropTable("dbo.Geology_WEAT");
            DropTable("dbo.Geology_WASH");
            DropTable("dbo.Geology_WADD");
            DropTable("dbo.Geology_VANE");
            DropTable("dbo.Geology_TSAT");
            DropTable("dbo.Geology_TRIT");
            DropTable("dbo.Geology_TRIG");
            DropTable("dbo.Geology_TRET");
            DropTable("dbo.Geology_TREG");
            DropTable("dbo.Geology_TDEM");
            DropTable("dbo.Geology_STRA");
            DropTable("dbo.Geology_SSAT");
            DropTable("dbo.Geology_SPTR");
            DropTable("dbo.Geology_SPPO");
            DropTable("dbo.Geology_SPEC");
            DropTable("dbo.Geology_SDEN");
            DropTable("dbo.Geology_SDEM");
            DropTable("dbo.Geology_SCPG");
            DropTable("dbo.Geology_SCPD");
            DropTable("dbo.Geology_RUCS");
            DropTable("dbo.Geology_RTEN");
            DropTable("dbo.Geology_RSVR");
            DropTable("dbo.Geology_RSHG");
            DropTable("dbo.Geology_RSHD");
            DropTable("dbo.Geology_RMCT");
            DropTable("dbo.Geology_RMAR");
            DropTable("dbo.Geology_RIVR");
            DropTable("dbo.Geology_RELD");
            DropTable("dbo.Geology_RDEN");
            DropTable("dbo.Geology_PUTR");
            DropTable("dbo.Geology_PROJ");
            DropTable("dbo.Geology_PMTG");
            DropTable("dbo.Geology_PMTD");
            DropTable("dbo.Geology_PLTT");
            DropTable("dbo.Geology_PLTG");
            DropTable("dbo.Geology_IRSI");
            DropTable("dbo.Geology_HYUN");
            DropTable("dbo.Geology_HYCH");
            DropTable("dbo.Geology_HFTR");
            DropTable("dbo.Geology_HFTP");
            DropTable("dbo.Geology_HFTG");
            DropTable("dbo.Geology_HFTD");
            DropTable("dbo.Geology_HDPH");
            DropTable("dbo.Geology_GMPG");
            DropTable("dbo.Geology_GEPR");
            DropTable("dbo.Geology_GEOS");
            DropTable("dbo.Geology_GEOE");
            DropTable("dbo.Geology_FREZ");
            DropTable("dbo.Geology_FDST");
            DropTable("dbo.Geology_FDSD");
            DropTable("dbo.Geology_EXPA");
            DropTable("dbo.Geology_DPRG");
            DropTable("dbo.Geology_DPRD");
            DropTable("dbo.Geology_DMTT");
            DropTable("dbo.Geology_DMTP");
            DropTable("dbo.Geology_DMTG");
            DropTable("dbo.Geology_DISR");
            DropTable("dbo.Geology_CORE");
            DropTable("dbo.Geology_CONT");
            DropTable("dbo.Geology_CDEM");
            DropTable("dbo.Geology_BoreholeStrata");
            DropTable("dbo.Geology_Borehole");
            DropTable("dbo.Geology_BOHO");
            DropTable("dbo.Geology_AWAD");
            DropTable("dbo.Geology_AGEO");
            DropTable("dbo.Geology_AERP");
        }
    }
}
