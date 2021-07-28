using Microsoft.EntityFrameworkCore.Migrations;

namespace ORMDemoUsingEFCore.Migrations
{
    public partial class AddCardType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "CreditCards",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardType",
                table: "CreditCards");
        }
    }
}
