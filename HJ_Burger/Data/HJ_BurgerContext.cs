using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HJ_Burger.Models;

namespace HJ_Burger.Data
{
    public class HJ_BurgerContext : DbContext
    {
        public HJ_BurgerContext (DbContextOptions<HJ_BurgerContext> options)
            : base(options)
        {
        }

        public DbSet<HJ_Burger.Models.Burger> Burger { get; set; } = default!;
    }
}
