using Model;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPhanSoRepository : IRepository<PhanSo>
    {
    }

    public class PhanSoRepository : BaseRepository<PhanSo>, IPhanSoRepository
    {
        public PhanSoRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}
