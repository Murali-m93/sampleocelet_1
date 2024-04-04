﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestDemo.Data;

#nullable disable

namespace TestDemo.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20240404140753_tables")]
    partial class tables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TestDemo.Model.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ConversionRateToUSD")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("TestDemo.Model.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("CostCurrencyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ProfitPerItem")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SkuName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("WasDeleted")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CostCurrencyId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("TestDemo.Model.InventoryItem", b =>
                {
                    b.HasOne("TestDemo.Model.Currency", "CostCurrency")
                        .WithMany()
                        .HasForeignKey("CostCurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CostCurrency");
                });
#pragma warning restore 612, 618
        }
    }
}