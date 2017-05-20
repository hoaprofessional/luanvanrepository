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
    public interface IMenuService
    {
        List<MenuViewModel> GetAllMenu();
    }
    public class MenuService : IMenuService
    {
        IMenuRepository _menuRepository;
        IUnitOfWork _unitOfWork;
        public MenuService(IMenuRepository menuRepository, IUnitOfWork unitOfWork)
        {
            this._menuRepository = menuRepository;
            this._unitOfWork = unitOfWork;
        }
        /// <summary>
        /// tao ra menuviewmodel tu menu co danh sach cac menu con
        /// neu khong co menu con thi childs = null nguoc lai childs chua danh sach cac menu con
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        private MenuViewModel MenuViewModelFromMenu(Menu menu)
        {
            //Neu menu==null thi khong tao viewmodel
            if (menu == null)
                return null;
            //tao noi dung cho menu viewmodel
            MenuViewModel menuViewModel = new MenuViewModel();
            menuViewModel.Content = menu;
            menuViewModel.Display = FieldHelper.Instance.GetValueLangRes("Menu" + menu.MenuName);
            //lay danh sach menu con
            List<Menu> childs = _menuRepository.GetMenuByParentId(menu.Id);
            //neu so phan tu =0
            if (childs.Count == 0)
            {
                menuViewModel.Childs = null;
                return menuViewModel;
            }
            //nguoc lai goi ham MenuViewModelFromMenu lai de tao noi dung cho menu con
            menuViewModel.Childs = new List<MenuViewModel>();
            foreach (var item in childs)
            {
                menuViewModel.Childs.Add(MenuViewModelFromMenu(item));
            }
            return menuViewModel;
        }
        /// <summary>
        /// Lay tat ca cac menu
        /// </summary>
        /// <returns></returns>
        public List<MenuViewModel> GetAllMenu()
        {
            //lay danh sach nhung menu khong co parent. nhung menu k co parent la nhung menu co parent id = 0
            List<Menu> menus = _menuRepository.GetMenuByParentId(0);
            //khoi tao danh sach menu view model
            List<MenuViewModel> menuViewModels = new List<MenuViewModel>();
            foreach (var item in menus)
            {
                menuViewModels.Add(MenuViewModelFromMenu(item));
            }
            return menuViewModels;
        }
    }
}
