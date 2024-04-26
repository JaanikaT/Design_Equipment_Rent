using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignEquipment.Migrations
{
    /// <inheritdoc />
    public partial class RentEmailRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Rent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Rent",
                type: "longtext",
                nullable: true);
        }
    }
}
