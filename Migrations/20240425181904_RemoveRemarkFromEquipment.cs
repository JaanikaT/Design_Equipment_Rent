using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignEquipment.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRemarkFromEquipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Equipment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Equipment",
                type: "longtext",
                nullable: true);
        }
    }
}
