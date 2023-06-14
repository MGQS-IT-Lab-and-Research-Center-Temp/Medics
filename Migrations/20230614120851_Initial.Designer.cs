﻿// <auto-generated />
using System;
using Medics.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Medics.Migrations
{
    [DbContext(typeof(MedicsContext))]
    [Migration("20230614120851_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Medics.Entities.Age", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Age", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.AgeCategories", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AgeId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CategoriesId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AgeId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("AgeCategories", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.Categories", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.Drug", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<string>("IsClosed")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Prices")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Quantity")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Prices");

                    b.HasIndex("Quantity");

                    b.HasIndex("UserId");

                    b.ToTable("Drug", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.DrugCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("DrugId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("userId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DrugId");

                    b.HasIndex("UserId");

                    b.HasIndex("userId");

                    b.ToTable("DrugCategory", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.Incoming", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceNo");

                    b.ToTable("Incoming", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.Outgoing", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveredTo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Item")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("Sale")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Item");

                    b.HasIndex("Sale");

                    b.ToTable("Outgoing", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.Return", b =>
                {
                    b.Property<string>("ReturnId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Id")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("ReturnDate")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ReturnedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("ReturnId");

                    b.ToTable("Return", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("RoleName")
                        .IsUnique();

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("BillValue")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("HashSalt")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Medics.Entities.AgeCategories", b =>
                {
                    b.HasOne("Medics.Entities.Age", "Age")
                        .WithMany("AgeCategories")
                        .HasForeignKey("AgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Medics.Entities.Categories", "Categories")
                        .WithMany("AgeCategories")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Age");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Medics.Entities.Drug", b =>
                {
                    b.HasOne("Medics.Entities.User", "User")
                        .WithMany("Drug")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Medics.Entities.DrugCategory", b =>
                {
                    b.HasOne("Medics.Entities.Category", "Category")
                        .WithMany("DrugCategory")
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Medics.Entities.Drug", "Drug")
                        .WithMany("DrugCategory")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Medics.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.Navigation("Category");

                    b.Navigation("Drug");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Medics.Entities.User", b =>
                {
                    b.HasOne("Medics.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Medics.Entities.Age", b =>
                {
                    b.Navigation("AgeCategories");
                });

            modelBuilder.Entity("Medics.Entities.Categories", b =>
                {
                    b.Navigation("AgeCategories");
                });

            modelBuilder.Entity("Medics.Entities.Category", b =>
                {
                    b.Navigation("DrugCategory");
                });

            modelBuilder.Entity("Medics.Entities.Drug", b =>
                {
                    b.Navigation("DrugCategory");
                });

            modelBuilder.Entity("Medics.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Medics.Entities.User", b =>
                {
                    b.Navigation("Drug");
                });
#pragma warning restore 612, 618
        }
    }
}
