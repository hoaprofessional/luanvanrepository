using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModel;

namespace WebCommerce.Controllers.api
{
    public class MenuApiController : ApiController
    {
        IMenuService _menuService;
        public MenuApiController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        // GET api/<controller>
        public List<MenuViewModel> Get()
        {
            return _menuService.GetAllMenu();
        }

    }
}