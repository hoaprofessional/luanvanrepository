using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ILanguageService
    {
        IEnumerable<LanguageCode> GetAll();
    }
    public class LanguageService : ILanguageService
    {
        ILanguageRepository _repository;
        public LanguageService(ILanguageRepository languageRepository)
        {
            _repository = languageRepository;
        }


        public IEnumerable<LanguageCode> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
