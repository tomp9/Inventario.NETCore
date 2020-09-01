using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategotyName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PFR", "Perfumería" },
                    { "SLD", "Salud" },
                    { "VDJ", "Videojuegos" }
                });

            migrationBuilder.InsertData(
                table: "WarehouseEntities",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "50aeb093-255c-4446-9964-3f640be78cd2", "932 Pallet Street, La Grange (Dutchess), NY 12540", "Bodega Central" },
                    { "4eea4797-9956-4f40-88e1-b2543923db23", "4447 Dane Street, Yakima, WA 98908", "Bodega Norte" },
                    { "f8574331-e9f5-4198-af93-3f8b89bbe4fb", "3003 Arrowood Drive, Jacksonville, FL 32257", "Third Warehouse" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PFR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "WarehouseEntities",
                keyColumn: "WarehouseId",
                keyValue: "4eea4797-9956-4f40-88e1-b2543923db23");

            migrationBuilder.DeleteData(
                table: "WarehouseEntities",
                keyColumn: "WarehouseId",
                keyValue: "50aeb093-255c-4446-9964-3f640be78cd2");

            migrationBuilder.DeleteData(
                table: "WarehouseEntities",
                keyColumn: "WarehouseId",
                keyValue: "f8574331-e9f5-4198-af93-3f8b89bbe4fb");
        }
    }
}
