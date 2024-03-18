using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceRecognitionServer.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_PersonId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "PersonImagea");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_PersonId",
                table: "PersonImagea",
                newName: "IX_PersonImagea_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonImagea",
                table: "PersonImagea",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonImagea_Persons_PersonId",
                table: "PersonImagea",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonImagea_Persons_PersonId",
                table: "PersonImagea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonImagea",
                table: "PersonImagea");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Blogs");

            migrationBuilder.RenameTable(
                name: "PersonImagea",
                newName: "Posts");

            migrationBuilder.RenameIndex(
                name: "IX_PersonImagea_PersonId",
                table: "Posts",
                newName: "IX_Posts_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_PersonId",
                table: "Posts",
                column: "PersonId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
