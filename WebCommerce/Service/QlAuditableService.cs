using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class QlAuditableService<T> : QlService<T> where T : class, IAuditable
    {
        public virtual T Add(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = true;
            return base.Add(entity);
        }
        public virtual void Update(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            base.Update(entity);
        }
        public virtual void Delete(T entity)
        {
            entity.Status = false;
            base.Update(entity);
        }
    }
}
