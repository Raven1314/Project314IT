using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using _314Project.Models;

namespace _314Project.Data
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Invite> Invites { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }

}