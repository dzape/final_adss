using Microsoft.EntityFrameworkCore.Migrations;

namespace movie_theater.Migrations
{
    public partial class movie_theater_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodItem",
                columns: table => new
                {
                    food_id = table.Column<int>(nullable: false),
                    food_name = table.Column<string>(maxLength: 250, nullable: true),
                    food_sale_price = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    food_unit_price = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    food_quantity = table.Column<int>(nullable: true),
                    food_profil = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FoodItem__2F4C4DD8180AA0C8", x => x.food_id);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    ticket_id = table.Column<int>(nullable: false),
                    ticket_movie_name = table.Column<string>(maxLength: 250, nullable: true),
                    ticket_sale_price = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    ticket_studio_cut_percentage = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    ticket_quantity = table.Column<int>(nullable: true),
                    ticket_profile = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    ticket_profile_per_item = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.ticket_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodItem");

            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
