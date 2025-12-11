using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondRazorPage.Migrations
{
    /// <inheritdoc />
    public partial class TaoBangLichThi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LichThi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stt = table.Column<int>(type: "int", nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HocKy = table.Column<int>(type: "int", nullable: true),
                    NgayThi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioThi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonThi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhongThi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoSoThi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichThi", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LichThi");
        }
    }
}
