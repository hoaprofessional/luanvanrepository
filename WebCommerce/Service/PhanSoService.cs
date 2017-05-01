using Model;
using Repository;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPhanSoService : IQlService<PhanSo>
    {
    }

    public class PhanSoService : QlService<PhanSo>, IPhanSoService
    {
        public PhanSoService(IPhanSoRepository phanSoRepository,IUnitOfWork unitOfWork)
        {
            this._repository = phanSoRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}
