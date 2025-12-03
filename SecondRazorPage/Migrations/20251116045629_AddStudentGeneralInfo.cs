using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondRazorPage.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentGeneralInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Category");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Category",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeLevel",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IntakeYear",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfBirth",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainingType",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DegreeLevel",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "IntakeYear",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "PlaceOfBirth",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "TrainingType",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
