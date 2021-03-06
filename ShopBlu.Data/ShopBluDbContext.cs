﻿using ShopBlu.Model.Models;
using System.Data.Entity;

namespace ShopBlu.Data
{
    public class ShopBluDbContext : DbContext
    {
        public ShopBluDbContext() : base("ShopBluConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategorys { set; get; }
        public DbSet<PostTag> PostTag { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategory { set; get; }
        public DbSet<ProductTag> ProductTag { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }

        public DbSet<Tag> Tags { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public DbSet<Error> Errors { set; get; }

        protected override void OnModelCreating(DbModelBuilder builde)
        {
        }
    }
}