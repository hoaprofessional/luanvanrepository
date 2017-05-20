//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web.Http;
//using System.Web.Mvc;
//using Common;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Model;
//using Service;
//using Validate;
//using ViewModel.Topic;

//namespace WebCommerce.Controllers.api
//{
//    public class TopicApiController : ApiController
//    {
//        private readonly ICategoryService _categoryService;
//        private readonly ITopicFieldValidate _topicInsertValidate;
//        private readonly ITopicService _topicService;
//        public TopicApiController(ITopicService topicService, ITopicFieldValidate topicInsertValidate, ICategoryService categoryService)
//        {
//            _topicService = topicService;
//            _topicInsertValidate = topicInsertValidate;
//            _categoryService = categoryService;
//        }
//        [System.Web.Http.HttpGet]
//        public List<Topic> TopicsByCatId(int catId)
//        {
//            return _topicService.GetTopicByCatId(catId);
//        }




//        [System.Web.Http.Authorize]
//        [System.Web.Http.HttpPost]
//        public async Task<JsonResult> InsertTopic(TopicInsertViewModel topicViewModel)
//        {
//            JsonResult result = new JsonResult();
//            try
//            {
//                String errorMsg = "";
//                //check model state valid

//                Category parentCategory = _categoryService.GetById(topicViewModel.CatParentId);
//                Parallel.Invoke(() =>
//                {
//                    if (!ModelState.IsValid)
//                    {
//                        //UNDONE check valid at viewmodel class
//                        errorMsg = "model is not valid";
//                        result.Data = new
//                        {
//                            result = "error",
//                            message = errorMsg
//                        };
//                    }
//                }, (() =>
//                {
//                    if (!_topicInsertValidate.CheckParentCatId(topicViewModel, parentCategory, ref errorMsg))
//                    {
//                        result.Data = new
//                        {
//                            result = "error",
//                            message = errorMsg
//                        };
//                    }
//                }));

//                if (errorMsg != "")
//                {
//                    return result;
//                }

//                ApplicationUser loginedUser = null;
//                var userManager =
//                    new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
//                loginedUser = await userManager.FindByIdAsync(User.Identity.GetUserId());
//                var topic = PropertyCopy.Copy<Topic, TopicInsertViewModel>(topicViewModel);
//                topic.CreatedBy = loginedUser.Name;
//                topic.LastPostTime = DateTime.Now;
//                topic.LastPost = "";
//                _topicService.Add(topic, parentCategory);
//                _topicService.Save();
//                result.Data = new
//                {
//                    result = "success",
//                    message = errorMsg
//                };
//                return result;
//            }
//            catch (Exception e)
//            {
//                result.Data = new
//                {
//                    result = "error",
//                    message = "error"
//                };
//                return result;
//            }
//        }
//    }
//}