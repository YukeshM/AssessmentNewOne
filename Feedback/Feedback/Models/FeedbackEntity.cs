using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Feedback.Models
{
    public partial class FeedbackEntity : DbContext
    {
        public FeedbackEntity()
            : base("name=FeedbackEntity")
        {
        }

        public virtual DbSet<Category> Categories
        {
            get; set;
        }
        public virtual DbSet<Country> Countries
        {
            get; set;
        }
        public virtual DbSet<Feedback> Feedbacks
        {
            get; set;
        }
        public virtual DbSet<Product> Products
        {
            get; set;
        }
        public virtual DbSet<ProductInformation> ProductInformations
        {
            get; set;
        }
        public virtual DbSet<Satisfactory> Satisfactories
        {
            get; set;
        }
        public virtual DbSet<Title> Titles
        {
            get; set;
        }
        public virtual DbSet<UserAddress> UserAddresses
        {
            get; set;
        }
        public virtual DbSet<UserDetail> UserDetails
        {
            get; set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Category1)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.ProductInformations)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.ProductInformations1)
                .WithRequired(e => e.Category1)
                .HasForeignKey(e => e.PurchasedProductInTwoMonth)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Country1)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.UserAddresses)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product1)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductInformations)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductInformation>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Satisfactory>()
                .Property(e => e.SatisfactoryStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Satisfactory>()
                .HasMany(e => e.Feedbacks)
                .WithRequired(e => e.Satisfactory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Satisfactory>()
                .HasMany(e => e.ProductInformations)
                .WithRequired(e => e.Satisfactory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.Title1)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.UserDetails)
                .WithRequired(e => e.Title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserAddress>()
                .Property(e => e.StreetAddress)
                .IsUnicode(false);

            modelBuilder.Entity<UserAddress>()
                .Property(e => e.StreetAddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<UserAddress>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<UserAddress>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<UserAddress>()
                .HasMany(e => e.UserDetails)
                .WithRequired(e => e.UserAddress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.Initial)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
