using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.EntityFrameworkCore.Context
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS; Initial Catalog=afetgiris; Integrated Security=True; Persist Security Info=False");
            base.OnConfiguring(optionsBuilder);

        }




    }
}
