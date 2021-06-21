using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_location",
                table: "location");

            migrationBuilder.RenameTable(
                name: "location",
                newName: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "regionId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "row",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "location_id");

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    regionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_id = table.Column<int>(type: "int", nullable: false),
                    row = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.regionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_regionId",
                table: "Locations",
                column: "regionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Region_regionId",
                table: "Locations",
                column: "regionId",
                principalTable: "Region",
                principalColumn: "regionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Region_regionId",
                table: "Locations");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_regionId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "regionId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "row",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "location");

            migrationBuilder.AddPrimaryKey(
                name: "PK_location",
                table: "location",
                column: "location_id");
        }
    }
}
