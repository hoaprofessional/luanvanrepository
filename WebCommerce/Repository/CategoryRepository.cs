using Model;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetCategoryByParentId(int parentId);
        Category GetRootCategory();
    }

    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public List<Category> GetCategoryByParentId(int parentId)
        {
            return GetMulti(x => x.ParentId == parentId).ToList();
        }


        public Category GetRootCategory()
        {
            return GetSingleByCondition(x => x.CategoryName.Contains("Root"));
        }
    }
}
