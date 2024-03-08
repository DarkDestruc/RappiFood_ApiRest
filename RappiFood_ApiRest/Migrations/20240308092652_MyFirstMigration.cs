using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RappiFood_ApiRest.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuRappiFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRappiFoods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MenuRappiFoods",
                columns: new[] { "Id", "Description", "NameFood", "Price" },
                values: new object[,]
                {
                    { 1, "Caldo de vegetales con albacora", "Encebollado", 2.50m },
                    { 2, "Caldo frio con pescado curtido", "Cebiche de Pescado", 3.50m },
                    { 3, "Verde cocinado en hoja relleno de pescado", "Bollo de Pescado", 1.50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuRappiFoods");
        }
    }
}
