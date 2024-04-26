using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignEquipment.Migrations
{
    /// <inheritdoc />
    public partial class PersonId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rent");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Rent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_PersonId",
                table: "Rent",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Person_PersonId",
                table: "Rent",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Person_PersonId",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_PersonId",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Rent");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rent",
                type: "longtext",
                nullable: true);
        }
    }
}
