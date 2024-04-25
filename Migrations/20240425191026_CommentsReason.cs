using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignEquipment.Migrations
{
    /// <inheritdoc />
    public partial class CommentsReason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Comments",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Comments");
        }
    }
}
