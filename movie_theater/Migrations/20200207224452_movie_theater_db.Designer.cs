﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using movie_theater.Data;

namespace movie_theater.Migrations
{
    [DbContext(typeof(MovieTheaterContext))]
    [Migration("20200207224452_movie_theater_db")]
    partial class movie_theater_db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("movie_theater.Models.FoodItem", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnName("food_id")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .HasColumnName("food_name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<decimal?>("FoodProfil")
                        .HasColumnName("food_profil")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int?>("FoodQuantity")
                        .HasColumnName("food_quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("FoodSalePrice")
                        .HasColumnName("food_sale_price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal?>("FoodUnitPrice")
                        .HasColumnName("food_unit_price")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("FoodId")
                        .HasName("PK__FoodItem__2F4C4DD8180AA0C8");

                    b.ToTable("FoodItem");
                });

            modelBuilder.Entity("movie_theater.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .HasColumnName("ticket_id")
                        .HasColumnType("int");

                    b.Property<string>("TicketMovieName")
                        .HasColumnName("ticket_movie_name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<decimal?>("TicketProfile")
                        .HasColumnName("ticket_profile")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal?>("TicketProfilePerItem")
                        .HasColumnName("ticket_profile_per_item")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int?>("TicketQuantity")
                        .HasColumnName("ticket_quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("TicketSalePrice")
                        .HasColumnName("ticket_sale_price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal?>("TicketStudioCutPercentage")
                        .HasColumnName("ticket_studio_cut_percentage")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("TicketId");

                    b.ToTable("Ticket");
                });
#pragma warning restore 612, 618
        }
    }
}
