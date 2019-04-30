using iS3.Core;
using iS3.Core.Server;
using iS3.Core.Server.Repository;
using iS3.Geology.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Geology.Server.Repository
{
    public class Borehole_Repo : RepositoryForServer<Borehole>
    {
        GeologyContext db { get { return context as GeologyContext; } }
        public Borehole_Repo(string project):base(project)
        {
           
        }
        /// <summary>
        /// 根据id查询对应的监测组
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <returns></returns>
        public override async Task<Borehole> Retrieve(int id)
        {
            try
            {
                Borehole borehole = db.Borehole.
                    Where(x => x.ID == id).FirstOrDefault();
                borehole.BoreholeStratas = db.BoreholeStrata.
                    Where(x => x.BoreholeID == id).ToList();
                double top = double.Parse(borehole.TopElevation.ToString());
                foreach (BoreholeStrata strata in borehole.BoreholeStratas)
                {
                    strata.Top = top;
                    strata.Base = double.Parse(strata.ElevationOfStratumBottom.ToString());
                    top = strata.Base;
                }
                return borehole;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        /// <summary>
        /// 删除钻孔及其对应的钻孔地层记录，也可以通过调用BoreholeStrata删除单个钻孔地层数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>


        public override async Task<int> Delete(Borehole model)
        {
            var boreholeStata = db.BoreholeStrata.Where(x => x.BoreholeID == model.ID);
            context.Entry(boreholeStata).State = System.Data.Entity.EntityState.Deleted;
            return base.Delete(model).Result;
        }
    }



}