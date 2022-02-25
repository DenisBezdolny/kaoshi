using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Laba1Dall.Entities;

namespace Laba1Dall.Data

{
    
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public DbSet<Dish> Dishes { get; set; }
            public DbSet<DishGroup> DishGroups { get; set; }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {


            }
        }
}

