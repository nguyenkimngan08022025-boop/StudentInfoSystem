using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondRazorPage.Migrations
{
    /// <inheritdoc />
    public partial class TaoMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "ThoiKhoaBieu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "LichThi",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "KyLuat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "HocPhi",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "HocBong",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "DiemRenLuyen",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "BangDiem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

            
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "ThoiKhoaBieu");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "LichThi");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "KyLuat");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "HocPhi");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "HocBong");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "DiemRenLuyen");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "BangDiem");
        }
    }
}
