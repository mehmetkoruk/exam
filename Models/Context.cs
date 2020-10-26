using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examlast.Models
{
    public class Context:DbContext
    {
        private static bool _created = false;
        public Context()
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=examlast.db");
        }
        public DbSet<Pmodel> pmodels { get; set; }
        public DbSet<Qmodel> qmodels { get; set; }


    }
}
