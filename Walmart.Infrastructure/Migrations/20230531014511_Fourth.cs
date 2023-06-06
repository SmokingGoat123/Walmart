﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Walmart.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Id",
                table: "SubCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Product_Id",
                table: "SubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
