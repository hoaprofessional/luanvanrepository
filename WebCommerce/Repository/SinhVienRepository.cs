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
    // Dễ nhất là ctrl H đổi tên SinhVien thành tên lớp cần đổi
    public interface ISinhVienRepository : IRepository<SinhVien>
    {
    }

    public class SinhVienRepository : BaseRepository<SinhVien>, ISinhVienRepository
    {
        public SinhVienRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<SinhVien> GetSinhViensByHoTen(string hoTen)
        {
            return GetMulti(x => x.HoTen == hoTen);
        }
    }
}
