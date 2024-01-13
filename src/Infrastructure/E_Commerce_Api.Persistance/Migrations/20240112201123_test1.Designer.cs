﻿// <auto-generated />
using System;
using E_Commerce_Api.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Commerce_Api.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240112201123_test1")]
    partial class test1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("E_Commerce_Api.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(8956),
                            IsDeleted = false,
                            Name = "Elektronika & Oyuncaqlar"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9052),
                            IsDeleted = false,
                            Name = "Ayyaqqabı, Avtomobil & Elektronika"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9064),
                            IsDeleted = false,
                            Name = "musiqi"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9087),
                            IsDeleted = false,
                            Name = "Ayyaqqabı, Ayyaqqabı & oyunlar"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9111),
                            IsDeleted = false,
                            Name = "Oyuncaqlar, садинструмент & turizm"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9123),
                            IsDeleted = false,
                            Name = "Filmlər"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9133),
                            IsDeleted = false,
                            Name = "Ayyaqqabı"
                        },
                        new
                        {
                            Id = 8,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9155),
                            IsDeleted = false,
                            Name = "turizm, oyunlar & oyunlar"
                        },
                        new
                        {
                            Id = 9,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9179),
                            IsDeleted = false,
                            Name = "Avtomobil, oyunlar & bəzək"
                        },
                        new
                        {
                            Id = 10,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 650, DateTimeKind.Utc).AddTicks(9204),
                            IsDeleted = true,
                            Name = "садинструмент, uşaq üçün & bəzək"
                        });
                });

            modelBuilder.Entity("E_Commerce_Api.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 651, DateTimeKind.Utc).AddTicks(4123),
                            IsDeleted = false,
                            Name = "Electric",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 651, DateTimeKind.Utc).AddTicks(4126),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 651, DateTimeKind.Utc).AddTicks(4128),
                            IsDeleted = false,
                            Name = "Computers",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 651, DateTimeKind.Utc).AddTicks(4130),
                            IsDeleted = false,
                            Name = "Women",
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("E_Commerce_Api.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 665, DateTimeKind.Utc).AddTicks(8953),
                            Description = "Quod cupiditate suscipit eaque facilis.",
                            IsDeleted = false,
                            Title = "Ad."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 665, DateTimeKind.Utc).AddTicks(9007),
                            Description = "Aliquid cumque molestiae voluptatem consectetur.",
                            IsDeleted = true,
                            Title = "Nesciunt."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreateDate = new DateTime(2024, 1, 12, 20, 11, 23, 665, DateTimeKind.Utc).AddTicks(9103),
                            Description = "Voluptatibus omnis iusto odio nesciunt.",
                            IsDeleted = false,
                            Title = "Excepturi."
                        });
                });

            modelBuilder.Entity("E_Commerce_Api.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Test")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreateDate = new DateTime(2024, 1, 13, 0, 11, 23, 676, DateTimeKind.Local).AddTicks(1714),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Discount = 5.199227960465908m,
                            IsDeleted = false,
                            Price = 203.72m,
                            Title = "Əlverişli Qranit Stol"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreateDate = new DateTime(2024, 1, 13, 0, 11, 23, 676, DateTimeKind.Local).AddTicks(1966),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Discount = 9.526297259187136m,
                            IsDeleted = false,
                            Price = 66.06m,
                            Title = "İnanılmaz Rezin Avtomobil"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("E_Commerce_Api.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce_Api.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_Commerce_Api.Domain.Entities.Detail", b =>
                {
                    b.HasOne("E_Commerce_Api.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_Commerce_Api.Domain.Entities.Product", b =>
                {
                    b.HasOne("E_Commerce_Api.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("E_Commerce_Api.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
