using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPostSimpleApp.Migrations
{
    /// <inheritdoc />
    public partial class PostTypePostRelationshipwithfluentapi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostType_PostTypeId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostType",
                table: "PostType");

            migrationBuilder.RenameTable(
                name: "PostType",
                newName: "PostTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PostTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PostTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTypes",
                table: "PostTypes",
                column: "PostTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostTypes_PostTypeId",
                table: "Posts",
                column: "PostTypeId",
                principalTable: "PostTypes",
                principalColumn: "PostTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostTypes_PostTypeId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTypes",
                table: "PostTypes");

            migrationBuilder.RenameTable(
                name: "PostTypes",
                newName: "PostType");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PostType",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PostType",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostType",
                table: "PostType",
                column: "PostTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostType_PostTypeId",
                table: "Posts",
                column: "PostTypeId",
                principalTable: "PostType",
                principalColumn: "PostTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
