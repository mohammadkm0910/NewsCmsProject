using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsCmsProject.Migrations
{
    public partial class AddUserIdFromTheWeb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "FromTheWebs",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "FromTheWebs",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FromTheWebs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FromTheWebs_UserId",
                table: "FromTheWebs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FromTheWebs_Users_UserId",
                table: "FromTheWebs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FromTheWebs_Users_UserId",
                table: "FromTheWebs");

            migrationBuilder.DropIndex(
                name: "IX_FromTheWebs_UserId",
                table: "FromTheWebs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FromTheWebs");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "FromTheWebs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "FromTheWebs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }
    }
}
