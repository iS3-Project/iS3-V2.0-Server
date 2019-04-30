using iS3.Monitoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using iS3.Core;

namespace iS3.MiniServer
{
    [RoutePrefix("api/monitoring")]
    [Authorize(Roles = "Admin")]
    [AllowAnonymous]
    public class MonitoringController:ApiController
    {
        [Route("mongroup")]
        [HttpGet]
        public List<MonGroup> getMonGroupListByObjsID(string project,int objsid, string filter)
        {
            var repo =new RepositoryForServer<MonGroup>(project);
            return repo.RetrieveByObjs(objsid, filter).Result;
        }

        [Route("mongroup")]
        [HttpGet]
        public MonGroup getMonGroupByID(string project, int id)
        {
            var repo = new RepositoryForServer<MonGroup>(project);
            return repo.RetrieveByID(id).Result;
        }
        [Route("monpoint")]
        [HttpGet]
        public List<MonPoint> getMonPointListByObjsID(string project, int objsid, string filter)
        {
            var repo = new RepositoryForServer<MonPoint>(project);
            return repo.RetrieveAll().Result;
            //var repo = new RepositoryForServer<MonPoint>(project);
            //return repo.RetrieveByObjs(objsid, filter).Result;
        }

        [Route("monpoint")]
        [HttpGet]
        public MonPoint getMonPointByID(string project, int id)
        {
            var repo = new RepositoryForServer<MonPoint>(project);
            MonitoringContext monContext = repo.context as MonitoringContext;
            MonPoint mp = monContext.MonPoint.Where(x => x.ID == id).FirstOrDefault();
            if (mp == null) return null;

            mp.monComponentList = new List<MonComponent>();
            List<string> componentNameList = mp.componentNames.Split(',').ToList();
            foreach (string key in componentNameList)
            {
                mp.monComponentList.Add(new MonComponent()
                {
                    componentName = key,
                    readings = monContext.MonReading.Where(x => ((x.monPointName == mp.Name) && (x.component == key))).ToList()
                });
            }
            return mp;
        }
        [Route("monpoint")]
        [HttpGet]
        public List<MonPoint> getMonPointList(string project)
        {
            var repo = new RepositoryForServer<MonPoint>(project);
            return repo.RetrieveAll().Result;
        }
    }
}
