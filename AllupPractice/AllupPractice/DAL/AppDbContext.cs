using AllupPractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllupPractice.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Laptop", Image = "category-1.jpg", IsDeleted = false, IsMain = true }, 
                new Category { Id = 2, Name = "Computer", Image = "category-2.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 3, Name = "Smartphone", Image = "category-3.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 4, Name = "Game Consoles", Image = "category-4.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 5, Name = "Bottoms", Image = "category-5.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 6, Name = "Top & Sets", Image = "category-6.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 7, Name = "Audio", Image = "category-7.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 8, Name = "Accesories", Image = "category-8.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 9, Name = "Camera", Image = "category-9.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 10, Name = "Headphones", Image = "category-10.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 11, Name = "Microphone", Image = "category-11.jpg", IsDeleted = false, IsMain = true },
                new Category { Id = 12, Name = "Video Games", Image = "category-12.jpg", IsDeleted = false, IsMain = true }

                );
        } 
    }
}
