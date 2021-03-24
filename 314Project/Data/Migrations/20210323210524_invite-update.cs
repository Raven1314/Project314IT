using Microsoft.EntityFrameworkCore.Migrations;

namespace _314Project.Data.Migrations
{
    public partial class inviteupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invites_AspNetUsers_ApplicationUserId",
                table: "Invites");

            migrationBuilder.DropIndex(
                name: "IX_Invites_ApplicationUserId",
                table: "Invites");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Invites");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Invites_UserId",
                table: "Invites",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invites_AspNetUsers_UserId",
                table: "Invites",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invites_AspNetUsers_UserId",
                table: "Invites");

            migrationBuilder.DropIndex(
                name: "IX_Invites_UserId",
                table: "Invites");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Invites",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invites_ApplicationUserId",
                table: "Invites",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invites_AspNetUsers_ApplicationUserId",
                table: "Invites",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
