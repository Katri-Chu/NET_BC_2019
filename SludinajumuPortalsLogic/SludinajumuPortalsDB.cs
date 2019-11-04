using Microsoft.EntityFrameworkCore;
using SludinajumuPortals.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SludinajumuPortals.Logic
{
    public class SludinajumuPortalsDB : DbContext
    {
        public SludinajumuPortalsDB(DbContextOptions options)
                    : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Ad> Ads { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
