using Common;
using Model;
using Repository;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Service
{
    public interface ICategoryService
    {
        //CategoryViewModel CategoryViewModelFromCategory(Category category);
        //CategoryViewModel GetCategoryViewModelById(int id);
        //CategoryViewModel RootCategory();
        void Update(Category entity);
        void Save();
     //   Category GetById(int id);
    }
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;
        IUnitOfWork _unitOfWork;
        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this._categoryRepository = categoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }
        public void Save()
        {
            _unitOfWork.Commit();
        }

        /// <summary>
        /// tao ra categoryviewmodel tu category co danh sach cac category con
        /// neu khong co category con thi childs = null nguoc lai childs chua danh sach cac category con
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        //public CategoryViewModel CategoryViewModelFromCategory(Category category)
        //{
        //    //Neu category==null thi khong tao viewmodel
        //    if (category == null)
        //        return null;
        //    //tao noi dung cho category viewmodel
        //    CategoryViewModel categoryViewModel = new CategoryViewModel();
        //    categoryViewModel.Content = category;
        //    categoryViewModel.Display = FieldHelper.Instance.GetValueLangRes("Category" + category.CategoryName);
        //    categoryViewModel.Decription = FieldHelper.Instance.GetValueLangRes("CategoryDecription" + category.CategoryName);
        //    //lay danh sach category con
        //    List<Category> childs = _categoryRepository.GetCategoryByParentId(category.Id);
        //    //neu so phan tu =0
        //    if (childs.Count == 0)
        //    {
        //        categoryViewModel.Childs = null;
        //        return categoryViewModel;
        //    }
        //    //nguoc lai goi ham CategoryViewModelFromCategory lai de tao noi dung cho category con
        //    categoryViewModel.Childs = new List<CategoryViewModel>();
        //    foreach (var item in childs)
        //    {
        //        CategoryViewModel categoryChildViewModel = new CategoryViewModel();
        //        categoryChildViewModel.Content = item;
        //        categoryChildViewModel.Display = FieldHelper.Instance.GetValueLangRes("Category" + item.CategoryName);
        //        categoryChildViewModel.Decription = FieldHelper.Instance.GetValueLangRes("CategoryDecription" + item.CategoryName);
        //        categoryViewModel.Childs.Add(categoryChildViewModel);
        //    }
        //    return categoryViewModel;
        //}



        //public CategoryViewModel RootCategory()
        //{
        //    return CategoryViewModelFromCategory(_categoryRepository.GetRootCategory());
        //}


        //public Category GetById(int id)
        //{
        //    return _categoryRepository.GetSingleById(id);
        //}

        //public CategoryViewModel GetCategoryViewModelById(int id)
        //{
        //    return CategoryViewModelFromCategory(GetById(id));
        //}
    }
}
