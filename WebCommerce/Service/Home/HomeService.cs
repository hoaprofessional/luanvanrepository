using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Model;
using Repository;
using ViewModel;
using ViewModel.Home;

namespace Service.Home
{
    public interface IHomeService
    {
        List<ViewModel.Home.TopicViewModel> GetTop10Topics();

        CategoryViewModel GetBuyCategory();
        CategoryViewModel GetSellCategory();
        CategoryViewModel GetForeignInfomationCategory();
        List<ViewModel.Home.CategoryViewModel> GetCategories();
        List<LastestTopicViewModel> GetLastestTopics();
        List<SellerViewModel> GetTopBonuSellerViewModels();
    }
    public class HomeService : IHomeService
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICategoryRepository _categoryRepository;
        public HomeService(ITopicRepository topicRepository, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            _topicRepository = topicRepository;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
        }
        public List<ViewModel.Home.TopicViewModel> GetTop10Topics()
        {
            return ViewModelMapper<TopicViewModel, Topic>.MapObjects(_topicRepository.GetAll().OrderBy(x => x.NoOfLikes).Take(10).ToList(), _userRepository);
        }

        private CategoryViewModel CategoryViewModelFromModel(Category category)
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            categoryViewModel.Image = category.Image;
            categoryViewModel.Display = FieldHelper.Instance.GetValueLangRes("Category" + category.CategoryName);
            categoryViewModel.Decription = FieldHelper.Instance.GetValueLangRes("CategoryDecription" + category.CategoryName);
            return categoryViewModel;
        }

        public CategoryViewModel GetBuyCategory()
        {
            var buyCategoryViewModel = CategoryViewModelFromModel(_categoryRepository.GetSingleByCondition(x => x.CategoryName.Contains("Buy")));
            buyCategoryViewModel.HexColor = "#FF0E0A";
            return buyCategoryViewModel;
        }

        public CategoryViewModel GetSellCategory()
        {
            var sellCategoryViewModel = CategoryViewModelFromModel(_categoryRepository.GetSingleByCondition(x => x.CategoryName.Contains("Sell")));
            sellCategoryViewModel.HexColor = "rgb(78, 70, 10)";
            return sellCategoryViewModel;
        }

        public CategoryViewModel GetForeignInfomationCategory()
        {
            var foreignInfomationCategoryViewModel = CategoryViewModelFromModel(_categoryRepository.GetSingleByCondition(x => x.CategoryName.Contains("Foreign")));
            foreignInfomationCategoryViewModel.HexColor = "#000000";
            return foreignInfomationCategoryViewModel;
        }

        public List<ViewModel.Home.CategoryViewModel> GetCategories()
        {
            List<ViewModel.Home.CategoryViewModel> categoryViewModels = new List<CategoryViewModel>();
            categoryViewModels.Add(GetBuyCategory());
            categoryViewModels.Add(GetSellCategory());
            categoryViewModels.Add(GetForeignInfomationCategory());
            return categoryViewModels;
        }

        public List<LastestTopicViewModel> GetLastestTopics()
        {
            return ViewModelMapper<LastestTopicViewModel, Topic>.MapObjects(_topicRepository.GetAll().OrderBy(x => x.CreatedDate).Take(4).ToList(), _userRepository);
        }

        public List<SellerViewModel> GetTopBonuSellerViewModels()
        {
            return ViewModelMapper<SellerViewModel, ApplicationUser>.MapObjects(_userRepository.GetMulti(x => x.Bonus != 0).OrderBy(x => x.Bonus).Take(10).ToList());
        }
    }
}
