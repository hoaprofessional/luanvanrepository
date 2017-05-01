using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCommerce.Controllers
{
    public class PhanSoController : Controller
    {
        IPhanSoService _phanSoService;
        public PhanSoController(IPhanSoService phanSoService)
        {
            _phanSoService = phanSoService;
        }
        //
        // GET: /PhanSo/
        public ActionResult Index()
        {
            ViewBag.PhanSos = _phanSoService.GetAll().ToList();
            return View();
        }
	}
}