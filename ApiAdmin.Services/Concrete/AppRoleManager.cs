﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

using ApiAdmin.Core.Entities.Identity;
using ApiAdmin.Data;
using ApiAdmin.Data.Identity;


namespace ApiAdmin.Services.Concrete
{
    public class AppRoleManager : RoleManager<AppRole, long>
    {
        public AppRoleManager(AppRoleStore store)
            : base(store)
        {
        }

        public static AppRoleManager Create(IdentityFactoryOptions<AppRoleManager> options, IOwinContext context)
        {
            var dbContext = context.Get<DataDbContext>();
            var manager = new AppRoleManager(new AppRoleStore(dbContext));

            return manager;
        }
    }
}
