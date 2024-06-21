using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTTBaiThiLai.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_DTT893 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DTT893",
                columns: table => new
                {
                    HoTen = table.Column<string>(type: "TEXT", nullable: false),
                    ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Ngaysinh = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTT893", x => x.HoTen);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTT893");
        }
    }
}
