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
    public interface IDemoService : IQlService<Demo>
    {
    }

    public class DemoService : QlService<Demo>, IDemoService
    {
        public DemoService(IDemoRepository demoRepository,IUnitOfWork unitOfWork)
        {
            this._repository = demoRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}
