using System;
//using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Repository
{
    public class ProductsContext:DbContext
    {
        public ProductsContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //new Items(modelBuilder.);
        }
        public DbSet<Items> items;
        public DbSet<ItemsPrice> itemsPrices;
    }
}
