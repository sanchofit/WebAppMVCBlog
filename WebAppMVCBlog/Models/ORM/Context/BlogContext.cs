using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebAppMVCBlog.Models.ORM.Entity;

namespace WebAppMVCBlog.Models.ORM.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=OnlineBlog;UID=sa;PWD=1234";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<SiteMenu> SiteMenus { get; set; }
    }
}