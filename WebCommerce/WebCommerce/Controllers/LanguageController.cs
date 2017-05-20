using Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebCommerce.Controllers
{
    
    public class LanguageController : Controller
    {
        ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }


        //
        // GET: /Language/
        public ActionResult Index()
        {
            ViewBag.LanguageCodes = _languageService.GetAll().ToList();
            return View();
        }

        public ActionResult Change(String languageAbbrevation)
        {
            if (languageAbbrevation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(languageAbbrevation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageAbbrevation);
            }
            HttpCookie cookie = new HttpCookie("Language");

            cookie.Value = languageAbbrevation;
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index");
        }


	}
}