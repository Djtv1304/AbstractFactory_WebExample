using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbstractFactory.Migrations
{
    /// <inheritdoc />
    public partial class PruebaTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloqueInterroganteGameboy",
                columns: table => new
                {
                    IdBloque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hasBricks = table.Column<bool>(type: "bit", nullable: false),
                    hasUpgrade = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloqueInterroganteGameboy", x => x.IdBloque);
                });

            migrationBuilder.CreateTable(
                name: "BloqueInterroganteNintendoDS",
                columns: table => new
                {
                    IdBloque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hasBricks = table.Column<bool>(type: "bit", nullable: false),
                    hasUpgrade = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloqueInterroganteNintendoDS", x => x.IdBloque);
                });

            migrationBuilder.CreateTable(
                name: "MonedaGameboy",
                columns: table => new
                {
                    IdMoneda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    isStarCoin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonedaGameboy", x => x.IdMoneda);
                });

            migrationBuilder.CreateTable(
                name: "MonedaNintendoDS",
                columns: table => new
                {
                    IdMoneda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    isStarCoin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonedaNintendoDS", x => x.IdMoneda);
                });

            migrationBuilder.InsertData(
                table: "BloqueInterroganteGameboy",
                columns: new[] { "IdBloque", "Color", "hasBricks", "hasUpgrade" },
                values: new object[] { 1, "Dorado", true, true });

            migrationBuilder.InsertData(
                table: "BloqueInterroganteNintendoDS",
                columns: new[] { "IdBloque", "Color", "hasBricks", "hasUpgrade" },
                values: new object[] { 1, "Rojo", false, false });

            migrationBuilder.InsertData(
                table: "MonedaGameboy",
                columns: new[] { "IdMoneda", "Color", "Valor", "isStarCoin" },
                values: new object[] { 1, "Dorado", 30, true });

            migrationBuilder.InsertData(
                table: "MonedaNintendoDS",
                columns: new[] { "IdMoneda", "Color", "Valor", "isStarCoin" },
                values: new object[] { 1, "Roja", 60, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloqueInterroganteGameboy");

            migrationBuilder.DropTable(
                name: "BloqueInterroganteNintendoDS");

            migrationBuilder.DropTable(
                name: "MonedaGameboy");

            migrationBuilder.DropTable(
                name: "MonedaNintendoDS");
        }
    }
}
