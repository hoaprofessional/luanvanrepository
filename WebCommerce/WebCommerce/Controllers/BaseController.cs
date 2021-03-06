﻿using System;
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
    public class BaseController : Controller
    {
        public BaseController()
        {
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
        public UserManager<ApplicationUser> UserManager { get; private set; }
        //
        // GET: /Base/
        public async Task<ActionResult> CreateViewForUser()
        {
            ApplicationUser loginedUser = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            ViewBag.Title = GlobalRes.HomePageTitle;
            ViewBag.LoginedUser = loginedUser;
            return View();
        }
	}
}