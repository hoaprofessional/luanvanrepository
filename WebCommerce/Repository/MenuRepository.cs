using Model;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IMenuRepository : IRepository<Menu>
    {
        List<Menu> GetMenuByParentId(int parentId);
    }

    public class MenuRepository : BaseRepository<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public List<Menu> GetMenuByParentId(int parentId)
        {
            return GetMulti(x => x.MenuParentId == parentId).ToList();
        }
    }
}
