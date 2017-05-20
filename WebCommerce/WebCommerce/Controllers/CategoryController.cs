//using Service;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Web;
//using System.Web.Mvc;

//namespace WebCommerce.Controllers
//{
//    public class CategoryController : BaseController
//    {
//        readonly ICategoryService _categoryService;
//        public CategoryController(ICategoryService categoryService)
//            : base()
//        {
//            _categoryService = categoryService;
//        }
//        //
//        // GET: /Category/
//        public async Task<ActionResult> Index(int catId)
//        {
//            ViewBag.Category = _categoryService.GetCategoryViewModelById(catId);
//            ActionResult view = await base.CreateViewForUser();
//            return view;
//        }
//    }
//}