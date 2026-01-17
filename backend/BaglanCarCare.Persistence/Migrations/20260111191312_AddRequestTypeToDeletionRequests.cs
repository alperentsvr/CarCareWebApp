using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaglanCarCare.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRequestTypeToDeletionRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "DeletionRequests",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestType",
                table: "DeletionRequests",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "DeletionRequests");

            migrationBuilder.DropColumn(
                name: "RequestType",
                table: "DeletionRequests");
        }
    }
}
