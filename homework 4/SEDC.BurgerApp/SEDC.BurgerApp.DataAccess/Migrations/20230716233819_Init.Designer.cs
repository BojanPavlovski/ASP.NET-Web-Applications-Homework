﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEDC.BurgerApp.DataAccess;

#nullable disable

namespace SEDC.BurgerApp.DataAccess.Migrations
{
    [DbContext(typeof(BurgerAppDbContext))]
    [Migration("20230716233819_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SEDC.BurgerApp.Domain.Burgers.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("HasFries")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Burgers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasFries = true,
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Hamburger",
                            Price = 250
                        },
                        new
                        {
                            Id = 2,
                            HasFries = true,
                            IsVegan = false,
                            IsVegetarian = true,
                            Name = "Cheeseburger",
                            Price = 300
                        },
                        new
                        {
                            Id = 3,
                            HasFries = true,
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Bacon Burger",
                            Price = 350
                        });
                });

            modelBuilder.Entity("SEDC.BurgerApp.Domain.Orders.BurgerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BurgerId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfBurgers")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BurgerId");

                    b.HasIndex("OrderId");

                    b.ToTable("BurgerOrders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BurgerId = 1,
                            NumberOfBurgers = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 3,
                            BurgerId = 2,
                            NumberOfBurgers = 1,
                            OrderId = 2
                        });
                });

            modelBuilder.Entity("SEDC.BurgerApp.Domain.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Leninova 1",
                            FullName = "Petko Petkovski",
                            IsDelivered = false,
                            Location = "Partizanski odredi"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Leninova 2",
                            FullName = "Marko Markovski",
                            IsDelivered = true,
                            Location = "Partizanski odredi"
                        });
                });

            modelBuilder.Entity("SEDC.BurgerApp.Domain.Orders.BurgerOrder", b =>
                {
                    b.HasOne("SEDC.BurgerApp.Domain.Burgers.Burger", "Burger")
                        .WithMany("Burgers")
                        .HasForeignKey("BurgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEDC.BurgerApp.Domain.Orders.Order", "Order")
                        .WithMany("Burgers")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("SEDC.BurgerApp.Domain.Burgers.Burger", b =>
                {
                    b.Navigation("Burgers");
                });

            modelBuilder.Entity("SEDC.BurgerApp.Domain.Orders.Order", b =>
                {
                    b.Navigation("Burgers");
                });
#pragma warning restore 612, 618
        }
    }
}
