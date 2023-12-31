﻿// <auto-generated />
using System;
using Medics.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Medics.Migrations
{
    [DbContext(typeof(MedicsContext))]
    partial class MedicsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Medics.Entities.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpDate")
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
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Medics.Entities.Drug", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("DrugName")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("Prices")
                        .HasColumnType("longtext");

                    b.Property<string>("Quantity")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("Medics.Entities.DrugCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DrugId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DrugId");

                    b.ToTable("DrugCategory");
                });

            modelBuilder.Entity("Medics.Entities.Incoming", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bill")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ItemName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("Quantity")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplierName")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Incomings");
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
                        .HasColumnType("longtext");

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

                    b.Property<string>("Item")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("Purpose")
                        .HasColumnType("longtext");

                    b.Property<string>("Quantity")
                        .HasColumnType("longtext");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("longtext");

                    b.Property<string>("Sale")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplyDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DrugId");

                    b.ToTable("Outgoing");
                });

            modelBuilder.Entity("Medics.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MgfDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Medics.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpDate")
                        .HasColumnType("longtext");

                    b.Property<string>("HashSalt")
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

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Medics.Entities.Drug", b =>
                {
                    b.HasOne("Medics.Entities.User", "User")
                        .WithMany("Drug")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Medics.Entities.DrugCategory", b =>
                {
                    b.HasOne("Medics.Entities.Category", "Category")
                        .WithMany("DrugCategorys")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Medics.Entities.Drug", "Drug")
                        .WithMany("DrugCategorys")
                        .HasForeignKey("DrugId");

                    b.Navigation("Category");

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("Medics.Entities.Outgoing", b =>
                {
                    b.HasOne("Medics.Entities.Drug", "Drug")
                        .WithMany()
                        .HasForeignKey("DrugId");

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("Medics.Entities.User", b =>
                {
                    b.HasOne("Medics.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Medics.Entities.Category", b =>
                {
                    b.Navigation("DrugCategorys");
                });

            modelBuilder.Entity("Medics.Entities.Drug", b =>
                {
                    b.Navigation("DrugCategorys");
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
