using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class changeduseridvalue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_AspNetUsers_UserId1",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_UserId1",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Rents");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Rents_UserId",
                table: "Rents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_AspNetUsers_UserId",
                table: "Rents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_AspNetUsers_UserId",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_UserId",
                table: "Rents");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Rents",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Rents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rents_UserId1",
                table: "Rents",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_AspNetUsers_UserId1",
                table: "Rents",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
