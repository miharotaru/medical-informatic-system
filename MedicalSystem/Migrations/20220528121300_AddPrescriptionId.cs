using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalSystems.Migrations
{
    public partial class AddPrescriptionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Appointments");
        }
    }
}
