using Futbolizando_Fútbol_Blog.Data.Repositories;
using Futbolizando_Fútbol_Blog.Dtos;
using Futbolizando_Fútbol_Blog.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Futbolizando_Fútbol_Blog.Controllers.Api
{
    [RoutePrefix("api/accounts")]
    public class AccountsController : ApiController
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private RepositoryProfileManager _repositoryProfileManager;

        public AccountsController()
        {
            _repositoryProfileManager = new RepositoryProfileManager();
        }

        public AccountsController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get => _signInManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            private set => _signInManager = value;
        }

        public ApplicationUserManager UserManager
        {
            get => _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            private set => _userManager = value;
        }

        //
        // POST: api/accounts/accessasync
        [Route("accessasync")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> AccessAsync([FromBody] AccountDto accountDto)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, "Verifique los datos ingresados");
            }
            accountDto.ProviderPassword = "";
            var user = await UserManager.FindByEmailAsync(accountDto.Email);
            if (user == null)
            {
                return Content(HttpStatusCode.BadRequest, "Ud no esta autorizado para iniciar sesión. Contactese con el administrador");
            }
            else
            {
                if (accountDto.Email == user.Email && accountDto.Username == user.UserName)
                {
                    var result = await SignInManager.PasswordSignInAsync(accountDto.Username, accountDto.Password, false, shouldLockout: true);
                    switch (result)
                    {
                        case SignInStatus.Success:
                            user.LastDateLogin = user.CurrentDateLogin;
                            user.CurrentDateLogin = DateTime.Now;
                            await UserManager.UpdateAsync(user);
                            return Ok();
                        case SignInStatus.LockedOut:
                            return BadRequest("Lockout");
                        case SignInStatus.Failure:
                        default:
                            return Content(HttpStatusCode.BadRequest, "Intento de inicio de sesión no válido. Verifique los datos ingresados");
                    }
                }
                else
                {
                    return Content(HttpStatusCode.BadRequest, "Verifique los datos ingresados");
                }
            }
        }
    }
}
