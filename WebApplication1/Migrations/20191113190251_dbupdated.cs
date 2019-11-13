using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class dbupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentssId",
                table: "Reactions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostImagessId",
                table: "Reactions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReactionTypesId",
                table: "Reactions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "FreindsWith",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonsId",
                table: "FreindsWith",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommentssId",
                table: "Commentss",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonsId",
                table: "Commentss",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_CommentssId",
                table: "Reactions",
                column: "CommentssId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_PostId",
                table: "Reactions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_PostImagessId",
                table: "Reactions",
                column: "PostImagessId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_ReactionTypesId",
                table: "Reactions",
                column: "ReactionTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PersonId",
                table: "Posts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImagess_PostId",
                table: "PostImagess",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_FreindsWith_PersonId",
                table: "FreindsWith",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_FreindsWith_PersonsId",
                table: "FreindsWith",
                column: "PersonsId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentss_CommentssId",
                table: "Commentss",
                column: "CommentssId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentss_PersonsId",
                table: "Commentss",
                column: "PersonsId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentss_PostId",
                table: "Commentss",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentss_Commentss_CommentssId",
                table: "Commentss",
                column: "CommentssId",
                principalTable: "Commentss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentss_Persons_PersonsId",
                table: "Commentss",
                column: "PersonsId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentss_Posts_PostId",
                table: "Commentss",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FreindsWith_Persons_PersonId",
                table: "FreindsWith",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FreindsWith_Persons_PersonsId",
                table: "FreindsWith",
                column: "PersonsId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostImagess_Posts_PostId",
                table: "PostImagess",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Persons_PersonId",
                table: "Posts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Commentss_CommentssId",
                table: "Reactions",
                column: "CommentssId",
                principalTable: "Commentss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Posts_PostId",
                table: "Reactions",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_PostImagess_PostImagessId",
                table: "Reactions",
                column: "PostImagessId",
                principalTable: "PostImagess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_ReactionTypes_ReactionTypesId",
                table: "Reactions",
                column: "ReactionTypesId",
                principalTable: "ReactionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentss_Commentss_CommentssId",
                table: "Commentss");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentss_Persons_PersonsId",
                table: "Commentss");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentss_Posts_PostId",
                table: "Commentss");

            migrationBuilder.DropForeignKey(
                name: "FK_FreindsWith_Persons_PersonId",
                table: "FreindsWith");

            migrationBuilder.DropForeignKey(
                name: "FK_FreindsWith_Persons_PersonsId",
                table: "FreindsWith");

            migrationBuilder.DropForeignKey(
                name: "FK_PostImagess_Posts_PostId",
                table: "PostImagess");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Persons_PersonId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Commentss_CommentssId",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Posts_PostId",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_PostImagess_PostImagessId",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_ReactionTypes_ReactionTypesId",
                table: "Reactions");

            migrationBuilder.DropIndex(
                name: "IX_Reactions_CommentssId",
                table: "Reactions");

            migrationBuilder.DropIndex(
                name: "IX_Reactions_PostId",
                table: "Reactions");

            migrationBuilder.DropIndex(
                name: "IX_Reactions_PostImagessId",
                table: "Reactions");

            migrationBuilder.DropIndex(
                name: "IX_Reactions_ReactionTypesId",
                table: "Reactions");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PersonId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_PostImagess_PostId",
                table: "PostImagess");

            migrationBuilder.DropIndex(
                name: "IX_FreindsWith_PersonId",
                table: "FreindsWith");

            migrationBuilder.DropIndex(
                name: "IX_FreindsWith_PersonsId",
                table: "FreindsWith");

            migrationBuilder.DropIndex(
                name: "IX_Commentss_CommentssId",
                table: "Commentss");

            migrationBuilder.DropIndex(
                name: "IX_Commentss_PersonsId",
                table: "Commentss");

            migrationBuilder.DropIndex(
                name: "IX_Commentss_PostId",
                table: "Commentss");

            migrationBuilder.DropColumn(
                name: "CommentssId",
                table: "Reactions");

            migrationBuilder.DropColumn(
                name: "PostImagessId",
                table: "Reactions");

            migrationBuilder.DropColumn(
                name: "ReactionTypesId",
                table: "Reactions");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "FreindsWith");

            migrationBuilder.DropColumn(
                name: "PersonsId",
                table: "FreindsWith");

            migrationBuilder.DropColumn(
                name: "CommentssId",
                table: "Commentss");

            migrationBuilder.DropColumn(
                name: "PersonsId",
                table: "Commentss");
        }
    }
}
