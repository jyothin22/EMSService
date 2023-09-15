using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EMS.DAL.Migrations
{
    public partial class EMSDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EqId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EqName = table.Column<string>(type: "text", nullable: false),
                    EqDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EqStatus = table.Column<string>(type: "text", nullable: false),
                    EqLocation = table.Column<string>(type: "text", nullable: false),
                    EqType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EqId);
                });

            migrationBuilder.CreateTable(
                name: "Technician",
                columns: table => new
                {
                    TechId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TechName = table.Column<string>(type: "text", nullable: false),
                    TechPhone = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    TechType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technician", x => x.TechId);
                });

            migrationBuilder.CreateTable(
                name: "Anamoly",
                columns: table => new
                {
                    AId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EqId = table.Column<int>(type: "integer", nullable: false),
                    ATimeStamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AType = table.Column<string>(type: "text", nullable: false),
                    ASeverity = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anamoly", x => x.AId);
                    table.ForeignKey(
                        name: "FK_Anamoly_Equipment_EqId",
                        column: x => x.EqId,
                        principalTable: "Equipment",
                        principalColumn: "EqId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    SensorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EqId = table.Column<int>(type: "integer", nullable: false),
                    STimeStamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    STemperature = table.Column<float>(type: "real", nullable: false),
                    SPressure = table.Column<float>(type: "real", nullable: false),
                    SVibration = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.SensorId);
                    table.ForeignKey(
                        name: "FK_Sensor_Equipment_EqId",
                        column: x => x.EqId,
                        principalTable: "Equipment",
                        principalColumn: "EqId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maintenance",
                columns: table => new
                {
                    MaintenanceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EqId = table.Column<int>(type: "integer", nullable: false),
                    MTimeStamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MType = table.Column<string>(type: "text", nullable: false),
                    MDesc = table.Column<string>(type: "text", nullable: false),
                    TechId = table.Column<int>(type: "integer", nullable: false),
                    MStatus = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenance", x => x.MaintenanceId);
                    table.ForeignKey(
                        name: "FK_Maintenance_Equipment_EqId",
                        column: x => x.EqId,
                        principalTable: "Equipment",
                        principalColumn: "EqId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Maintenance_Technician_TechId",
                        column: x => x.TechId,
                        principalTable: "Technician",
                        principalColumn: "TechId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anamoly_EqId",
                table: "Anamoly",
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
                name: "IX_Sensor_EqId",
                table: "Sensor",
                column: "EqId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anamoly");

            migrationBuilder.DropTable(
                name: "Maintenance");

            migrationBuilder.DropTable(
                name: "Sensor");

            migrationBuilder.DropTable(
                name: "Technician");

            migrationBuilder.DropTable(
                name: "Equipment");
        }
    }
}
