using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreateMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    comments_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.comments_id);
                });

            migrationBuilder.CreateTable(
                name: "free_services",
                columns: table => new
                {
                    free_services_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    InChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_free_services", x => x.free_services_id);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    location_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_id = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.location_id);
                });

            migrationBuilder.CreateTable(
                name: "note",
                columns: table => new
                {
                    note_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_note", x => x.note_id);
                });

            migrationBuilder.CreateTable(
                name: "paid_services",
                columns: table => new
                {
                    paid_services_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    InChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paid_services", x => x.paid_services_id);
                });

            migrationBuilder.CreateTable(
                name: "prices",
                columns: table => new
                {
                    prices_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    one_people_price = table.Column<int>(type: "int", nullable: false),
                    two_people_price = table.Column<int>(type: "int", nullable: false),
                    three_people_price = table.Column<int>(type: "int", nullable: false),
                    three_six_children_price = table.Column<int>(type: "int", nullable: false),
                    seven_twelve_children_price = table.Column<int>(type: "int", nullable: false),
                    zero_two_children_price = table.Column<int>(type: "int", nullable: false),
                    tour_type = table.Column<int>(type: "int", nullable: false),
                    excursion_fee = table.Column<int>(type: "int", nullable: false),
                    information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_id = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prices", x => x.prices_id);
                });

            migrationBuilder.CreateTable(
                name: "tour",
                columns: table => new
                {
                    tour_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tour_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bus_id = table.Column<int>(type: "int", nullable: false),
                    quant = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tour", x => x.tour_id);
                });

            migrationBuilder.CreateTable(
                name: "tour_date",
                columns: table => new
                {
                    date_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_id = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tour_date", x => x.date_id);
                });

            migrationBuilder.CreateTable(
                name: "tour_free_services",
                columns: table => new
                {
                    tour_free_services_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_id = table.Column<int>(type: "int", nullable: false),
                    free_services_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tour_free_services", x => x.tour_free_services_id);
                });

            migrationBuilder.CreateTable(
                name: "tour_image",
                columns: table => new
                {
                    image_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_id = table.Column<int>(type: "int", nullable: false),
                    image_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    path_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tour_image", x => x.image_id);
                });

            migrationBuilder.CreateTable(
                name: "tour_note",
                columns: table => new
                {
                    tour_not_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_id = table.Column<int>(type: "int", nullable: false),
                    note_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tour_note", x => x.tour_not_id);
                });

            migrationBuilder.CreateTable(
                name: "tour_paid_services",
                columns: table => new
                {
                    tour_paid_services_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_id = table.Column<int>(type: "int", nullable: false),
                    paid_services_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tour_paid_services", x => x.tour_paid_services_id);
                });

            migrationBuilder.CreateTable(
                name: "tour_program",
                columns: table => new
                {
                    tour_program_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hotel_id = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<bool>(type: "bit", nullable: true),
                    IsChecked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tour_program", x => x.tour_program_id);
                });

            migrationBuilder.CreateTable(
                name: "tour_program_location",
                columns: table => new
                {
                    tour_prog_loc_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tour_program_id = table.Column<int>(type: "int", nullable: false),
                    location_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tour_program_location", x => x.tour_prog_loc_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "free_services");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropTable(
                name: "note");

            migrationBuilder.DropTable(
                name: "paid_services");

            migrationBuilder.DropTable(
                name: "prices");

            migrationBuilder.DropTable(
                name: "tour");

            migrationBuilder.DropTable(
                name: "tour_date");

            migrationBuilder.DropTable(
                name: "tour_free_services");

            migrationBuilder.DropTable(
                name: "tour_image");

            migrationBuilder.DropTable(
                name: "tour_note");

            migrationBuilder.DropTable(
                name: "tour_paid_services");

            migrationBuilder.DropTable(
                name: "tour_program");

            migrationBuilder.DropTable(
                name: "tour_program_location");
        }
    }
}
