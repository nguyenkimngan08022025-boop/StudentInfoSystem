using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondRazorPage.Migrations
{
    /// <inheritdoc />
    public partial class TaoHaiBangGiaoVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LichDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSGV = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichDay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuanLyLop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stt = table.Column<int>(type: "int", nullable: false),
                    MaLop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSGV = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanLyLop", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LichDay");

            migrationBuilder.DropTable(
                name: "QuanLyLop");
        }
    }
}
