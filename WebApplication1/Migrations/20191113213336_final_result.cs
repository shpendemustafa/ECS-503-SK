using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class final_result : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReactionType",
                table: "Reactions");

            migrationBuilder.AddColumn<int>(
                name: "ReactionTypes",
                table: "Reactions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_ReactionTypes",
                table: "Reactions",
                column: "ReactionTypes");

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_ReactionTypes_ReactionTypes",
                table: "Reactions",
                column: "ReactionTypes",
                principalTable: "ReactionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_ReactionTypes_ReactionTypes",
                table: "Reactions");

            migrationBuilder.DropIndex(
                name: "IX_Reactions_ReactionTypes",
                table: "Reactions");

            migrationBuilder.DropColumn(
                name: "ReactionTypes",
                table: "Reactions");

            migrationBuilder.AddColumn<int>(
                name: "ReactionType",
                table: "Reactions",
                nullable: false,
                defaultValue: 0);
        }
    }
}
