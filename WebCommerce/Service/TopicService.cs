//using Model;
//using Repository;
//using Repository.Infrastructure;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Common;
//using ViewModel;
//using ViewModel.Topic;

//namespace Service
//{
//    public interface ITopicService : IQlService<Topic>
//    {
//        List<Topic> GetTopicByCatId(int catId);
//        /// <summary>
//        /// Use in TopicController
//        /// </summary>
//        /// <param name="catId"></param>
//        /// <returns></returns>
//        List<TopicListViewModel> GetTopicListViewModelsByCatId(int catId);
//        Topic Add(Topic entity, Category category);
//        List<TopicListViewModel> GetTop10Topics();
//    }

//    public class TopicService : QlAuditableService<Topic>, ITopicService
//    {
//        readonly ITopicRepository _topicRepository;
//        readonly ICategoryService _categoryService;
//        public TopicService(ITopicRepository topicRepository, ICategoryService categoryService, IUnitOfWork unitOfWork)
//        {
//            this._repository = topicRepository;
//            _categoryService = categoryService;
//            _topicRepository = topicRepository;
//            this._unitOfWork = unitOfWork;
//        }

//        public override Topic Add(Topic entity)
//        {
//            Category category = _categoryService.GetById(entity.CatParentId);
//            category.NoOfTopics = category.NoOfTopics + 1;
//            _categoryService.Update(category);
//            _categoryService.Save();
//            return base.Add(entity);
//        }
//        public override void Delete(Topic entity)
//        {
//            Category category = _categoryService.GetById(entity.Id);
//            category.NoOfTopics = category.NoOfTopics - 1;
//            _categoryService.Update(category);
//            _categoryService.Save();
//            base.Delete(entity);
//        }
//        public override void Delete(int id)
//        {
//            Delete(_repository.GetSingleById(id));
//        }
//        public List<Topic> GetTopicByCatId(int catId)
//        {
//            return _topicRepository.GetTopicsByCatId(catId).ToList();
//        }

//        public List<TopicListViewModel> GetTopicListViewModelsByCatId(int catId)
//        {
//            List<Topic> topicsByCatId = GetTopicByCatId(catId);
//            List<TopicListViewModel> topicListViewModels = new List<TopicListViewModel>();
//            foreach (Topic topic in topicsByCatId)
//            {
//                TopicListViewModel topicListViewModel = PropertyCopy.Copy<TopicListViewModel, Topic>(topic);
//                topicListViewModels.Add(topicListViewModel);
//            }
//            return topicListViewModels;
//        }

//        public Topic Add(Topic entity, Category category)
//        {
//            category.NoOfTopics = category.NoOfTopics + 1;
//            _categoryService.Update(category);
//            _categoryService.Save();
//            return base.Add(entity);
//        }

//        public List<TopicListViewModel> GetTop10Topics()
//        {
//            List<Topic> top10Topics = _topicRepository.GetAll().OrderBy(topic => topic.NoOfLikes).Take(10).ToList();
//            return ViewModelMapper<TopicListViewModel, Topic>.MapObjects(top10Topics);
//        }
//    }
//}
