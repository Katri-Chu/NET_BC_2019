using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class WebShopDB : DbContext //sasaistes postms starp SQL un C#
    {
        public WebShopDB(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }   //ierakstu sets jeb tabula (ko mēs sagaidām no tās)
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
