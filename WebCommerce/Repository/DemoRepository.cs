using Model;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    //3_ThemRepository: st1. tạo 1 lớp Repository tương tự như vậy trong thư viện Repository
    // Dễ nhất là ctrl H đổi tên Demo thành tên lớp cần đổi
    public interface IDemoRepository : IRepository<Demo>
    {
    }

    public class DemoRepository : BaseRepository<Demo>, IDemoRepository
    {
        public DemoRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}
