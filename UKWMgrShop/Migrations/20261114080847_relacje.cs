using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UKWMgrShop.Migrations
{
    /// <inheritdoc />
    public partial class relacje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Films_CategoryId",
                table: "Films",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Categories_CategoryId",
                table: "Films",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Categories_CategoryId",
                table: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Films_CategoryId",
                table: "Films");
        }
    }
}
