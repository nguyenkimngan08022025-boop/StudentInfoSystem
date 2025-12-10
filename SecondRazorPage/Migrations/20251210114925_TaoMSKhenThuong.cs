using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondRazorPage.Migrations
{
    /// <inheritdoc />
    public partial class TaoMSKhenThuong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "KhenThuong",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "KhenThuong");
        }
    }
}
