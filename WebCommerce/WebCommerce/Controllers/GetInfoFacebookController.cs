using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;

namespace WebCommerce.Controllers
{
    public class GetInfoFacebookController : Controller
    {
        //
        // GET: /GetInfoFacebook/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult OnClickGetInfo(String accessToken)
        {
            //Khoi tao 1 doi tuong truy van
            FacebookClient fb = new FacebookClient(accessToken);
            dynamic info = fb.Get("me?fields=id,name,birthday");
            dynamic post = fb.Get("me/posts");
            return Json(new { id = info.id, name = info.name, birthday = info.birthday, posts = post });
        }
	}
}