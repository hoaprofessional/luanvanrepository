using Common.App_LocalResources;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace WebCommerce.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private IDemoService _demoService;
        private IMenuService _menuService;
        private ICategoryService _categoryService;

        public HomeController(IDemoService demoService, IUserService userService,IMenuService menuService,ICategoryService categoryService)
        {
            _demoService = demoService;
            _userService = userService;
            _menuService = menuService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            ViewBag.Menus = _menuService.GetAllMenu();
            ViewBag.RootCategoryViewModel = _categoryService.RootCategoryViewModel();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Menus = _menuService.GetAllMenu();
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