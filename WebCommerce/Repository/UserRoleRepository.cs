﻿using Microsoft.AspNet.Identity.EntityFramework;
using Model;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRoleRepository : IRepository<IdentityUserRole>
    {
    }

    public class UserRoleRepository : BaseRepository<IdentityUserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}