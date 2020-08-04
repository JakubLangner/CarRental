using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class fixed_mistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_AdditionalEquipments_AdditionalEquipmentId",
                table: "Rents");

            migrationBuilder.AlterColumn<int>(
                name: "AdditionalEquipmentId",
                table: "Rents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_AdditionalEquipments_AdditionalEquipmentId",
                table: "Rents",
                column: "AdditionalEquipmentId",
                principalTable: "AdditionalEquipments",
                principalColumn: "AdditionalEquipmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_AdditionalEquipments_AdditionalEquipmentId",
                table: "Rents");

            migrationBuilder.AlterColumn<int>(
                name: "AdditionalEquipmentId",
                table: "Rents",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_AdditionalEquipments_AdditionalEquipmentId",
                table: "Rents",
                column: "AdditionalEquipmentId",
                principalTable: "AdditionalEquipments",
                principalColumn: "AdditionalEquipmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
