using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using iS3.Core;

/*
 * This file defines iS3 Territory WebAPI, which can be visited through
 *   api/Territories/[api name]
 *   
 * The class defined are:
 *   iS3SimpleTerritory: nothing but a simple territory
 *   iS3TerritoryDbContext: database context
 *   TerritoriesController: Territory WebAPI Controller
 * 
 */

namespace iS3.Core
{
    public class iS3SimpleTerritory : iS3Territory
    {
        public iS3SimpleTerritory(iS3TerritoryHandle handle) : base(handle)
        {
        }
    }

    public class iS3TerritoryDbContext : DbContext
    {
        public iS3TerritoryDbContext(string dbName) :
            base(dbName)
        {
            //Database.SetInitializer<iS3TerritoryDbContext>(new CreateDatabaseIfNotExists<iS3TerritoryDbContext>());
            //Database.SetInitializer<iS3TerritoryDbContext>(new DropCreateDatabaseIfModelChanges<iS3TerritoryDbContext>());
            Database.SetInitializer<iS3TerritoryDbContext>(new DropCreateDatabaseAlways<iS3TerritoryDbContext>());
        }

    }

    /*
     * TerritoriesController is a WebAPI class for managing territories.
     * We provide the following WebAPIs：
     *     api/Territories/SupportedTerritories
     *     api/Territories/SupportedDomains
     *     api/Territories/SupportedProjects
     *     api/Territories/GetAllTerritoryHandles
     *     api/Territories/GetTerritoryHandle
     *     api/Territories/GetDomainHandle
     *     api/Territories/AddTerritory
     *     api/Territories/AddDomain
     * As a test to the WebAPI, here are examples in ubuntu-linux shell:
     * 
port=8080
curl -d 'grant_type=password&username=Admin&password=iS3Admin' http://localhost:$port/Token
    [=>will return token for Admin]
token1=$[token from above responses]
curl -H "Authorization:Bearer $token1" http://localhost:$port/api/Territories/SupportedTerritories
    [=>will return supported territory types]
curl -H "Authorization:Bearer $token1" http://localhost:$port/api/Territories/SupportedDomains
    [=>will return supported domain types]
curl -H "Authorization:Bearer $token1" -d "Name=Shanghai&DbName=Shanghai&Type=iS3.MiniServer.iS3SimpleTerritory" http://localhost:$port/api/Territories/AddTerritory
    [=>will return added territory handle]
curl -H "Authorization:Bearer $token1" -d "Name=Geology&ParentID=Shanghai&Type=iS3.MiniServer.iS3Geology" http://localhost:$port/api/Territories/AddDomain
    [=>will return added domain handle]
curl -H "Authorization:Bearer $token1" http://localhost:$port/api/Territories/GetTerritoryHandle?nameOrID=Shanghai
    [=>will return requested territory handle]
curl -H "Authorization:Bearer $token1" http://localhost:$port/api/Territories/GetDomainHandle?nameOrID=Geology\&parentNameOrID=Shanghai
    [=>will return requested domain handle]
     *
     * 
     */
    [RoutePrefix("api/Territories")]
    [Authorize(Roles = "Admin")]
    public class TerritoriesController : ApiController
    {
        [HttpGet]
        [Route("SupportedTerritories")]
        public ICollection<string> SupportedTerritories()
        {
            ICollection<string> result = MiniServer.GetSubClasses<iS3Territory>();
            return result;
        }

        [HttpGet]
        [Route("SupportedDomains")]
        public ICollection<string> SupportedDomains()
        {
            ICollection<string> result = MiniServer.GetSubClasses<iS3Domain>();
            return result;
        }

        [HttpGet]
        [Route("SupportedProjects")]
        public ICollection<string> SupportedProjects()
        {
            ICollection<string> result = MiniServer.GetSubClasses<iS3Project>();
            return result;
        }

        [HttpGet]
        [Route("GetAllTerritoryHandles")]
        public async Task<IHttpActionResult> GetAllTerritoryHandles()
        {
            ICollection<iS3TerritoryHandle> result = null;
            result = await MiniServer.GetAllTerritoryHandles();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetTerritoryHandle")]
        public async Task<IHttpActionResult> GetTerritoryHandle(string nameOrID)
        {
            if (nameOrID == null)
            {
                return BadRequest("Argument Null");
            }

            iS3TerritoryHandle result = null;
            result = await MiniServer.getTerritoryHandle(nameOrID);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetDomainHandle")]
        public async Task<IHttpActionResult> GetDomainHandle(string nameOrID, string parentNameOrID)
        {
            if (nameOrID == null)
            {
                return BadRequest("Argument Null");
            }

            iS3DomainHandle result = null;
            result = await MiniServer.GetDomainHandle(nameOrID, parentNameOrID);
            return Ok(result);
        }


        [HttpPost]
        [Route("AddTerritory")]
        public async Task<IHttpActionResult> AddTerritory(iS3TerritoryHandle handle)
        {
            if (handle == null)
            {
                return BadRequest("Argument Null");
            }

            iS3TerritoryHandle newHandle = await MiniServer.AddTerritory(handle);

            return Ok(newHandle);
        }

        [HttpPost]
        [Route("AddDomain")]
        public async Task<IHttpActionResult> AddDomain(iS3DomainHandle handle)
        {
            if (handle == null)
            {
                return BadRequest("Argument Null");
            }

            iS3DomainHandle newHandle = await MiniServer.AddDomain(handle);       

            return Ok(newHandle);
        }


    }


}
