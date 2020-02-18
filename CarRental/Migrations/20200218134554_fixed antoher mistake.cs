using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class fixedantohermistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_AspNetUsers_UserIdId",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_UserIdId",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "Rents");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Rents",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rents");

            migrationBuilder.AddColumn<string>(
                name: "UserIdId",
                table: "Rents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rents_UserIdId",
                table: "Rents",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_AspNetUsers_UserIdId",
                table: "Rents",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
