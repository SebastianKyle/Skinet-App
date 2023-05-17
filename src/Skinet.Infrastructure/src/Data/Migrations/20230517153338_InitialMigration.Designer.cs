﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Skinet.Infrastructure.Data;

#nullable disable

namespace Skinet.Infrastructure.src.Data.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20230517153338_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Skinet.Core.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductBrandID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductTypeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandID");

                    b.HasIndex("ProductTypeID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/sb-ang1.png",
                            Price = 200m,
                            ProductBrandID = 1,
                            ProductName = "Angular Speedster Board 2000",
                            ProductTypeID = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            PictureUrl = "images/products/sb-ang2.png",
                            Price = 150m,
                            ProductBrandID = 1,
                            ProductName = "Green Angular Board 3000",
                            ProductTypeID = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            PictureUrl = "images/products/sb-core1.png",
                            Price = 180m,
                            ProductBrandID = 2,
                            ProductName = "Core Board Speed Rush 3",
                            ProductTypeID = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            PictureUrl = "images/products/sb-core2.png",
                            Price = 300m,
                            ProductBrandID = 2,
                            ProductName = "Net Core Super Board",
                            ProductTypeID = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/sb-react1.png",
                            Price = 250m,
                            ProductBrandID = 4,
                            ProductName = "React Board Super Whizzy Fast",
                            ProductTypeID = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                            PictureUrl = "images/products/sb-ts1.png",
                            Price = 120m,
                            ProductBrandID = 5,
                            ProductName = "Typescript Entry Board",
                            ProductTypeID = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/hat-core1.png",
                            Price = 10m,
                            ProductBrandID = 2,
                            ProductName = "Core Blue Hat",
                            ProductTypeID = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            PictureUrl = "images/products/hat-react1.png",
                            Price = 8m,
                            ProductBrandID = 4,
                            ProductName = "Green React Woolen Hat",
                            ProductTypeID = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/hat-react2.png",
                            Price = 15m,
                            ProductBrandID = 4,
                            ProductName = "Purple React Woolen Hat",
                            ProductTypeID = 2
                        },
                        new
                        {
                            Id = 10,
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            PictureUrl = "images/products/glove-code1.png",
                            Price = 18m,
                            ProductBrandID = 3,
                            ProductName = "Blue Code Gloves",
                            ProductTypeID = 4
                        },
                        new
                        {
                            Id = 11,
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            PictureUrl = "images/products/glove-code2.png",
                            Price = 15m,
                            ProductBrandID = 3,
                            ProductName = "Green Code Gloves",
                            ProductTypeID = 4
                        },
                        new
                        {
                            Id = 12,
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa.",
                            PictureUrl = "images/products/glove-react1.png",
                            Price = 16m,
                            ProductBrandID = 4,
                            ProductName = "Purple React Gloves",
                            ProductTypeID = 4
                        },
                        new
                        {
                            Id = 13,
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            PictureUrl = "images/products/glove-react2.png",
                            Price = 14m,
                            ProductBrandID = 4,
                            ProductName = "Green React Gloves",
                            ProductTypeID = 4
                        },
                        new
                        {
                            Id = 14,
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            PictureUrl = "images/products/boot-redis1.png",
                            Price = 250m,
                            ProductBrandID = 6,
                            ProductName = "Redis Red Boots",
                            ProductTypeID = 3
                        },
                        new
                        {
                            Id = 15,
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            PictureUrl = "images/products/boot-core2.png",
                            Price = 189.99m,
                            ProductBrandID = 2,
                            ProductName = "Core Red Boots",
                            ProductTypeID = 3
                        },
                        new
                        {
                            Id = 16,
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            PictureUrl = "images/products/boot-core1.png",
                            Price = 199.99m,
                            ProductBrandID = 2,
                            ProductName = "Core Purple Boots",
                            ProductTypeID = 3
                        },
                        new
                        {
                            Id = 17,
                            Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                            PictureUrl = "images/products/boot-ang2.png",
                            Price = 150m,
                            ProductBrandID = 1,
                            ProductName = "Angular Purple Boots",
                            ProductTypeID = 3
                        },
                        new
                        {
                            Id = 18,
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            PictureUrl = "images/products/boot-ang1.png",
                            Price = 180m,
                            ProductBrandID = 1,
                            ProductName = "Angular Blue Boots",
                            ProductTypeID = 3
                        });
                });

            modelBuilder.Entity("Skinet.Core.Domain.Entities.ProductBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductBrands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Angular"
                        },
                        new
                        {
                            Id = 2,
                            Name = "NetCore"
                        },
                        new
                        {
                            Id = 3,
                            Name = "VS Code"
                        },
                        new
                        {
                            Id = 4,
                            Name = "React"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Typescript"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Redis"
                        });
                });

            modelBuilder.Entity("Skinet.Core.Domain.Entities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Boards"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hats"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Boots"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gloves"
                        });
                });

            modelBuilder.Entity("Skinet.Core.Domain.Entities.Product", b =>
                {
                    b.HasOne("Skinet.Core.Domain.Entities.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Skinet.Core.Domain.Entities.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductType");
                });
#pragma warning restore 612, 618
        }
    }
}