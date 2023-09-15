using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.DAL.Migrations
{
    public partial class noFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anamoly_Equipment_EqId",
                table: "Anamoly");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_Equipment_EqId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_Technician_TechId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Sensor_Equipment_EqId",
                table: "Sensor");

            migrationBuilder.DropIndex(
                name: "IX_Sensor_EqId",
                table: "Sensor");

            migrationBuilder.DropIndex(
                name: "IX_Maintenance_EqId",
                table: "Maintenance");

            migrationBuilder.DropIndex(
                name: "IX_Maintenance_TechId",
                table: "Maintenance");

            migrationBuilder.DropIndex(
                name: "IX_Anamoly_EqId",
                table: "Anamoly");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sensor_EqId",
                table: "Sensor",
                column: "EqId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_EqId",
                table: "Maintenance",
                column: "EqId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_TechId",
                table: "Maintenance",
                column: "TechId");

            migrationBuilder.CreateIndex(
                name: "IX_Anamoly_EqId",
                table: "Anamoly",
                column: "EqId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anamoly_Equipment_EqId",
                table: "Anamoly",
                column: "EqId",
                principalTable: "Equipment",
                principalColumn: "EqId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_Equipment_EqId",
                table: "Maintenance",
                column: "EqId",
                principalTable: "Equipment",
                principalColumn: "EqId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_Technician_TechId",
                table: "Maintenance",
                column: "TechId",
                principalTable: "Technician",
                principalColumn: "TechId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sensor_Equipment_EqId",
                table: "Sensor",
                column: "EqId",
                principalTable: "Equipment",
                principalColumn: "EqId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
