using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class Addrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Rents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserIdId",
                table: "Rents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarStatus",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rents_UserId1",
                table: "Rents",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_UserIdId",
                table: "Rents",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_AspNetUsers_UserId1",
                table: "Rents",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_AspNetUsers_UserIdId",
                table: "Rents",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_AspNetUsers_UserId1",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_AspNetUsers_UserIdId",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_UserId1",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_UserIdId",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "CarStatus",
                table: "Cars");
        }
    }
}
