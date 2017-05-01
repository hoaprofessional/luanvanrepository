using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCommerce.App_LocalResources;

namespace WebCommerce.Controllers
{
    public class HomeController : Controller
    {
        IUserService _userService;
        private IDemoService _demoService;

        public HomeController(IDemoService demoService, IUserService userService)
        {
            _demoService = demoService;
            _userService = userService;
        }

        public ActionResult Index()
        {
       //     _demoService.Add(new Model.Demo() { Name = "Hung " });
       //     _demoService.Save();
            
            //Stopwatch time1, time2;
            //time1 = new Stopwatch();
            //time2 = new Stopwatch();

            //int loop = 10;

            //_userService.GetUsersByRoleName2("Admin");

            //time1.Start();
            //for(int i=0;i<loop;i++)
            //{
            //    var s = _userService.GetUsersByRoleName2("Admin");
            //}
            //time1.Stop();

            //time2.Start();
            //for (int i = 0; i < loop; i++)
            //{
            //    var s = _userService.GetUsersByRoleName("Admin");
            //}
            //time2.Stop();


            ViewBag.Title = GlobalRes.HomePageTitle;
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