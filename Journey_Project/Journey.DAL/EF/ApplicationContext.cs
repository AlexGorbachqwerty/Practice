﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Journey.DAL.Entities;

namespace Journey.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionStrings) : base("DefaultConnection") { }
         
        public ApplicationContext()
        {

        }

        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<ClientRoute> ClientRoutes { get; set; }

    }
}