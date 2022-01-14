using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.EntityFrameworkCore
{
    //https://stackoverflow.com/questions/60561851/an-error-occurred-while-accessing-the-microsoft-extensions-hosting-services-when
    //I Use IdentityDbContext For 1_Reflection for connectionString , 2_Development Capability
    //public class ToDoDbContext : IdentityDbContext<ApplicationUser>
    public class ToDoDbContext : DbContext
    {
        #region [-Ctor-]
      
        public ToDoDbContext(DbContextOptions<ToDoDbContext> contextOptions) : base(contextOptions)
        {

        }
        #endregion

        #region [-OnModelCreating(ModelBuilder modelBuilder)-]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region [-Aggregates-DbSet<>-]
        public DbSet<Domain.Aggregations.ToDoAggregate.ToDo> ToDo { get; set; }
        public DbSet<Domain.Aggregations.BoardAggregate.Board> Board { get; set; }
        #endregion

    }
    
}
