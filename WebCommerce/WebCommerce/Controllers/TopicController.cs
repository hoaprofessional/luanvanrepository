//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Model;
//using Service;
//using ViewModel;
//using ViewModel.Topic;

//namespace WebCommerce.Controllers
//{
//    public class TopicController : Controller
//    {
//        private readonly ITopicService _topicService;
//        private readonly ICategoryService _categoryService;
//        public TopicController(ITopicService topicService, ICategoryService categoryService)
//        {
//            _topicService = topicService;
//            _categoryService = categoryService;
//        }

//        //
//        // GET: /Topic/
//        public ActionResult Index(int catId)
//        {
//            CategoryViewModel category = _categoryService.GetCategoryViewModelById(catId);
//            if (category == null)
//            {
//                //TODO add not found here
//            }
//            List<TopicListViewModel> topicListViewModels = _topicService.GetTopicListViewModelsByCatId(catId);
//            ViewBag.Topics = topicListViewModels;
//            ViewBag.Category = category;
//            return View();
//        }
//    }
//}