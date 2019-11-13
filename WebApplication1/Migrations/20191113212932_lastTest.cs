using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class lastTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_FreindsWith_PersonsId",
                table: "FreindsWith");

            migrationBuilder.DropIndex(
                name: "IX_Commentss_CommentssId",
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
                name: "PersonsId",
                table: "FreindsWith");

            migrationBuilder.DropColumn(
                name: "CommentssId",
                table: "Commentss");

            migrationBuilder.RenameColumn(
                name: "PersonsId",
                table: "Commentss",
                newName: "CommentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Commentss_PersonsId",
                table: "Commentss",
                newName: "IX_Commentss_CommentsId");

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "ReactionTypes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostContent",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PostVideos",
                table: "Posts",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "PostImagess",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PostedBy",
                table: "Commentss",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Commentss",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "DirectMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    TimeYouWrote = table.Column<DateTime>(nullable: false),
                    Person = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DirectMessages_Persons_Person",
                        column: x => x.Person,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostVideoss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileSize = table.Column<int>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostVideoss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostVideoss_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostVideos",
                table: "Posts",
                column: "PostVideos");

            migrationBuilder.CreateIndex(
                name: "IX_Commentss_PostedBy",
                table: "Commentss",
                column: "PostedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DirectMessages_Person",
                table: "DirectMessages",
                column: "Person");

            migrationBuilder.CreateIndex(
                name: "IX_PostVideoss_PostId",
                table: "PostVideoss",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentss_Commentss_CommentsId",
                table: "Commentss",
                column: "CommentsId",
                principalTable: "Commentss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentss_Posts_PostId",
                table: "Commentss",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentss_Persons_PostedBy",
                table: "Commentss",
                column: "PostedBy",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostImagess_Posts_PostId",
                table: "PostImagess",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Persons_PersonId",
                table: "Posts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostVideoss_PostVideos",
                table: "Posts",
                column: "PostVideos",
                principalTable: "PostVideoss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentss_Commentss_CommentsId",
                table: "Commentss");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentss_Posts_PostId",
                table: "Commentss");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentss_Persons_PostedBy",
                table: "Commentss");

            migrationBuilder.DropForeignKey(
                name: "FK_PostImagess_Posts_PostId",
                table: "PostImagess");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Persons_PersonId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostVideoss_PostVideos",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "DirectMessages");

            migrationBuilder.DropTable(
                name: "PostVideoss");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostVideos",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Commentss_PostedBy",
                table: "Commentss");

            migrationBuilder.DropColumn(
                name: "PostVideos",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "CommentsId",
                table: "Commentss",
                newName: "PersonsId");

            migrationBuilder.RenameIndex(
                name: "IX_Commentss_CommentsId",
                table: "Commentss",
                newName: "IX_Commentss_PersonsId");

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "ReactionTypes",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "PostContent",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "PostImagess",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonsId",
                table: "FreindsWith",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostedBy",
                table: "Commentss",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Commentss",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommentssId",
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
                name: "IX_FreindsWith_PersonsId",
                table: "FreindsWith",
                column: "PersonsId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentss_CommentssId",
                table: "Commentss",
                column: "CommentssId");

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
    }
}
