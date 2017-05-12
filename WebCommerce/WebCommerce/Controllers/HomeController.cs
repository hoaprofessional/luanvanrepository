using Model;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCommerce.App_LocalResources;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebCommerce.Controllers
{
    public class HomeController : Controller
    {
        IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
        UserManager<ApplicationUser> UserManager;
        public async Task<ActionResult> Index()
        {
            var loginedUser = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            ViewBag.Title = GlobalRes.HomePageTitle;
            ViewBag.LoginedUser = loginedUser;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Language()
        {
            ViewBag.Message = "Your language page.";
            return View();
        }
    }
}