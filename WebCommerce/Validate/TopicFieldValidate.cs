//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Common.App_LocalResources;
//using Model;
//using Service;
//using ViewModel.Topic;

namespace Validate
{
    public interface ITopicFieldValidate
    {
//        bool CheckParentCatId(TopicInsertViewModel viewModel,Category parentCategory, ref string message);
    }
    public class TopicFieldValidate : ITopicFieldValidate
    {
//        private readonly ICategoryService _categoryService;
//        public TopicFieldValidate(ICategoryService categoryService)
//        {
//            _categoryService = categoryService;
//        }

//        public bool CheckParentCatId(TopicInsertViewModel viewModel, Category parentCategory, ref string message)
//        {
//            //kiem tra category cha co ton tai hay khong
//            if (parentCategory == null)
//            {
//                message = GlobalRes.CatParentNotValid;
//                return false;
//            }

//            //kiem tra category phai la category cap cuoi hay khong
//            parentCategory = _categoryService.GetById(parentCategory.ParentId);

//            if (parentCategory == null || parentCategory.CategoryName.Contains("Root"))
//            {
//                message = GlobalRes.CatParentNotValid;
//                return false;
//            }
//            return true;
//        }

    }
}
