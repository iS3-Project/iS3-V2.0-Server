using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using iS3.Geology.Model;
using iS3.Core;
namespace iS3.MiniServer
{
    [RoutePrefix("api/Geology")]
    [Authorize(Roles = "Admin")]
    [AllowAnonymous]
    public class GeologyController : ApiController
    {
        /// <summary>
        /// 根据id获取工程钻孔数据
        /// </summary>
        /// <param name="project">项目名称</param>
        /// <param name="id">钻孔id</param>
        /// <returns> </returns>
        [Route("borehole")]
        [HttpGet]
        public Borehole getBoreholeById(string project, int id)
        {
            var repo = RepositoryForServer<Borehole>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取钻孔
        /// </summary>
        /// <param name="project"></param>
        /// <param name="objsid"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Route("borehole")]
        [HttpGet]
        public List<Borehole> getBoreholeByObjs(string project, int objsid, string filter)
        {
            var repo = RepositoryForServer<Borehole>.GetInstance(project);
            return repo.RetrieveByObjs(objsid, filter).Result;
        }
        /// <summary>
        /// 新增borehole对象,连带其中的钻孔地层对象，如果有的话
        /// </summary>
        /// <param name="project"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("borehole")]
        [HttpPost]
        public Borehole postBorehole([FromUri]string project, [FromBody]Borehole model)
        {
            var repo = RepositoryForServer<Borehole>.GetInstance(project);
            return repo.Create(model).Result;
        }
        /// <summary>
        /// 更新钻孔信息，不更新其中的钻孔地层对象信息
        /// </summary>
        /// <param name="project"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("borehole")]
        [HttpPut]
        public Borehole putBorehole([FromUri]string project, [FromBody]Borehole model)
        {
            var repo = RepositoryForServer<Borehole>.GetInstance(project);
            return repo.Update(model).Result;
        }
        /// <summary>
        /// 删除钻孔对象，同时删除对应的钻孔地层对象
        /// </summary>
        /// <param name="project"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("borehole")]
        [HttpDelete]
        public int deleteBorehole([FromUri]string project, [FromBody]Borehole model)
        {
            var repo = RepositoryForServer<Borehole>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 新增钻孔地层对象
        /// </summary>
        /// <param name="project"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("boreholestrata")]
        [HttpPost]
        public BoreholeStrata postBoreholeStrata([FromUri]string project, [FromBody] BoreholeStrata model)
        {
            var repo = RepositoryForServer<BoreholeStrata>.GetInstance(project);
            return repo.Create(model).Result;
        }
        /// <summary>
        /// 修改钻孔地层对象
        /// </summary>
        /// <param name="project"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("boreholestrata")]
        [HttpPut]
        public BoreholeStrata putBoreholeStrata([FromUri]string project, [FromBody] BoreholeStrata model)
        {
            var repo = RepositoryForServer<BoreholeStrata>.GetInstance(project);
            return repo.Update(model).Result;
        }
        /// <summary>
        /// 删除钻孔地层对象
        /// </summary>
        /// <param name="project"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("boreholestrata")]
        [HttpDelete]
        public int deleteBoreholeStrata([FromUri]string project, [FromBody] BoreholeStrata model)
        {
            var repo = RepositoryForServer<BoreholeStrata>.GetInstance(project);
            return repo.Delete(model).Result;
        }


        /// <summary>
        /// 根据id获取施工进度对象
        /// </summary>
        [Route("proj")]
        [HttpGet]
        public PROJ getPROJById(string project, int id)
        {
            var repo = RepositoryForServer<PROJ>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取施工进度列表
        /// </summary>
        [Route("proj")]
        [HttpGet]
        public List<PROJ> getPROJByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<PROJ>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加施工进度对象
        /// </summary>
        [Route("proj")]
        [HttpPut]
        public PROJ putPROJByObjs([FromUri]string project, [FromBody]PROJ model)
        {
            var repo = RepositoryForServer<PROJ>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除施工进度对象
        /// </summary>
        [Route("proj")]
        [HttpDelete]
        public int deletePROJByObjs([FromUri]string project, [FromBody]PROJ model)
        {
            var repo = RepositoryForServer<PROJ>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取地层对象
        /// </summary>
        [Route("stra")]
        [HttpGet]
        public STRA getSTRAById(string project, int id)
        {
            var repo = RepositoryForServer<STRA>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取地层列表
        /// </summary>
        [Route("stra")]
        [HttpGet]
        public List<STRA> getSTRAByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<STRA>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加地层对象
        /// </summary>
        [Route("stra")]
        [HttpPut]
        public STRA putSTRAByObjs([FromUri]string project, [FromBody]STRA model)
        {
            var repo = RepositoryForServer<STRA>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除地层对象
        /// </summary>
        [Route("stra")]
        [HttpDelete]
        public int deleteSTRAByObjs([FromUri]string project, [FromBody]STRA model)
        {
            var repo = RepositoryForServer<STRA>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        string GetToken()
        {
            IEnumerable<string> oo;
            Request.Headers.TryGetValues("token", out oo);
            if (oo == null) { return null; }
            else
            {
                return oo.FirstOrDefault();
            }
        }

        /// <summary>
        /// 根据id获取航空航片信息对象
        /// </summary>
        [Route("aerp")]
        [HttpGet]
        public AERP getAERPById(string project, int id)
        {
            var repo = RepositoryForServer<AERP>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取航空航片信息列表
        /// </summary>
        [Route("aerp")]
        [HttpGet]
        public List<AERP> getAERPByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<AERP>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加航空航片信息对象
        /// </summary>
        [Route("aerp")]
        [HttpPut]
        public AERP putAERPByObjs([FromUri]string project, [FromBody]AERP model)
        {
            var repo = RepositoryForServer<AERP>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除航空航片信息对象
        /// </summary>
        [Route("aerp")]
        [HttpDelete]
        public int deleteAERPByObjs([FromUri]string project, [FromBody]AERP model)
        {
            var repo = RepositoryForServer<AERP>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取不良地质对象
        /// </summary>
        [Route("ageo")]
        [HttpGet]
        public AGEO getAGEOById(string project, int id)
        {
            var repo = RepositoryForServer<AGEO>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取不良地质列表
        /// </summary>
        [Route("ageo")]
        [HttpGet]
        public List<AGEO> getAGEOByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<AGEO>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加不良地质对象
        /// </summary>
        [Route("ageo")]
        [HttpPut]
        public AGEO putAGEOByObjs([FromUri]string project, [FromBody]AGEO model)
        {
            var repo = RepositoryForServer<AGEO>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除不良地质对象
        /// </summary>
        [Route("ageo")]
        [HttpDelete]
        public int deleteAGEOByObjs([FromUri]string project, [FromBody]AGEO model)
        {
            var repo = RepositoryForServer<AGEO>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取吸水率试验对象
        /// </summary>
        [Route("awad")]
        [HttpGet]
        public AWAD getAWAById(string project, int id)
        {
            var repo = RepositoryForServer<AWAD>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取吸水率试验列表
        /// </summary>
        [Route("awad")]
        [HttpGet]
        public List<AWAD> getAWADByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<AWAD>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加吸水率试验对象
        /// </summary>
        [Route("awad")]
        [HttpPut]
        public AWAD putATTDByObjs([FromUri]string project, [FromBody]AWAD model)
        {
            var repo = RepositoryForServer<AWAD>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除吸水率试验对象
        /// </summary>
        [Route("awad")]
        [HttpDelete]
        public int deleteAWADByObjs([FromUri]string project, [FromBody]AWAD model)
        {
            var repo = RepositoryForServer<AWAD>.GetInstance(project);
            return repo.Delete(model).Result;
        }




        /// <summary>
        /// 根据id获取取芯信息对象
        /// </summary>
        [Route("core")]
        [HttpGet]
        public CORE getCOREById(string project, int id)
        {
            var repo = RepositoryForServer<CORE>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取取芯信息列表
        /// </summary>
        [Route("core")]
        [HttpGet]
        public List<CORE> getCOREByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<CORE>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加取芯信息对象
        /// </summary>
        [Route("core")]
        [HttpPut]
        public CORE putCOREByObjs([FromUri]string project, [FromBody]CORE model)
        {
            var repo = RepositoryForServer<CORE>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除取芯信息对象
        /// </summary>
        [Route("core")]
        [HttpDelete]
        public int deleteCOREByObjs([FromUri]string project, [FromBody]CORE model)
        {
            var repo = RepositoryForServer<CORE>.GetInstance(project);
            return repo.Delete(model).Result;
        }




        /// <summary>
        /// 根据id获取耐崩解性试验对象
        /// </summary>
        [Route("disr")]
        [HttpGet]
        public DISR getDISRById(string project, int id)
        {
            var repo = RepositoryForServer<DISR>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取耐崩解性试验列表
        /// </summary>
        [Route("disr")]
        [HttpGet]
        public List<DISR> getDISRByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<DISR>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加耐崩解性试验对象
        /// </summary>
        [Route("disr")]
        [HttpPut]
        public DISR putDISRByObjs([FromUri]string project, [FromBody]DISR model)
        {
            var repo = RepositoryForServer<DISR>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除耐崩解性试验对象
        /// </summary>
        [Route("disr")]
        [HttpDelete]
        public int deleteDISRByObjs([FromUri]string project, [FromBody]DISR model)
        {
            var repo = RepositoryForServer<DISR>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取侧胀试验对象
        /// </summary>
        [Route("dmtg")]
        [HttpGet]
        public DMTG getDMTGById(string project, int id)
        {
            var repo = RepositoryForServer<DMTG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取侧胀试验列表
        /// </summary>
        [Route("dmtg")]
        [HttpGet]
        public List<DMTG> getDMTGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<DMTG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加侧胀试验对象
        /// </summary>
        [Route("dmtg")]
        [HttpPut]
        public DMTG putDMTGByObjs([FromUri]string project, [FromBody]DMTG model)
        {
            var repo = RepositoryForServer<DMTG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除侧胀试验对象
        /// </summary>
        [Route("dmtg")]
        [HttpDelete]
        public int deleteDMTGByObjs([FromUri]string project, [FromBody]DMTG model)
        {
            var repo = RepositoryForServer<DMTG>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取侧胀试验衍生参数对象
        /// </summary>
        [Route("dmtp")]
        [HttpGet]
        public DMTP getDMTPById(string project, int id)
        {
            var repo = RepositoryForServer<DMTP>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取侧胀试验衍生参数列表
        /// </summary>
        [Route("dmtp")]
        [HttpGet]
        public List<DMTP> getDMTPByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<DMTP>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加侧胀试验衍生参数对象
        /// </summary>
        [Route("dmtp")]
        [HttpPut]
        public DMTP putDMTGByObjs([FromUri]string project, [FromBody]DMTP model)
        {
            var repo = RepositoryForServer<DMTP>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除侧胀试验衍生参数对象
        /// </summary>
        [Route("dmtp")]
        [HttpDelete]
        public int deleteDMTPByObjs([FromUri]string project, [FromBody]DMTP model)
        {
            var repo = RepositoryForServer<DMTP>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取侧胀试验数据对象
        /// </summary>
        [Route("dmtt")]
        [HttpGet]
        public DMTT getDMTTById(string project, int id)
        {
            var repo = RepositoryForServer<DMTT>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取侧胀试验数据列表
        /// </summary>
        [Route("dmtt")]
        [HttpGet]
        public List<DMTT> getDMTTByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<DMTT>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加侧胀试验数据对象
        /// </summary>
        [Route("dmtt")]
        [HttpPut]
        public DMTT putDMTTByObjs([FromUri]string project, [FromBody]DMTT model)
        {
            var repo = RepositoryForServer<DMTT>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除侧胀试验数据对象
        /// </summary>
        [Route("dmtt")]
        [HttpDelete]
        public int deleteDMTTByObjs([FromUri]string project, [FromBody]DMTT model)
        {
            var repo = RepositoryForServer<DMTT>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取动力触探试验数据对象
        /// </summary>
        [Route("dprd")]
        [HttpGet]
        public DPRD getDPRDById(string project, int id)
        {
            var repo = RepositoryForServer<DPRD>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取动力触探试验数据列表
        /// </summary>
        [Route("dprd")]
        [HttpGet]
        public List<DPRD> getDPRDByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<DPRD>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加动力触探试验数据对象
        /// </summary>
        [Route("dprd")]
        [HttpPut]
        public DPRD putDPRDByObjs([FromUri]string project, [FromBody]DPRD model)
        {
            var repo = RepositoryForServer<DPRD>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除动力触探试验数据对象
        /// </summary>
        [Route("dprd")]
        [HttpDelete]
        public int deleteDPRDByObjs([FromUri]string project, [FromBody]DPRD model)
        {
            var repo = RepositoryForServer<DPRD>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取动力触探试验对象
        /// </summary>
        [Route("dprg")]
        [HttpGet]
        public DPRG getDPRGById(string project, int id)
        {
            var repo = RepositoryForServer<DPRG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取动力触探试验列表
        /// </summary>
        [Route("dprg")]
        [HttpGet]
        public List<DPRG> getDPRGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<DPRG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加动力触探试验对象
        /// </summary>
        [Route("dprg")]
        [HttpPut]
        public DPRG putDPRGByObjs([FromUri]string project, [FromBody]DPRG model)
        {
            var repo = RepositoryForServer<DPRG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除动力触探试验对象
        /// </summary>
        [Route("dprg")]
        [HttpDelete]
        public int deleteDPRGByObjs([FromUri]string project, [FromBody]DPRG model)
        {
            var repo = RepositoryForServer<DPRG>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取膨胀试验对象
        /// </summary>
        [Route("expa")]
        [HttpGet]
        public EXPA getEXPAById(string project, int id)
        {
            var repo = RepositoryForServer<EXPA>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取膨胀试验列表
        /// </summary>
        [Route("expa")]
        [HttpGet]
        public List<EXPA> getEXPAByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<EXPA>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加膨胀试验对象
        /// </summary>
        [Route("expa")]
        [HttpPut]
        public EXPA putEXPAByObjs([FromUri]string project, [FromBody]EXPA model)
        {
            var repo = RepositoryForServer<EXPA>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除膨胀试验对象
        /// </summary>
        [Route("expa")]
        [HttpDelete]
        public int deleteEXPAByObjs([FromUri]string project, [FromBody]EXPA model)
        {
            var repo = RepositoryForServer<EXPA>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取现场直剪试验数据对象
        /// </summary>
        [Route("fdsd")]
        [HttpGet]
        public FDSD getFDSDById(string project, int id)
        {
            var repo = RepositoryForServer<FDSD>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取现场直剪试验数据列表
        /// </summary>
        [Route("fdsd")]
        [HttpGet]
        public List<FDSD> getFDSDByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<FDSD>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加现场直剪试验数据对象
        /// </summary>
        [Route("fdsd")]
        [HttpPut]
        public FDSD putFDSDByObjs([FromUri]string project, [FromBody]FDSD model)
        {
            var repo = RepositoryForServer<FDSD>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除现场直剪试验数据对象
        /// </summary>
        [Route("fdsd")]
        [HttpDelete]
        public int deleteFDSDByObjs([FromUri]string project, [FromBody]FDSD model)
        {
            var repo = RepositoryForServer<FDSD>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取现场直剪试验对象
        /// </summary>
        [Route("fdst")]
        [HttpGet]
        public FDST getFDSTById(string project, int id)
        {
            var repo = RepositoryForServer<FDST>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取现场直剪试验列表
        /// </summary>
        [Route("fdst")]
        [HttpGet]
        public List<FDST> getFDSTByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<FDST>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加现场直剪试验对象
        /// </summary>
        [Route("fdst")]
        [HttpPut]
        public FDST putFDSTByObjs([FromUri]string project, [FromBody]FDST model)
        {
            var repo = RepositoryForServer<FDST>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除现场直剪试验对象
        /// </summary>
        [Route("fdst")]
        [HttpDelete]
        public int deleteFDSTByObjs([FromUri]string project, [FromBody]FDST model)
        {
            var repo = RepositoryForServer<FDST>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取冻融试验对象
        /// </summary>
        [Route("frez")]
        [HttpGet]
        public FREZ getFREZById(string project, int id)
        {
            var repo = RepositoryForServer<FREZ>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取冻融试验列表
        /// </summary>
        [Route("frez")]
        [HttpGet]
        public List<FREZ> getFREZByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<FREZ>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加冻融试验对象
        /// </summary>
        [Route("frez")]
        [HttpPut]
        public FREZ putFREZByObjs([FromUri]string project, [FromBody]FREZ model)
        {
            var repo = RepositoryForServer<FREZ>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除冻融试验对象
        /// </summary>
        [Route("frez")]
        [HttpDelete]
        public int deleteFREZByObjs([FromUri]string project, [FromBody]FREZ model)
        {
            var repo = RepositoryForServer<FREZ>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取地球物理勘探对象
        /// </summary>
        [Route("geoe")]
        [HttpGet]
        public GEOE getGEOEById(string project, int id)
        {
            var repo = RepositoryForServer<GEOE>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取地球物理勘探列表
        /// </summary>
        [Route("geoe")]
        [HttpGet]
        public List<GEOE> getGEOEByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<GEOE>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加地球物理勘探对象
        /// </summary>
        [Route("geoe")]
        [HttpPut]
        public GEOE putGEOEByObjs([FromUri]string project, [FromBody]GEOE model)
        {
            var repo = RepositoryForServer<GEOE>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除地球物理勘探对象
        /// </summary>
        [Route("geoe")]
        [HttpDelete]
        public int deleteGEOEByObjs([FromUri]string project, [FromBody]GEOE model)
        {
            var repo = RepositoryForServer<GEOE>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取地质构造对象
        /// </summary>
        [Route("geos")]
        [HttpGet]
        public GEOS getGEOSById(string project, int id)
        {
            var repo = RepositoryForServer<GEOS>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取地质构造列表
        /// </summary>
        [Route("geos")]
        [HttpGet]
        public List<GEOS> getGEOSByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<GEOS>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加地质构造对象
        /// </summary>
        [Route("geos")]
        [HttpPut]
        public GEOS putGEOSByObjs([FromUri]string project, [FromBody]GEOS model)
        {
            var repo = RepositoryForServer<GEOS>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除地质构造对象
        /// </summary>
        [Route("geos")]
        [HttpDelete]
        public int deleteGEOSByObjs([FromUri]string project, [FromBody]GEOS model)
        {
            var repo = RepositoryForServer<GEOS>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取地形地貌基本信息对象
        /// </summary>
        [Route("gmpg")]
        [HttpGet]
        public GMPG getGMPGById(string project, int id)
        {
            var repo = RepositoryForServer<GMPG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取地形地貌基本信息列表
        /// </summary>
        [Route("gmpg")]
        [HttpGet]
        public List<GMPG> getGMPGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<GMPG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加地形地貌基本信息对象
        /// </summary>
        [Route("gmpg")]
        [HttpPut]
        public GMPG putGMPGByObjs([FromUri]string project, [FromBody]GMPG model)
        {
            var repo = RepositoryForServer<GMPG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除地形地貌基本信息对象
        /// </summary>
        [Route("gmpg")]
        [HttpDelete]
        public int deleteGMPGByObjs([FromUri]string project, [FromBody]GMPG model)
        {
            var repo = RepositoryForServer<GMPG>.GetInstance(project);
            return repo.Delete(model).Result;
        }


        /// <summary>
        /// 根据id获取勘探孔基本信息对象
        /// </summary>
        [Route("hdph")]
        [HttpGet]
        public HDPH getHDPHById(string project, int id)
        {
            var repo = RepositoryForServer<HDPH>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取勘探孔基本信息列表
        /// </summary>
        [Route("hdph")]
        [HttpGet]
        public List<HDPH> getHDPHByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<HDPH>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加勘探孔基本信息对象
        /// </summary>
        [Route("hdph")]
        [HttpPut]
        public HDPH putHDPHByObjs([FromUri]string project, [FromBody]HDPH model)
        {
            var repo = RepositoryForServer<HDPH>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除勘探孔基本信息对象
        /// </summary>
        [Route("hdph")]
        [HttpDelete]
        public int deleteHDPHByObjs([FromUri]string project, [FromBody]HDPH model)
        {
            var repo = RepositoryForServer<HDPH>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取水压致裂试验数据对象
        /// </summary>
        [Route("hftd")]
        [HttpGet]
        public HFTD getHFTDById(string project, int id)
        {
            var repo = RepositoryForServer<HFTD>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取水压致裂试验数据列表
        /// </summary>
        [Route("hftd")]
        [HttpGet]
        public List<HFTD> getHFTDByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<HFTD>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加水压致裂试验数据对象
        /// </summary>
        [Route("hftd")]
        [HttpPut]
        public HFTD putHFTDByObjs([FromUri]string project, [FromBody]HFTD model)
        {
            var repo = RepositoryForServer<HFTD>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除水压致裂试验数据对象
        /// </summary>
        [Route("hftd")]
        [HttpDelete]
        public int deleteHFTDByObjs([FromUri]string project, [FromBody]HFTD model)
        {
            var repo = RepositoryForServer<HFTD>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取勘水压致裂试验对象
        /// </summary>
        [Route("hftg")]
        [HttpGet]
        public HFTG getHFTGById(string project, int id)
        {
            var repo = RepositoryForServer<HFTG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取水压致裂试验列表
        /// </summary>
        [Route("hftg")]
        [HttpGet]
        public List<HFTG> getHFTGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<HFTG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加水压致裂试验对象
        /// </summary>
        [Route("hftg")]
        [HttpPut]
        public HFTG putHFTGByObjs([FromUri]string project, [FromBody]HFTG model)
        {
            var repo = RepositoryForServer<HFTG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除水压致裂试验对象
        /// </summary>
        [Route("hftg")]
        [HttpDelete]
        public int deleteHFTGByObjs([FromUri]string project, [FromBody]HFTG model)
        {
            var repo = RepositoryForServer<HFTG>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取水压致裂试验衍生数据对象
        /// </summary>
        [Route("hftp")]
        [HttpGet]
        public HFTP getHFTPById(string project, int id)
        {
            var repo = RepositoryForServer<HFTP>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取水压致裂试验衍生数据列表
        /// </summary>
        [Route("hftp")]
        [HttpGet]
        public List<HFTP> getHFTPByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<HFTP>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加水压致裂试验衍生数据对象
        /// </summary>
        [Route("hftp")]
        [HttpPut]
        public HFTP putHFTPByObjs([FromUri]string project, [FromBody]HFTP model)
        {
            var repo = RepositoryForServer<HFTP>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除水压致裂试验衍生数据对象
        /// </summary>
        [Route("hftp")]
        [HttpDelete]
        public int deleteHFTPByObjs([FromUri]string project, [FromBody]HFTP model)
        {
            var repo = RepositoryForServer<HFTP>.GetInstance(project);
            return repo.Delete(model).Result;
        }


        /// <summary>
        /// 根据id获取遥感信息解译对象
        /// </summary>
        [Route("irsi")]
        [HttpGet]
        public IRSI getIRSIById(string project, int id)
        {
            var repo = RepositoryForServer<IRSI>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取遥感信息解译列表
        /// </summary>
        [Route("irsi")]
        [HttpGet]
        public List<IRSI> getIRSIByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<IRSI>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加遥感信息解译对象
        /// </summary>
        [Route("irsi")]
        [HttpPut]
        public IRSI putIRSIByObjs([FromUri]string project, [FromBody]IRSI model)
        {
            var repo = RepositoryForServer<IRSI>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除遥感信息解译对象
        /// </summary>
        [Route("irsi")]
        [HttpDelete]
        public int deleteIRSIByObjs([FromUri]string project, [FromBody]IRSI model)
        {
            var repo = RepositoryForServer<IRSI>.GetInstance(project);
            return repo.Delete(model).Result;
        }




        /// <summary>
        /// 根据id获取载荷板试验对象
        /// </summary>
        [Route("pltg")]
        [HttpGet]
        public PLTG getPLTGById(string project, int id)
        {
            var repo = RepositoryForServer<PLTG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取载荷板试验列表
        /// </summary>
        [Route("pltg")]
        [HttpGet]
        public List<PLTG> getPLTGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<PLTG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加载荷板试验对象
        /// </summary>
        [Route("pltg")]
        [HttpPut]
        public PLTG putPLTGByObjs([FromUri]string project, [FromBody]PLTG model)
        {
            var repo = RepositoryForServer<PLTG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除载荷板试验对象
        /// </summary>
        [Route("pltg")]
        [HttpDelete]
        public int deletePLTGByObjs([FromUri]string project, [FromBody]PLTG model)
        {
            var repo = RepositoryForServer<PLTG>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取载荷板试验数据对象
        /// </summary>
        [Route("pltt")]
        [HttpGet]
        public PLTT getPLTTById(string project, int id)
        {
            var repo = RepositoryForServer<PLTT>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取载荷板试验数据列表
        /// </summary>
        [Route("pltt")]
        [HttpGet]
        public List<PLTT> getPLTTByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<PLTT>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加载荷板试验数据对象
        /// </summary>
        [Route("pltt")]
        [HttpPut]
        public PLTT putPLTTByObjs([FromUri]string project, [FromBody]PLTT model)
        {
            var repo = RepositoryForServer<PLTT>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除载荷板试验数据对象
        /// </summary>
        [Route("pltt")]
        [HttpDelete]
        public int deletePLTTByObjs([FromUri]string project, [FromBody]PLTT model)
        {
            var repo = RepositoryForServer<PLTT>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取旁压试验数据对象
        /// </summary>
        [Route("pmtd")]
        [HttpGet]
        public PMTD getPMTDById(string project, int id)
        {
            var repo = RepositoryForServer<PMTD>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取旁压试验数据列表
        /// </summary>
        [Route("pmtd")]
        [HttpGet]
        public List<PMTD> getPMTDByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<PMTD>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加旁压试验数据对象
        /// </summary>
        [Route("pmtd")]
        [HttpPut]
        public PMTD putPMTDByObjs([FromUri]string project, [FromBody]PMTD model)
        {
            var repo = RepositoryForServer<PMTD>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除旁压试验数据对象
        /// </summary>
        [Route("pmtd")]
        [HttpDelete]
        public int deletePMTDByObjs([FromUri]string project, [FromBody]PMTD model)
        {
            var repo = RepositoryForServer<PMTD>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取旁压试验对象
        /// </summary>
        [Route("pmtg")]
        [HttpGet]
        public PMTG getPMTGById(string project, int id)
        {
            var repo = RepositoryForServer<PMTG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取旁压试验列表
        /// </summary>
        [Route("pmtg")]
        [HttpGet]
        public List<PMTG> getPMTGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<PMTG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加旁压试验对象
        /// </summary>
        [Route("pmtg")]
        [HttpPut]
        public PMTG putPMTGByObjs([FromUri]string project, [FromBody]PMTG model)
        {
            var repo = RepositoryForServer<PMTG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除旁压试验对象
        /// </summary>
        [Route("pmtg")]
        [HttpDelete]
        public int deletePMTGByObjs([FromUri]string project, [FromBody]PMTG model)
        {
            var repo = RepositoryForServer<PMTG>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取岩石密度试验对象
        /// </summary>
        [Route("rden")]
        [HttpGet]
        public RDEN getRDENById(string project, int id)
        {
            var repo = RepositoryForServer<RDEN>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取岩石密度试验列表
        /// </summary>
        [Route("rden")]
        [HttpGet]
        public List<RDEN> getRDENByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RDEN>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加岩石密度试验对象
        /// </summary>
        [Route("rden")]
        [HttpPut]
        public RDEN putRDENByObjs([FromUri]string project, [FromBody]RDEN model)
        {
            var repo = RepositoryForServer<RDEN>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除岩石密度试验对象
        /// </summary>
        [Route("rden")]
        [HttpDelete]
        public int deleteRDENByObjs([FromUri]string project, [FromBody]RDEN model)
        {
            var repo = RepositoryForServer<RDEN>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取相对密度试验对象
        /// </summary>
        [Route("reld")]
        [HttpGet]
        public RELD getRELDById(string project, int id)
        {
            var repo = RepositoryForServer<RELD>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取相对密度试验列表
        /// </summary>
        [Route("reld")]
        [HttpGet]
        public List<RELD> getRELDByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RELD>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加相对密度试验对象
        /// </summary>
        [Route("reld")]
        [HttpPut]
        public RELD putRELDByObjs([FromUri]string project, [FromBody]RELD model)
        {
            var repo = RepositoryForServer<RELD>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除相对密度试验对象
        /// </summary>
        [Route("reld")]
        [HttpDelete]
        public int deleteRELDByObjs([FromUri]string project, [FromBody]RELD model)
        {
            var repo = RepositoryForServer<RELD>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取河流对象
        /// </summary>
        [Route("rivr")]
        [HttpGet]
        public RIVR getRIVRById(string project, int id)
        {
            var repo = RepositoryForServer<RIVR>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取河流列表
        /// </summary>
        [Route("rivr")]
        [HttpGet]
        public List<RIVR> getRIVRByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RIVR>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加河流对象
        /// </summary>
        [Route("rivr")]
        [HttpPut]
        public RIVR putRIVRByObjs([FromUri]string project, [FromBody]RIVR model)
        {
            var repo = RepositoryForServer<RIVR>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除河流对象
        /// </summary>
        [Route("rivr")]
        [HttpDelete]
        public int deleteRIVRByObjs([FromUri]string project, [FromBody]RIVR model)
        {
            var repo = RepositoryForServer<RIVR>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取泉点对象
        /// </summary>
        [Route("sppo")]
        [HttpGet]
        public SPPO getSPPOById(string project, int id)
        {
            var repo = RepositoryForServer<SPPO>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取河流列表
        /// </summary>
        [Route("sppo")]
        [HttpGet]
        public List<SPPO> getSPPOByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<SPPO>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加河流对象
        /// </summary>
        [Route("sppo")]
        [HttpPut]
        public SPPO putSPPOByObjs([FromUri]string project, [FromBody]SPPO model)
        {
            var repo = RepositoryForServer<SPPO>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除河流对象
        /// </summary>
        [Route("sppo")]
        [HttpDelete]
        public int deleteSPPOByObjs([FromUri]string project, [FromBody]SPPO model)
        {
            var repo = RepositoryForServer<SPPO>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取岩矿鉴定试验结果对象
        /// </summary>
        [Route("rmar")]
        [HttpGet]
        public RMAR getRMARById(string project, int id)
        {
            var repo = RepositoryForServer<RMAR>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取岩矿鉴定试验结果列表
        /// </summary>
        [Route("rmar")]
        [HttpGet]
        public List<RMAR> getRMARByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RMAR>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加岩矿鉴定试验结果对象
        /// </summary>
        [Route("rmar")]
        [HttpPut]
        public RMAR putRMARByObjs([FromUri]string project, [FromBody]RMAR model)
        {
            var repo = RepositoryForServer<RMAR>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除岩矿鉴定试验结果对象
        /// </summary>
        [Route("rmar")]
        [HttpDelete]
        public int deleteRMARByObjs([FromUri]string project, [FromBody]RMAR model)
        {
            var repo = RepositoryForServer<RMAR>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取岩矿含量对象
        /// </summary>
        [Route("rmct")]
        [HttpGet]
        public RMCT getRMCTById(string project, int id)
        {
            var repo = RepositoryForServer<RMCT>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取岩矿含量列表
        /// </summary>
        [Route("rmct")]
        [HttpGet]
        public List<RMCT> getRMCTByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RMCT>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加岩矿含量对象
        /// </summary>
        [Route("rmct")]
        [HttpPut]
        public RMCT putRMCTByObjs([FromUri]string project, [FromBody]RMCT model)
        {
            var repo = RepositoryForServer<RMCT>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除岩矿含量对象
        /// </summary>
        [Route("rmct")]
        [HttpDelete]
        public int deleteRMCTByObjs([FromUri]string project, [FromBody]RMCT model)
        {
            var repo = RepositoryForServer<RMCT>.GetInstance(project);
            return repo.Delete(model).Result;
        }


        /// <summary>
        /// 根据id获取水文地质单元对象
        /// </summary>
        [Route("hyun")]
        [HttpGet]
        public HYUN getHYUNById(string project, int id)
        {
            var repo = RepositoryForServer<HYUN>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取水文地质单元列表
        /// </summary>
        [Route("hyun")]
        [HttpGet]
        public List<HYUN> getHYUNByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<HYUN>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加水文地质单元对象
        /// </summary>
        [Route("hyun")]
        [HttpPut]
        public HYUN putHYUNByObjs([FromUri]string project, [FromBody]HYUN model)
        {
            var repo = RepositoryForServer<HYUN>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除水文地质单元对象
        /// </summary>
        [Route("hyun")]
        [HttpDelete]
        public int deleteHYUNByObjs([FromUri]string project, [FromBody]HYUN model)
        {
            var repo = RepositoryForServer<HYUN>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取水化学数据采样对象
        /// </summary>
        [Route("hych")]
        [HttpGet]
        public HYCH getHYCHById(string project, int id)
        {
            var repo = RepositoryForServer<HYCH>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取水化学数据采样列表
        /// </summary>
        [Route("hych")]
        [HttpGet]
        public List<HYCH> getHYCHByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<HYCH>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加水化学数据采样对象
        /// </summary>
        [Route("hych")]
        [HttpPut]
        public HYCH putHYCHByObjs([FromUri]string project, [FromBody]HYCH model)
        {
            var repo = RepositoryForServer<HYCH>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除水化学数据采样对象
        /// </summary>
        [Route("hych")]
        [HttpDelete]
        public int deleteHYCHByObjs([FromUri]string project, [FromBody]HYCH model)
        {
            var repo = RepositoryForServer<HYCH>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取注水记录对象
        /// </summary>
        [Route("wadd")]
        [HttpGet]
        public WADD getWADDById(string project, int id)
        {
            var repo = RepositoryForServer<WADD>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取注水记录列表
        /// </summary>
        [Route("wadd")]
        [HttpGet]
        public List<WADD> getWADDByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<WADD>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加注水记录对象
        /// </summary>
        [Route("wadd")]
        [HttpPut]
        public WADD putWADDByObjs([FromUri]string project, [FromBody]WADD model)
        {
            var repo = RepositoryForServer<WADD>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除注水记录对象
        /// </summary>
        [Route("wadd")]
        [HttpDelete]
        public int deleteWADDByObjs([FromUri]string project, [FromBody]WADD model)
        {
            var repo = RepositoryForServer<WADD>.GetInstance(project);
            return repo.Delete(model).Result;
        }


        /// <summary>
        /// 根据id获取十字板剪切试验数据对象
        /// </summary>
        [Route("vane")]
        [HttpGet]
        public VANE getVANEById(string project, int id)
        {
            var repo = RepositoryForServer<VANE>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取十字板剪切试验数据列表
        /// </summary>
        [Route("vane")]
        [HttpGet]
        public List<VANE> getVANEByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<VANE>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加十字板剪切试验数据对象
        /// </summary>
        [Route("vane")]
        [HttpPut]
        public VANE putVANEByObjs([FromUri]string project, [FromBody]VANE model)
        {
            var repo = RepositoryForServer<VANE>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除十字板剪切试验数据对象
        /// </summary>
        [Route("vane")]
        [HttpDelete]
        public int deleteVANEByObjs([FromUri]string project, [FromBody]VANE model)
        {
            var repo = RepositoryForServer<VANE>.GetInstance(project);
            return repo.Delete(model).Result;
        }





        /// <summary>
        /// 根据id获取三轴试验数据(总应力）对象
        /// </summary>
        [Route("trit")]
        [HttpGet]
        public TRIT getTRITById(string project, int id)
        {
            var repo = RepositoryForServer<TRIT>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取三轴试验数据(总应力）列表
        /// </summary>
        [Route("trit")]
        [HttpGet]
        public List<TRIT> getTRITByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<TRIT>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加三轴试验数据(总应力）对象
        /// </summary>
        [Route("trit")]
        [HttpPut]
        public TRIT putTRITByObjs([FromUri]string project, [FromBody]TRIT model)
        {
            var repo = RepositoryForServer<TRIT>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除三轴试验数据(总应力）对象
        /// </summary>
        [Route("trit")]
        [HttpDelete]
        public int deleteTRITByObjs([FromUri]string project, [FromBody]TRIT model)
        {
            var repo = RepositoryForServer<TRIT>.GetInstance(project);
            return repo.Delete(model).Result;
        }


        /// <summary>
        /// 根据id获取三轴试验(总应力）对象
        /// </summary>
        [Route("trig")]
        [HttpGet]
        public TRIG getTRIGById(string project, int id)
        {
            var repo = RepositoryForServer<TRIG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取三轴试验(总应力）列表
        /// </summary>
        [Route("trig")]
        [HttpGet]
        public List<TRIG> getTRIGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<TRIG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加三轴试验(总应力）对象
        /// </summary>
        [Route("trig")]
        [HttpPut]
        public TRIG putTRIGByObjs([FromUri]string project, [FromBody]TRIG model)
        {
            var repo = RepositoryForServer<TRIG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除三轴试验(总应力）对象
        /// </summary>
        [Route("trig")]
        [HttpDelete]
        public int deleteTRIGByObjs([FromUri]string project, [FromBody]TRIG model)
        {
            var repo = RepositoryForServer<TRIG>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取三轴试验数据（有效应力）对象
        /// </summary>
        [Route("tret")]
        [HttpGet]
        public TRET getTRETById(string project, int id)
        {
            var repo = RepositoryForServer<TRET>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取三轴试验数据（有效应力）列表
        /// </summary>
        [Route("tret")]
        [HttpGet]
        public List<TRET> getTRETByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<TRET>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加三轴试验数据（有效应力）对象
        /// </summary>
        [Route("tret")]
        [HttpPut]
        public TRET putTRETByObjs([FromUri]string project, [FromBody]TRET model)
        {
            var repo = RepositoryForServer<TRET>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除三轴试验数据（有效应力）对象
        /// </summary>
        [Route("tret")]
        [HttpDelete]
        public int deleteTRETByObjs([FromUri]string project, [FromBody]TRET model)
        {
            var repo = RepositoryForServer<TRET>.GetInstance(project);
            return repo.Delete(model).Result;
        }


        /// <summary>
        /// 根据id获取三轴试验（有效应力）对象
        /// </summary>
        [Route("treg")]
        [HttpGet]
        public TREG getTREGById(string project, int id)
        {
            var repo = RepositoryForServer<TREG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取三轴试验（有效应力）列表
        /// </summary>
        [Route("treg")]
        [HttpGet]
        public List<TREG> getTREGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<TREG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加三轴试验（有效应力）对象
        /// </summary>
        [Route("treg")]
        [HttpPut]
        public TREG putTREGByObjs([FromUri]string project, [FromBody]TREG model)
        {
            var repo = RepositoryForServer<TREG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除三轴试验（有效应力）对象
        /// </summary>
        [Route("treg")]
        [HttpDelete]
        public int deleteTREGByObjs([FromUri]string project, [FromBody]TREG model)
        {
            var repo = RepositoryForServer<TREG>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取标准贯入试验对象
        /// </summary>
        [Route("sptr")]
        [HttpGet]
        public SPTR getSPTRById(string project, int id)
        {
            var repo = RepositoryForServer<SPTR>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取标准贯入试验列表
        /// </summary>
        [Route("sptr")]
        [HttpGet]
        public List<SPTR> getSPTRByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<SPTR>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加标准贯入试验对象
        /// </summary>
        [Route("sptr")]
        [HttpPut]
        public SPTR putSPTRByObjs([FromUri]string project, [FromBody]SPTR model)
        {
            var repo = RepositoryForServer<SPTR>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除标准贯入试验对象
        /// </summary>
        [Route("sptr")]
        [HttpDelete]
        public int deleteSPTRByObjs([FromUri]string project, [FromBody]SPEC model)
        {
            var repo = RepositoryForServer<SPEC>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取特殊性岩土对象
        /// </summary>
        [Route("spec")]
        [HttpGet]
        public SPEC getSPECById(string project, int id)
        {
            var repo = RepositoryForServer<SPEC>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取特殊性岩土列表
        /// </summary>
        [Route("spec")]
        [HttpGet]
        public List<SPEC> getSPECByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<SPEC>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加特殊性岩土对象
        /// </summary>
        [Route("spec")]
        [HttpPut]
        public SPEC putSPECByObjs([FromUri]string project, [FromBody]SPEC model)
        {
            var repo = RepositoryForServer<SPEC>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除特殊性岩土对象
        /// </summary>
        [Route("spec")]
        [HttpDelete]
        public int deleteSPECByObjs([FromUri]string project, [FromBody]SPEC model)
        {
            var repo = RepositoryForServer<SPEC>.GetInstance(project);
            return repo.Delete(model).Result;
        }




        /// <summary>
        /// 根据id获取土体密度试验对象
        /// </summary>
        [Route("sden")]
        [HttpGet]
        public SDEN getSDENById(string project, int id)
        {
            var repo = RepositoryForServer<SDEN>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取土体密度试验列表
        /// </summary>
        [Route("sden")]
        [HttpGet]
        public List<SDEN> getSDENByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<SDEN>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加土体密度试验对象
        /// </summary>
        [Route("sden")]
        [HttpPut]
        public SDEN putSDENByObjs([FromUri]string project, [FromBody]SDEN model)
        {
            var repo = RepositoryForServer<SDEN>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除土体密度试验对象
        /// </summary>
        [Route("sden")]
        [HttpDelete]
        public int deleteSDENByObjs([FromUri]string project, [FromBody]SDEN model)
        {
            var repo = RepositoryForServer<SDEN>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取静力触探试验对象
        /// </summary>
        [Route("scpg")]
        [HttpGet]
        public SCPG getSCPGById(string project, int id)
        {
            var repo = RepositoryForServer<SCPG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取静力触探试验列表
        /// </summary>
        [Route("scpg")]
        [HttpGet]
        public List<SCPG> getSCPGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<SCPG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加静力触探试验对象
        /// </summary>
        [Route("scpg")]
        [HttpPut]
        public SCPG putSCPGByObjs([FromUri]string project, [FromBody]SCPG model)
        {
            var repo = RepositoryForServer<SCPG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除静力触探试验对象
        /// </summary>
        [Route("scpg")]
        [HttpDelete]
        public int deleteSCPGByObjs([FromUri]string project, [FromBody]SCPG model)
        {
            var repo = RepositoryForServer<SCPG>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取静力触探试验数据对象
        /// </summary>
        [Route("scpd")]
        [HttpGet]
        public SCPD getSCPDById(string project, int id)
        {
            var repo = RepositoryForServer<SCPD>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取静力触探试验数据列表
        /// </summary>
        [Route("scpd")]
        [HttpGet]
        public List<SCPD> getSCPDByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<SCPD>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加静力触探试验数据对象
        /// </summary>
        [Route("scpd")]
        [HttpPut]
        public SCPD putSCPDByObjs([FromUri]string project, [FromBody]SCPD model)
        {
            var repo = RepositoryForServer<SCPD>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除静力触探试验数据对象
        /// </summary>
        [Route("scpd")]
        [HttpDelete]
        public int deleteSCPDByObjs([FromUri]string project, [FromBody]SCPD model)
        {
            var repo = RepositoryForServer<SCPD>.GetInstance(project);
            return repo.Delete(model).Result;
        }




        /// <summary>
        /// 根据id获取岩石单轴抗压试验对象
        /// </summary>
        [Route("rucs")]
        [HttpGet]
        public RUCS getRUCSById(string project, int id)
        {
            var repo = RepositoryForServer<RUCS>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取岩石单轴抗压试验列表
        /// </summary>
        [Route("rucs")]
        [HttpGet]
        public List<RUCS> getRUCSByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RUCS>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加岩石单轴抗压试验对象
        /// </summary>
        [Route("rucs")]
        [HttpPut]
        public RUCS putRUCSByObjs([FromUri]string project, [FromBody]RUCS model)
        {
            var repo = RepositoryForServer<RUCS>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除岩石单轴抗压试验对象
        /// </summary>
        [Route("rucs")]
        [HttpDelete]
        public int deleteRUCSByObjs([FromUri]string project, [FromBody]RUCS model)
        {
            var repo = RepositoryForServer<RUCS>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取抗拉试验对象
        /// </summary>
        [Route("rten")]
        [HttpGet]
        public RTEN getRTENById(string project, int id)
        {
            var repo = RepositoryForServer<RTEN>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取抗拉试验列表
        /// </summary>
        [Route("rten")]
        [HttpGet]
        public List<RTEN> getRTENByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RTEN>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加抗拉试验对象
        /// </summary>
        [Route("rten")]
        [HttpPut]
        public RTEN putRTENByObjs([FromUri]string project, [FromBody]RTEN model)
        {
            var repo = RepositoryForServer<RTEN>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除抗拉试验对象
        /// </summary>
        [Route("rten")]
        [HttpDelete]
        public int deleteRTENByObjs([FromUri]string project, [FromBody]RTEN model)
        {
            var repo = RepositoryForServer<RTEN>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取水库对象
        /// </summary>
        [Route("rsvr")]
        [HttpGet]
        public RSVR getRSVRById(string project, int id)
        {
            var repo = RepositoryForServer<RSVR>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取水库列表
        /// </summary>
        [Route("rsvr")]
        [HttpGet]
        public List<RSVR> getRSVRByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RSVR>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加水库对象
        /// </summary>
        [Route("rsvr")]
        [HttpPut]
        public RSVR putRSVRByObjs([FromUri]string project, [FromBody]RSVR model)
        {
            var repo = RepositoryForServer<RSVR>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除水库对象
        /// </summary>
        [Route("rsvr")]
        [HttpDelete]
        public int deleteRSVRByObjs([FromUri]string project, [FromBody]RSVR model)
        {
            var repo = RepositoryForServer<RSVR>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取剪切试验对象
        /// </summary>
        [Route("rshg")]
        [HttpGet]
        public RSHG getRSHGById(string project, int id)
        {
            var repo = RepositoryForServer<RSHG>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取剪切试验列表
        /// </summary>
        [Route("rshg")]
        [HttpGet]
        public List<RSHG> getRSHGByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RSHG>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加剪切试验对象
        /// </summary>
        [Route("rshg")]
        [HttpPut]
        public RSHG putRSHGByObjs([FromUri]string project, [FromBody]RSHG model)
        {
            var repo = RepositoryForServer<RSHG>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除剪切试验对象
        /// </summary>
        [Route("rshg")]
        [HttpDelete]
        public int deleteRSHGByObjs([FromUri]string project, [FromBody]RSHG model)
        {
            var repo = RepositoryForServer<RSHG>.GetInstance(project);
            return repo.Delete(model).Result;
        }



        /// <summary>
        /// 根据id获取剪切试验数据对象
        /// </summary>
        [Route("rshd")]
        [HttpGet]
        public RSHD getRSHDById(string project, int id)
        {
            var repo = RepositoryForServer<RSHD>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取剪切试验数据列表
        /// </summary>
        [Route("rshd")]
        [HttpGet]
        public List<RSHD> getRSHDByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<RSHD>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加剪切试验数据对象
        /// </summary>
        [Route("rshd")]
        [HttpPut]
        public RSHD putRSHDByObjs([FromUri]string project, [FromBody]RSHD model)
        {
            var repo = RepositoryForServer<RSHD>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除剪切试验数据对象
        /// </summary>
        [Route("rshd")]
        [HttpDelete]
        public int deleteRSHDByObjs([FromUri]string project, [FromBody]RSHD model)
        {
            var repo = RepositoryForServer<RSHD>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取气象信息对象
        /// </summary>
        [Route("weat")]
        [HttpGet]
        public WEAT getWEATById(string project, int id)
        {
            var repo = RepositoryForServer<WEAT>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取气象信息列表
        /// </summary>
        [Route("weat")]
        [HttpGet]
        public List<WEAT> getWEATByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<WEAT>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加气象信息对象
        /// </summary>
        [Route("weat")]
        [HttpPut]
        public WEAT putWEATByObjs([FromUri]string project, [FromBody]WEAT model)
        {
            var repo = RepositoryForServer<WEAT>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除气象信息对象
        /// </summary>
        [Route("weat")]
        [HttpDelete]
        public int deleteWEATByObjs([FromUri]string project, [FromBody]WEAT model)
        {
            var repo = RepositoryForServer<WEAT>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取钻孔数据表对象
        /// </summary>
        [Route("boho")]
        [HttpGet]
        public BOHO getBOHOById(string project, int id)
        {
            var repo = RepositoryForServer<BOHO>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取钻孔数据表列表
        /// </summary>
        [Route("boho")]
        [HttpGet]
        public List<BOHO> getBOHOByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<BOHO>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加钻孔数据表对象
        /// </summary>
        [Route("boho")]
        [HttpPut]
        public BOHO putBOHOByObjs([FromUri]string project, [FromBody]BOHO model)
        {
            var repo = RepositoryForServer<BOHO>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除钻孔数据表对象
        /// </summary>
        [Route("boho")]
        [HttpDelete]
        public int deleteBOHOByObjs([FromUri]string project, [FromBody]BOHO model)
        {
            var repo = RepositoryForServer<BOHO>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取地理空间数据云DEM对象
        /// </summary>
        [Route("cdem")]
        [HttpGet]
        public CDEM getCDEMById(string project, int id)
        {
            var repo = RepositoryForServer<CDEM>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取地理空间数据云DEM列表
        /// </summary>
        [Route("cdem")]
        [HttpGet]
        public List<CDEM> getCDEMByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<CDEM>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加地理空间数据云DEM对象
        /// </summary>
        [Route("cdem")]
        [HttpPut]
        public CDEM putCDEMByObjs([FromUri]string project, [FromBody]CDEM model)
        {
            var repo = RepositoryForServer<CDEM>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除地理空间数据云DEM对象
        /// </summary>
        [Route("cdem")]
        [HttpDelete]
        public int deleteCDEMByObjs([FromUri]string project, [FromBody]CDEM model)
        {
            var repo = RepositoryForServer<CDEM>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取等高线对象
        /// </summary>
        [Route("cont")]
        [HttpGet]
        public CONT getCONTById(string project, int id)
        {
            var repo = RepositoryForServer<CONT>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取等高线列表
        /// </summary>
        [Route("cont")]
        [HttpGet]
        public List<CONT> getCONTByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<CONT>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加等高线对象
        /// </summary>
        [Route("cont")]
        [HttpPut]
        public CONT putCONTByObjs([FromUri]string project, [FromBody]CONT model)
        {
            var repo = RepositoryForServer<CONT>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除等高线对象
        /// </summary>
        [Route("cont")]
        [HttpDelete]
        public int deleteCONTByObjs([FromUri]string project, [FromBody]CONT model)
        {
            var repo = RepositoryForServer<CONT>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取物探数据表对象
        /// </summary>
        [Route("gepr")]
        [HttpGet]
        public GEPR getGEPRById(string project, int id)
        {
            var repo = RepositoryForServer<GEPR>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取物探数据表列表
        /// </summary>
        [Route("gepr")]
        [HttpGet]
        public List<GEPR> getGEPRByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<GEPR>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加物探数据表对象
        /// </summary>
        [Route("gepr")]
        [HttpPut]
        public GEPR putGEPRByObjs([FromUri]string project, [FromBody]GEPR model)
        {
            var repo = RepositoryForServer<GEPR>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除物探数据表对象
        /// </summary>
        [Route("gepr")]
        [HttpDelete]
        public int deleteGEPRByObjs([FromUri]string project, [FromBody]GEPR model)
        {
            var repo = RepositoryForServer<GEPR>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取压水试验记录表对象
        /// </summary>
        [Route("hftr")]
        [HttpGet]
        public HFTR getHFTRById(string project, int id)
        {
            var repo = RepositoryForServer<HFTR>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取压水试验记录表列表
        /// </summary>
        [Route("hftr")]
        [HttpGet]
        public List<HFTR> getHFTRByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<HFTR>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加压水试验记录表对象
        /// </summary>
        [Route("hftr")]
        [HttpPut]
        public HFTR putHFTRByObjs([FromUri]string project, [FromBody]HFTR model)
        {
            var repo = RepositoryForServer<HFTR>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除压水试验记录表对象
        /// </summary>
        [Route("hftr")]
        [HttpDelete]
        public int deleteHFTRByObjs([FromUri]string project, [FromBody]HFTR model)
        {
            var repo = RepositoryForServer<HFTR>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取抽水试验记录表对象
        /// </summary>
        [Route("putr")]
        [HttpGet]
        public PUTR getPUTRById(string project, int id)
        {
            var repo = RepositoryForServer<PUTR>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取抽水试验记录表列表
        /// </summary>
        [Route("putr")]
        [HttpGet]
        public List<PUTR> getPUTRByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<PUTR>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加抽水试验记录表对象
        /// </summary>
        [Route("putr")]
        [HttpPut]
        public PUTR putPUTRByObjs([FromUri]string project, [FromBody]PUTR model)
        {
            var repo = RepositoryForServer<PUTR>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除抽水试验记录表对象
        /// </summary>
        [Route("putr")]
        [HttpDelete]
        public int deletePUTRByObjs([FromUri]string project, [FromBody]PUTR model)
        {
            var repo = RepositoryForServer<PUTR>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取研究区DEM对象
        /// </summary>
        [Route("sdem")]
        [HttpGet]
        public SDEM getSDEMById(string project, int id)
        {
            var repo = RepositoryForServer<SDEM>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取研究区DEM列表
        /// </summary>
        [Route("sdem")]
        [HttpGet]
        public List<SDEM> getSDEMByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<SDEM>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加研究区DEM对象
        /// </summary>
        [Route("sdem")]
        [HttpPut]
        public SDEM putSDEMByObjs([FromUri]string project, [FromBody]SDEM model)
        {
            var repo = RepositoryForServer<SDEM>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除研究区DEM对象
        /// </summary>
        [Route("sdem")]
        [HttpDelete]
        public int deleteSDEMByObjs([FromUri]string project, [FromBody]SDEM model)
        {
            var repo = RepositoryForServer<SDEM>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取研究区卫星图对象
        /// </summary>
        [Route("ssat")]
        [HttpGet]
        public SSAT getSSATById(string project, int id)
        {
            var repo = RepositoryForServer<SSAT>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取研究区卫星图列表
        /// </summary>
        [Route("ssat")]
        [HttpGet]
        public List<SSAT> getSSATByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<SSAT>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加研究区卫星图对象
        /// </summary>
        [Route("ssat")]
        [HttpPut]
        public SSAT putSSATByObjs([FromUri]string project, [FromBody]SSAT model)
        {
            var repo = RepositoryForServer<SSAT>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除研究区卫星图对象
        /// </summary>
        [Route("ssat")]
        [HttpDelete]
        public int deleteSSATByObjs([FromUri]string project, [FromBody]SSAT model)
        {
            var repo = RepositoryForServer<SSAT>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取隧址区DEM对象
        /// </summary>
        [Route("tdem")]
        [HttpGet]
        public TDEM getTDEMById(string project, int id)
        {
            var repo = RepositoryForServer<TDEM>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取隧址区DEM列表
        /// </summary>
        [Route("tdem")]
        [HttpGet]
        public List<TDEM> getTDEMByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<TDEM>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加隧址区DEM对象
        /// </summary>
        [Route("tdem")]
        [HttpPut]
        public TDEM putTDEMByObjs([FromUri]string project, [FromBody]TDEM model)
        {
            var repo = RepositoryForServer<TDEM>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除隧址区DEM对象
        /// </summary>
        [Route("tdem")]
        [HttpDelete]
        public int deleteTDEMByObjs([FromUri]string project, [FromBody]TDEM model)
        {
            var repo = RepositoryForServer<TDEM>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取隧址区卫星图对象
        /// </summary>
        [Route("tsat")]
        [HttpGet]
        public TSAT getTSATById(string project, int id)
        {
            var repo = RepositoryForServer<TSAT>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取隧址区卫星图列表
        /// </summary>
        [Route("tsat")]
        [HttpGet]
        public List<TSAT> getTSATByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<TSAT>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加隧址区卫星图对象
        /// </summary>
        [Route("tsat")]
        [HttpPut]
        public TSAT putTSATByObjs([FromUri]string project, [FromBody]TSAT model)
        {
            var repo = RepositoryForServer<TSAT>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除隧址区卫星图对象
        /// </summary>
        [Route("tsat")]
        [HttpDelete]
        public int deleteTSATByObjs([FromUri]string project, [FromBody]TSAT model)
        {
            var repo = RepositoryForServer<TSAT>.GetInstance(project);
            return repo.Delete(model).Result;
        }
        /// <summary>
        /// 根据id获取分水岭对象
        /// </summary>
        [Route("wash")]
        [HttpGet]
        public WASH getWASHById(string project, int id)
        {
            var repo = RepositoryForServer<WASH>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取分水岭列表
        /// </summary>
        [Route("wash")]
        [HttpGet]
        public List<WASH> getWASHByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<WASH>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加分水岭对象
        /// </summary>
        [Route("wash")]
        [HttpPut]
        public WASH putWASHByObjs([FromUri]string project, [FromBody]WASH model)
        {
            var repo = RepositoryForServer<WASH>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除分水岭对象
        /// </summary>
        [Route("wash")]
        [HttpDelete]
        public int deleteWASHByObjs([FromUri]string project, [FromBody]WASH model)
        {
            var repo = RepositoryForServer<WASH>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取注水试验记录表对象
        /// </summary>
        [Route("witr")]
        [HttpGet]
        public WITR getWITRById(string project, int id)
        {
            var repo = RepositoryForServer<WITR>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取注水试验记录表列表
        /// </summary>
        [Route("witr")]
        [HttpGet]
        public List<WITR> getWITRByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<WITR>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加注水试验记录表对象
        /// </summary>
        [Route("witr")]
        [HttpPut]
        public WITR putWITRByObjs([FromUri]string project, [FromBody]WITR model)
        {
            var repo = RepositoryForServer<WITR>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除注水试验记录表对象
        /// </summary>
        [Route("witr")]
        [HttpDelete]
        public int deleteWITRByObjs([FromUri]string project, [FromBody]WITR model)
        {
            var repo = RepositoryForServer<WITR>.GetInstance(project);
            return repo.Delete(model).Result;
        }

        /// <summary>
        /// 根据id获取水源保护区对象
        /// </summary>
        [Route("wspa")]
        [HttpGet]
        public WSPA getWSPAById(string project, int id)
        {
            var repo = RepositoryForServer<WSPA>.GetInstance(project);
            return repo.Retrieve(id).Result;
        }
        /// <summary>
        /// 根据对象组获取水源保护区列表
        /// </summary>
        [Route("wspa")]
        [HttpGet]
        public List<WSPA> getWSPAByObjs(string project, string filter)
        {
            var repo = RepositoryForServer<WSPA>.GetInstance(project);
            return repo.RetrieveByObjs(0, filter).Result;
        }

        /// <summary>
        /// 增加水源保护区对象
        /// </summary>
        [Route("wspa")]
        [HttpPut]
        public WSPA putWSPAByObjs([FromUri]string project, [FromBody]WSPA model)
        {
            var repo = RepositoryForServer<WSPA>.GetInstance(project);
            return repo.Create(model).Result;
        }

        /// <summary>
        /// 删除水源保护区对象
        /// </summary>
        [Route("wspa")]
        [HttpDelete]
        public int deleteWSPAByObjs([FromUri]string project, [FromBody]WSPA model)
        {
            var repo = RepositoryForServer<WSPA>.GetInstance(project);
            return repo.Delete(model).Result;
        }
    }
}
