using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProvaPub.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Alyssa Baumbach" },
                    { 2, "Caleb Mayert" },
                    { 3, "Nathan Kertzmann" },
                    { 4, "Melanie Prosacco" },
                    { 5, "Kent Wunsch" },
                    { 6, "Robin Pfannerstill" },
                    { 7, "Albert Monahan" },
                    { 8, "Jeremiah Botsford" },
                    { 9, "Claude Heaney" },
                    { 10, "Bernard Purdy" },
                    { 11, "Lucy Mosciski" },
                    { 12, "Blake Donnelly" },
                    { 13, "Ginger Muller" },
                    { 14, "Ben Baumbach" },
                    { 15, "Arthur Nicolas" },
                    { 16, "Arthur Huel" },
                    { 17, "June Jones" },
                    { 18, "Sergio Heaney" },
                    { 19, "Michael Metz" },
                    { 20, "Christine Kutch" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unbranded Metal Keyboard" },
                    { 2, "Refined Rubber Table" },
                    { 3, "Practical Metal Towels" },
                    { 4, "Fantastic Wooden Chair" },
                    { 5, "Gorgeous Granite Car" },
                    { 6, "Sleek Fresh Salad" },
                    { 7, "Sleek Fresh Cheese" },
                    { 8, "Refined Granite Shirt" },
                    { 9, "Awesome Concrete Bacon" },
                    { 10, "Tasty Frozen Mouse" },
                    { 11, "Licensed Fresh Tuna" },
                    { 12, "Unbranded Rubber Shoes" },
                    { 13, "Handcrafted Cotton Shoes" },
                    { 14, "Generic Rubber Shirt" },
                    { 15, "Sleek Concrete Bike" },
                    { 16, "Generic Concrete Tuna" },
                    { 17, "Refined Granite Chicken" },
                    { 18, "Rustic Frozen Chicken" },
                    { 19, "Fantastic Metal Table" },
                    { 20, "Fantastic Rubber Shoes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
