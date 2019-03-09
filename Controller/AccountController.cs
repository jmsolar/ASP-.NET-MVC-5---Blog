using Futbolizando_Fútbol_Blog.Data.Repositories;
using Futbolizando_Fútbol_Blog.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Configuration;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Futbolizando_Fútbol_Blog.Controllers
{
    public class AccountController : BaseController
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private RepositoryProfileManager _repositoryProfileManager;

        //
        // Constructor: AccountController
        public AccountController() => _repositoryProfileManager = new RepositoryProfileManager();

        //
        // Constructor: AccountController(userManager, signInManager)
        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        //
        // Account/SignInManager
        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }

            private set
            {
                _signInManager = value;
            }

        }

        //
        // /Account/UserManager
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }        
		
		//
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { result = "Error", msg = "Verifique los datos ingresados" });
            }
            var user = await UserManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Ud no esta autorizado para iniciar sesión. Contactese con el administrador");
                return Json(new { result = "Error", msg = "Ud no esta autorizado para iniciar sesión. Contactese con el administrador" });
            }
            else
            {
                if (model.Email == user.Email && model.Username == user.UserName)
                {
                    var result = await SignInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, shouldLockout: true);
                    switch (result)
                    {
                        case SignInStatus.Success:
                            user.LastDateLogin = user.CurrentDateLogin;
                            user.CurrentDateLogin = System.DateTime.Now;
                            await UserManager.UpdateAsync(user);
                            return Json(new { result = "Redirect", url = Url.Action("Index", "Manage") });
                        case SignInStatus.LockedOut:
                            return Json(new { result = "Redirect", url = Url.Action("Lockout", "Account") });
                        case SignInStatus.RequiresVerification:
                            return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                        case SignInStatus.Failure:
                        default:
                            ModelState.AddModelError("", "Intento de inicio de sesión no válido. Verifique los datos ingresados");
                            return Json(new { result = "Error", msg = "Intento de inicio de sesión no válido" });
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Intento de inicio de sesión no válido. Verifique los datos ingresados");
                    return Json(new { result = "Error", msg = "Intento de inicio de sesión no válido" });
                }
            }
        }
	}
}