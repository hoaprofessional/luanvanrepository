using Model;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IQlService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Add(T entity);
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        void Save();
    }
    public class QlService<T> : IQlService<T> where T : class
    {
        protected IRepository<T> _repository;
        protected IUnitOfWork _unitOfWork;
        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual T Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _repository.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public virtual void Delete(int id)
        {
            _repository.Delete(id);
        }

        public virtual void Save()
        {
            _unitOfWork.Commit();
        }


        public T GetById(int id)
        {
            return _repository.GetSingleById(id);
        }
    }
}
