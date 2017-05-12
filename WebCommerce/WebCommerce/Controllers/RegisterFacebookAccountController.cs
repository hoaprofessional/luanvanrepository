using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using WebCommerce.Models;
using Model;
using Common.App_LocalResources;
using Service;
using ViewModel.AuthorizeFacebook;
using Facebook;
using Common;


namespace WebCommerce.Controllers
{
    public class RegisterFacebookAccountController : Controller
    {
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        String _password = "absdkjalds123123asdslkajd";
        IUserService _userService;
        public RegisterFacebookAccountController(IUserService userService)
        {
            _userService = userService;
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
        public UserManager<ApplicationUser> UserManager { get; private set; }
        //
        // GET: /Base/
        public ActionResult Index(String facebookTokenId,String redirectUrl)
        {
            ViewBag.FacebookTokenId = facebookTokenId;
            ViewBag.RedirectUrl = redirectUrl;
            return View();
        }
        private async Task SignInAsync(ApplicationUser user, bool isPersistent)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            var identity = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, identity);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Login(LoginFacebookViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                FacebookClient fb = new FacebookClient(model.FacebookTokenId);
                dynamic info = fb.Get("me?fields=id");
                //kiem tra user da co hay chua. username chinh la id facebook con password la co san
                var user = await UserManager.FindAsync(info.id, _password);
                //neu da co
                if (user != null)
                {
                    //dang nhap
                    await SignInAsync(user, model.RememberMe);
                    //thanh cong thi tra ve ket qua thanh cong cho client
                    return Json(new
                    {
                        result = "success",
                        message = GlobalRes.LoginSuccess
                    });
                }
                else
                {
                    //neu chua co thi tra ve ket qua khong co user ton tai cho client
                    return Json(new
                    {
                        result = "failed",
                        message = GlobalRes.NoUserExists
                    });
                }
            }
            // neu id facebook null
            return Json(new
            {
                result = "failed",
                message = GlobalRes.MessageIdFacebookNull
            });
        }
        public JsonResult FindUser(FindUserViewModel model)
        {
            FacebookClient fb = new FacebookClient(model.FacebookTokenId);
            dynamic info = fb.Get("me?fields=id");
            ApplicationUser user = _userService.GetUserByFacebookId(info.id);
            if (user != null)
            {
                return Json(new
                {
                    result = "success",
                    message = GlobalRes.UserAlreadyExists
                });
            }
            else
            {
                return Json(new
                {
                    result = "failed",
                    message = GlobalRes.NoUserExists
                });
            }
        }
        //
        // POST: /Account/LogOff
        [HttpPost]
        public JsonResult LogOff()
        {
            AuthenticationManager.SignOut();
            return Json(new {
            });
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Register(RegisterFacebookViewModel model)
        {
            if (ModelState.IsValid)
            {
                FacebookClient fb = new FacebookClient(model.FacebookTokenId);
                dynamic info = fb.Get("me?fields=id");
                ApplicationUser user = _userService.GetUserByFacebookId(info.id);
                if (user != null)
                {
                    return Json(new
                    {
                        result = "error",
                        message = GlobalRes.UserAlreadyExists,
                        errorVal=1
                    });
                }
                user = PropertyCopy.Copy<ApplicationUser, RegisterFacebookViewModel>(model);
                user.UserName = info.id;
                user.FacebookId = info.id;
                var result = await UserManager.CreateAsync(user, _password);
                if (result.Succeeded)
                {
                    return Json(new
                    {
                        result = "success",
                        message = GlobalRes.RegisterSuccess
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = "error",
                        message = "error",
                        data = "null"
                    });
                }
            }
            return Json(new
            {
                result = "error",
                message = GlobalRes.MessageIdTokenNull,
                data = "null"
            });
        }
    }
}