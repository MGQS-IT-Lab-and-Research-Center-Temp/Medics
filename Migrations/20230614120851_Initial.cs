﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Medics.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Age",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Age", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Incoming",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    SupplierName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ItemName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "varchar(255)", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incoming", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Outgoing",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Item = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DeliveredTo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Purpose = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Sale = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outgoing", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Return",
                columns: table => new
                {
                    ReturnId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ReturnDate = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ReturnedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<string>(type: "longtext", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return", x => x.ReturnId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AgeCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    AgeId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CategoriesId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgeCategories_Age_AgeId",
                        column: x => x.AgeId,
                        principalTable: "Age",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgeCategories_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    HashSalt = table.Column<string>(type: "longtext", nullable: true),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Drug",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Prices = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<string>(type: "varchar(255)", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(255)", nullable: true),
                    IsClosed = table.Column<string>(type: "longtext", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drug", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drug_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DrugCategory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    userId = table.Column<string>(type: "varchar(255)", nullable: true),
                    DrugId = table.Column<string>(type: "varchar(255)", nullable: true),
                    CategoryId = table.Column<string>(type: "longtext", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MgfDate = table.Column<string>(type: "longtext", nullable: true),
                    ExpDate = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "longtext", nullable: true),
                    SupplyDate = table.Column<string>(type: "longtext", nullable: true),
                    BillValue = table.Column<string>(type: "longtext", nullable: true),
                    Bill = table.Column<string>(type: "longtext", nullable: true),
                    DeliveryDate = table.Column<string>(type: "longtext", nullable: true),
                    ReceiptNo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrugCategory_Category_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugCategory_Drug_UserId",
                        column: x => x.UserId,
                        principalTable: "Drug",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugCategory_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AgeCategories_AgeId",
                table: "AgeCategories",
                column: "AgeId");

            migrationBuilder.CreateIndex(
                name: "IX_AgeCategories_CategoriesId",
                table: "AgeCategories",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_Name",
                table: "Category",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drug_Prices",
                table: "Drug",
                column: "Prices");

            migrationBuilder.CreateIndex(
                name: "IX_Drug_Quantity",
                table: "Drug",
                column: "Quantity");

            migrationBuilder.CreateIndex(
                name: "IX_Drug_UserId",
                table: "Drug",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugCategory_DrugId",
                table: "DrugCategory",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugCategory_userId",
                table: "DrugCategory",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugCategory_UserId",
                table: "DrugCategory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Incoming_InvoiceNo",
                table: "Incoming",
                column: "InvoiceNo");

            migrationBuilder.CreateIndex(
                name: "IX_Outgoing_Item",
                table: "Outgoing",
                column: "Item");

            migrationBuilder.CreateIndex(
                name: "IX_Outgoing_Sale",
                table: "Outgoing",
                column: "Sale");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RoleName",
                table: "Roles",
                column: "RoleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgeCategories");

            migrationBuilder.DropTable(
                name: "DrugCategory");

            migrationBuilder.DropTable(
                name: "Incoming");

            migrationBuilder.DropTable(
                name: "Outgoing");

            migrationBuilder.DropTable(
                name: "Return");

            migrationBuilder.DropTable(
                name: "Age");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Drug");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
