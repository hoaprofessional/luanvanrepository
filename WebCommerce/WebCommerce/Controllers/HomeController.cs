using Service;
using System.Web.Mvc;
using System.Threading.Tasks;
using Service.Home;

namespace WebCommerce.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }


        public async Task<ActionResult> Index()
        {
            ActionResult view = await base.CreateViewForUser();
            ViewBag.Categories = _homeService.GetCategories();
            ViewBag.Top10Topics = _homeService.GetTop10Topics();
            ViewBag.LastestTopics = _homeService.GetLastestTopics();
            ViewBag.TopSellers = _homeService.GetTopBonuSellerViewModels();
            return view;
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