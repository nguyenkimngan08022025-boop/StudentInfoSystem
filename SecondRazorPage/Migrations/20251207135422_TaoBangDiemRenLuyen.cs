using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondRazorPage.Migrations
{
    /// <inheritdoc />
    public partial class TaoBangDiemRenLuyen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiemRenLuyen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocKy = table.Column<int>(type: "int", nullable: false),
                    Diem = table.Column<int>(type: "int", nullable: false),
                    XepLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiDiem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemRenLuyen", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiemRenLuyen");
        }
    }
}
