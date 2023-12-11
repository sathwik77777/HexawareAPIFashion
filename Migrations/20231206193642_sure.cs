using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FashionHexa.Migrations
{
    public partial class sure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SellerName",
                table: "Sellers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "Sellers",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Sellers",
                newName: "SellerName");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Sellers",
                newName: "SellerId");
        }
    }
}
