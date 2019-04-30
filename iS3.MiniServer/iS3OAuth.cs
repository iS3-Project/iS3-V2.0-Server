using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using System.Net.Http;
using System.Web;
using Microsoft.Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using iS3.Core;

/*
 * This file defines iS3 user account authentication and authorization classes.
 * 
 * 1. iS3User and iS3UserManager for account control
 * 2. iS3OAuthServerProvider for provding authenticaiton service
 * 3. iS3OAuthDbContext and iS3OAuthDbInitializer for managing accounts in database
 * 4. AccountsController for providing account control WebAPI
 * 
 * Account api usage examples in ubuntu-linux shell:
 * 
port=8080
curl http://localhost:$port/api/Accounts/GetUsers    
    [=>will be refused]
curl -d 'grant_type=password&username=Admin&password=iS3Admin' http://localhost:$port/Token
    [=>will return token for Admin]
token1=$[token from above responses]
curl -H "Authorization:Bearer $token1" http://localhost:$port/api/Accounts/GetUsers
    [=>will succeeded, 1 user]
curl -d "Username=lxj&Password=lxjsPassword&ConfirmPassword=lxjsPassword&Role=User" -H "Authorization:Bearer $token1" http://localhost:$port/api/Accounts/AddUser
    [=>will succeeded, 1 user added]
curl -H "Authorization:Bearer $token1" http://localhost:$port/api/Accounts/GetUsers
    [=>will succeeded, 2 users]
curl -d "Username=lxj" -H "Authorization:Bearer $token1" http://localhost:$port/api/Accounts/RemoveUser
    [=>will succeeded, 1 user removed]
curl -d '{"Username":"lxj","Password":"lxjsPassword", "ConfirmPassword":"lxjsPassword", "Role":"User"}' -H "Content-Type:application/json" -H "Authorization:Bearer $token1" http://localhost:$port/api/Accounts/AddUser 
     [=>will fail, user exists]
curl -d 'grant_type=password&Username=lxj&Password=lxjsPassword' http://localhost:$port/Token
     [=>will return token for lxj]
token2=$[token from above responses]
curl -H "Authorization:Bearer $token2" http://localhost:$port/api/Accounts/GetUsers
     [=>will be denied because for insufficient authorization]
curl -H "Authorization:Bearer $token1" http://localhost:$port/api/Accounts/GetUsers 
     [=>will succeeded, 2 users]
curl -H "Authorization:Bearer $token2" -d "OldPassword=lxjsPassword&Password=NewPassword&ConfirmPassword=NewPassword" http://localhost:$port/api/Accounts/ChangePassword
     [=>will succeeded, password changed (for lxj)]
* 
*/

namespace iS3.MiniServer
{
    public static class iS3ClaimTypes
    {
        public const string RolesInDomain = "iS3RolesInDomain";
        public const string RolesInProject = "iS3RolesInProject";
    }

    // iS3LoginUser class is only for login purposes.
    // The password is never stored explicitly, and can never be visited
    //   other than login process.
    // 
    public class iS3LoginUser
    {
        // Password and Role is for admin to register new user remotely.
        // For example, we can register a new user
        //   UserName=john, Password=johnsPassword, ConfirmPassword=johnsPassword, Role=User
        // using following command remotely:
        //
        //   curl -d "Username=john&Password=johnsPassword&ConfirmPassword=johnsPassword&Role=User" 
        //        -H "Authorization:Bearer $token" http://$ip:$port/api/Accounts/AddUser
        //
        // In above, we use the 'curl' command. $ip is the address of host, $port
        //   is the host port, $token is the token of a user with Admin role.
        //
        // In our default context(see iS3OAuthDbInitializer.Seed), a user with the
        // Admin role is created as:
        //   Username=Admin, Password=iS3Admin, Role=Admin
        //
        // Therefore, you can login as the Admin user use the following command.
        // The server will return a token.
        //
        //   curl -d "grant_type=password&username=Admin&password=iS3Admin"
        //        http://$ip:$port/Token
        //

        // account information
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string OldPassword { get; set; }

        // Role: admin, user
        public string Role { get; set; }

        // Roles that a user claims (or is claimed) in a domain.
        // It should be filled with json format, such as:
        //   [
        //     {"DomainName":"domain1", "RolesInDomain","read;write;edit;delete"},
        //     {"DomainName":"domain2", "RolesInDomain","read"}
        //   ]
        //
        public string ClaimedRolesInDomains { get; set; }

        // Roles that a user claims (or is claimed) in a project.
        // It should be filled with json format, such as:
        //   [
        //     {"ProjectName":"project1", "RolesInProject","read;write;edit;delete"},
        //     {"ProjectName":"project2", "RolesInProject","read"}
        //   ]
        //
        public string ClaimedRolesInProjects { get; set; }
    }

    // iS3IdentityUser class is for user authentication.
    // iS3IdentityUser class inherits from Microsoft.AspNet.IdentityUser.
    // 
    public class iS3IdentityUser : IdentityUser
    {
        public iS3IdentityUser() : base() { }
        public iS3IdentityUser(string userName) : base(userName) { }
    }

    // iS3UserManager class is for user management.
    // iS3UserManager class inherits from Microsoft.AspNet.UserManager.
    // 
    public class iS3UserManager : UserManager<iS3IdentityUser>
    {
        public iS3UserManager(IUserStore<iS3IdentityUser> store)
            : base(store) { }

        public static iS3UserManager Create(
            IdentityFactoryOptions<iS3UserManager> options,
            IOwinContext context)
        {
            var tempcontext = context.Get<iS3OAuthDbContext>();
            return new iS3UserManager(
                new UserStore<iS3IdentityUser>(
                    tempcontext));
        }
    }

    // iS3OAuthServerProvider class is for the authentication.
    // iS3OAuthServerProvider class inherits from Microsoft.Owin.Security.OAuth.
    // 
    public class iS3OAuthServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(
            OAuthValidateClientAuthenticationContext context)
        {
            // This call is required...
            // but we're not using client authentication, so validate and move on...
            await Task.FromResult(context.Validated());
        }


        public override async Task GrantResourceOwnerCredentials(
            OAuthGrantResourceOwnerCredentialsContext context)
        {
            // ** Use extension method to get a reference to the user manager from the Owin Context:
            var manager = context.OwinContext.GetUserManager<iS3UserManager>();
            var user = await manager.FindAsync(context.UserName, context.Password);
            if (user == null)
            {
                if (context.UserName == "Admin")
                {
                    var admin = new iS3IdentityUser("Admin");
                    var result = await manager.CreateAsync(admin, "iS3Admin");
                    // Add claims for Admin
                    await manager.AddClaimAsync(admin.Id,
                                    new Claim(ClaimTypes.Name, "Admin"));

                    await manager.AddClaimAsync(admin.Id,
                        new Claim(ClaimTypes.Role, "Admin"));
                    user = await manager.FindAsync(context.UserName, context.Password);
                    await context.OwinContext.Get<iS3OAuthDbContext>().SaveChangesAsync();
                }
                else
                {
                    context.SetError(
                        "invalid_grant", "The user name or password is incorrect.");
                    context.Rejected();
                    return;
                }
            }                  
            // UserManager allows us to retrieve use with name/password combo:            
            // Add claims associated with this user to the ClaimsIdentity object:
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            foreach (var userClaim in user.Claims)
            {
                identity.AddClaim(new Claim(userClaim.ClaimType, userClaim.ClaimValue));
            }

            context.Validated(identity);
        }
    }

    // iS3OAuthDbContext class is for authentication database management.
    // iS3OAuthDbContext class inherits from Microsoft.AspNet.Identity.EntityFramework.
    // Note:
    //   A default database (MiniServer.DefaultDatabase) will be created using
    //     default EntityFramework database service provider 
    //     - SqlCeProviderServices (SqlServerCe).
    // 
    public class iS3OAuthDbContext : IdentityDbContext<iS3IdentityUser>
    {
        // The default database is specified here.
        //
        public iS3OAuthDbContext()
            : base(iS3.Core.MiniServer.DefaultDatabase)
        {
            // this.Configuration.LazyLoadingEnabled = false ;
        }

        // Set database initializer, which will seed default Admin user.
        //
        static iS3OAuthDbContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<iS3OAuthDbContext>());

        }

        // Create an instance of iS3OAuthDbContext for gloabl usage.
        // You can get the instance using:
        //    var context = Request.GetOwinContext().Get<iS3OAuthDbContext>();
        //
        public static iS3OAuthDbContext Create()
        {
            return new iS3OAuthDbContext();
        }
    }


   

    // AccountsController class is for managing user accounts remotely using WebAPI.
    // To this point, we provide the following WebAPIs：
    //   api/Accounts/GetUsers
    //   api/Accounts/GetUsersFullInfo
    //   api/Accounts/AddUser
    //   api/Accounts/RemoveUser
    //   api/Accounts/ChangePassword
    //
    // Note:
    //   These WebAPIs can only be invoked by an authorized user, and Admin role 
    //     is required to invoke:
    //        api/Accounts/GetUsers
    //        api/Accounts/GetUsersFullInfo
    //        api/Accounts/AddUser
    //        api/Accounts/RemoveUser
    // 
    [RoutePrefix("api/Accounts")]
    [Authorize]
    public class AccountsController : ApiController
    {
        // Get the globle install of iS3OAuthDbContext class.
        //
        iS3OAuthDbContext dbContext
        {
            get
            {
                return Request.GetOwinContext().Get<iS3OAuthDbContext>();
            }
        }

        [HttpGet]
        [Route("GetUsers")]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult GetUsers()
        {
            List<string> names = new List<string>();
            foreach (var user in dbContext.Users)
                names.Add(user.UserName);
            return Ok(names);
            
        }

        [HttpGet]
        [Route("GetUsersFullInfo")]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult GetUsersFullInfo()
        {
            return Ok(dbContext.Users);
        }

        [HttpPost]
        [Route("AddUser")]
        [Authorize(Roles = "Admin")]
        // Add a new user according to:
        //      UserName, Password, Role
        //
        public async Task<IHttpActionResult> AddUser(iS3LoginUser loginUser)
        {
            if (loginUser == null)
            {
                return BadRequest("Argument Null");
            }
            if (loginUser.Password != loginUser.ConfirmPassword)
            {
                return BadRequest("Password not consistent");
            }

            string password = loginUser.Password;
            // Erase the password for safety.
            loginUser.Password = null;
            loginUser.ConfirmPassword = null;

            var userExists = await dbContext.Users.AnyAsync(c => c.UserName == loginUser.UserName);

            if (userExists)
            {
                //var exist = await dbContext.Users.FirstAsync(c => c.UserName == user.UserName);
                return BadRequest("User already exists");
            }

            var manager = new iS3UserManager(new UserStore<iS3IdentityUser>(dbContext));

            var user = new iS3IdentityUser(loginUser.UserName);

            var result = await manager.CreateAsync(user, password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors.FirstOrDefault());
            }

            await manager.AddClaimAsync(user.Id,
                new Claim(ClaimTypes.Name, loginUser.UserName));

            await manager.AddClaimAsync(user.Id,
                new Claim(ClaimTypes.Role, loginUser.Role));

            // add a claim to Identity.Claims
            //   Claim.Type = iS3ClaimTypes.AuthorizedProjects,
            //   Claim.Value = user.AuthorizedProjects
            //
            //await manager.AddClaimAsync(user.Id,
            //    new Claim(iS3ClaimTypes.AuthorizedProjects, loginUser.AuthorizedProjects));

            await dbContext.SaveChangesAsync();

            string success = string.Format("User {0} created successfully.", loginUser.UserName);

            return Ok(success);
        }

        [HttpPost]
        [Route("RemoveUser")]
        [Authorize(Roles = "Admin")]
        // Remove a new user according to:
        //      UserName
        // Note: This operation cannot be recovered.
        //
        public async Task<IHttpActionResult> RemoveUser(iS3LoginUser loginUser)
        {
            if (loginUser == null)
            {
                return BadRequest("Argument Null");
            }
            var user = await dbContext.Users.FirstOrDefaultAsync(c => c.UserName == loginUser.UserName);

            if (user == null)
            {
                return BadRequest("User does not exists");
            }

            var userName = RequestContext.Principal.Identity.GetUserName();
            if (string.Compare(loginUser.UserName, userName, true) == 0)
            {
                return BadRequest("Cannot remove self");
            }

            dbContext.Users.Remove(user);
            await dbContext.SaveChangesAsync();

            string success = string.Format("User {0} removed successfully.", loginUser.UserName);
            return Ok(success);
        }

        [HttpPost]
        [Route("ChangePassword")]
        // Change password of current user, the following three passwords should be provided.
        //      OldPassword, Password, ConfirmPassword
        // Note: This operation cannot be recovered.
        //
        public async Task<IHttpActionResult> ChangePassword(iS3LoginUser loginUser)
        {
            if (loginUser == null)
            {
                return BadRequest("Argument Null");
            }
            if (loginUser.OldPassword == null || loginUser.OldPassword.Length == 0)
            {
                return BadRequest("Old password could not be empty");
            }
            if (loginUser.Password != loginUser.ConfirmPassword)
            {
                return BadRequest("Password not consistent");
            }

            var userName = RequestContext.Principal.Identity.GetUserName();
            var user = await dbContext.Users.FirstAsync(c => c.UserName == userName);
            var userID = user.Id;

            var manager = Request.GetOwinContext().GetUserManager<iS3UserManager>();
            var result = await manager.ChangePasswordAsync(userID, loginUser.OldPassword, loginUser.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors.FirstOrDefault());
            }

            await dbContext.SaveChangesAsync();
            return Ok("Password changed");
        }

        [HttpPost]
        [Route("SetRolesInArea")]
        [Authorize(Roles = "Admin")]
        public async Task<IHttpActionResult> SetRolesInArea(iS3RolesInArea rolesInArea)
        {
            if (rolesInArea == null)
            {
                return BadRequest("Argument Null");
            }
            var user = await dbContext.Users.FirstOrDefaultAsync(c => c.UserName == rolesInArea.UserName);

            if (user == null)
            {
                return BadRequest("User does not exists");
            }

            var manager = new iS3UserManager(new UserStore<iS3IdentityUser>(dbContext));
            var claims = await manager.GetClaimsAsync(user.Id);
            bool exist = claims.Any(c => c.Type == rolesInArea.AreaName);

            Claim claim = null;
            IdentityResult result = null;
            if (exist)
            {
                claim = claims.FirstOrDefault(c => c.Type == rolesInArea.AreaName);
                result = await manager.RemoveClaimAsync(user.Id, claim);
            }
            claim = new Claim(rolesInArea.AreaName, rolesInArea.Roles);
            result = await manager.AddClaimAsync(user.Id, claim);

            await dbContext.SaveChangesAsync();
            return Ok("Roles in domain set");
        }
    }
}
