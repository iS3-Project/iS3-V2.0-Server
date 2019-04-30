using iS3.Core;
using iS3.Core.Model;
using iS3.Core.Server;
using iS3.Core.Server.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Http;

namespace iS3.MiniServer
{
    /// <summary>
    /// 工程基础数据相关接口
    /// </summary>
    [RoutePrefix("api/project")]
    public class ProjectController : ApiController
    {

        /// <summary>
        /// 获取工程列表
        /// </summary>
        /// <returns></returns>
        [Route("projectlocation")]
        [HttpGet]
        [Authorize]
        public List<ProjectLocation> GetProjectDefList()
        {
            var repo = RepositoryForServer<ProjectLocation>.GetInstance("iS3Db");
            return repo.RetrieveAll().Result;
        }
        /// <summary>
        /// 根据code查询工程定义信息
        /// </summary>
        /// <returns></returns>
        [Route("projectlocation")]
        [HttpGet]
        public ProjectLocation GetProjectDefByCode(string code)
        {
            var repo = RepositoryForServer<ProjectLocation>.GetInstance("iS3Db");
            var result = (repo.context as CoreContext).ProjectLocation.Where(x => x.CODE == code).FirstOrDefault();
            return result;
        }
    }
}