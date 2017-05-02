﻿using Model;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ILanguageRepository 
    {
        IEnumerable<LanguageCode> GetAll();
    }

    public class LanguageRepository : ILanguageRepository
    {
        #region Properties

        private DcContext dataContext;
        private readonly IDbSet<LanguageCode> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected DcContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }

        #endregion

        public LanguageRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<LanguageCode>();
        }

        public IEnumerable<LanguageCode> GetAll()
        {
            return dataContext.Set<LanguageCode>().AsQueryable();
        }
    }
}