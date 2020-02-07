using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using movie_theater.Models;

namespace movie_theater.Data
{
    public partial class MovieTheaterContext : DbContext
    {

        public MovieTheaterContext(DbContextOptions<MovieTheaterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FoodItem> FoodItem { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost,1432;Initial Catalog=MovieTheater;Persist Security Info=True;User ID=sa;Password=!2E45678");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FoodId).HasColumnName("food_id");

                entity.Property(e => e.FoodName)
                    .HasColumnName("food_name")
                    .HasMaxLength(250);

                entity.Property(e => e.FoodProfil)
                    .HasColumnName("food_profil")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FoodQuantity).HasColumnName("food_quantity");

                entity.Property(e => e.FoodSalePrice)
                    .HasColumnName("food_sale_price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FoodUnitPrice)
                    .HasColumnName("food_unit_price")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");

                entity.Property(e => e.TicketMovieName)
                    .HasColumnName("ticket_movie_name")
                    .HasMaxLength(250);

                entity.Property(e => e.TicketProfile)
                    .HasColumnName("ticket_profile")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TicketProfilePerItem)
                    .HasColumnName("ticket_profile_per_item")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TicketQuantity).HasColumnName("ticket_quantity");

                entity.Property(e => e.TicketSalePrice)
                    .HasColumnName("ticket_sale_price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TicketStudioCutPercentage)
                    .HasColumnName("ticket_studio_cut_percentage")
                    .HasColumnType("decimal(10, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
