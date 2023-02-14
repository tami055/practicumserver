using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.DBContext.Migrations
{
    /// <inheritdoc />
    public partial class m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_child_user_ParentId",
                table: "child");

            migrationBuilder.DropIndex(
                name: "IX_child_ParentId",
                table: "child");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_child_ParentId",
                table: "child",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_child_user_ParentId",
                table: "child",
                column: "ParentId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
