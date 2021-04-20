using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareCost.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Website = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalId);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProcedures",
                columns: table => new
                {
                    MedicalProcedureId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProcedures", x => x.MedicalProcedureId);
                });

            migrationBuilder.CreateTable(
                name: "Specialists",
                columns: table => new
                {
                    SpecialistId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.SpecialistId);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    SpecializationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.SpecializationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "HospitalMedicalProcedures",
                columns: table => new
                {
                    HospitalMedicalProcedureId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HospitalId = table.Column<int>(nullable: false),
                    MedicalProcedureId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalMedicalProcedures", x => x.HospitalMedicalProcedureId);
                    table.ForeignKey(
                        name: "FK_HospitalMedicalProcedures_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalMedicalProcedures_MedicalProcedures_MedicalProcedure~",
                        column: x => x.MedicalProcedureId,
                        principalTable: "MedicalProcedures",
                        principalColumn: "MedicalProcedureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalSpecialist",
                columns: table => new
                {
                    HospitalSpecialistId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HospitalId = table.Column<int>(nullable: false),
                    SpecialistId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalSpecialist", x => x.HospitalSpecialistId);
                    table.ForeignKey(
                        name: "FK_HospitalSpecialist_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalSpecialist_Specialists_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "Specialists",
                        principalColumn: "SpecialistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialistSpecializations",
                columns: table => new
                {
                    SpecialistSpecializationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpecialistId = table.Column<int>(nullable: false),
                    SpecializationId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialistSpecializations", x => x.SpecialistSpecializationId);
                    table.ForeignKey(
                        name: "FK_SpecialistSpecializations_Specialists_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "Specialists",
                        principalColumn: "SpecialistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialistSpecializations_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "SpecializationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalServices",
                columns: table => new
                {
                    MedicalServiceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<double>(nullable: false),
                    HospitalMedicalProcedureId = table.Column<int>(nullable: false),
                    HospitalSpecialistId = table.Column<int>(nullable: false),
                    SpecialistSpecializationId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalServices", x => x.MedicalServiceId);
                    table.ForeignKey(
                        name: "FK_MedicalServices_HospitalMedicalProcedures_HospitalMedicalPro~",
                        column: x => x.HospitalMedicalProcedureId,
                        principalTable: "HospitalMedicalProcedures",
                        principalColumn: "HospitalMedicalProcedureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalServices_HospitalSpecialist_HospitalSpecialistId",
                        column: x => x.HospitalSpecialistId,
                        principalTable: "HospitalSpecialist",
                        principalColumn: "HospitalSpecialistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalServices_SpecialistSpecializations_SpecialistSpeciali~",
                        column: x => x.SpecialistSpecializationId,
                        principalTable: "SpecialistSpecializations",
                        principalColumn: "SpecialistSpecializationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMedicalProcedures_HospitalId",
                table: "HospitalMedicalProcedures",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMedicalProcedures_MedicalProcedureId",
                table: "HospitalMedicalProcedures",
                column: "MedicalProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSpecialist_HospitalId",
                table: "HospitalSpecialist",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSpecialist_SpecialistId",
                table: "HospitalSpecialist",
                column: "SpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalServices_HospitalMedicalProcedureId",
                table: "MedicalServices",
                column: "HospitalMedicalProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalServices_HospitalSpecialistId",
                table: "MedicalServices",
                column: "HospitalSpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalServices_SpecialistSpecializationId",
                table: "MedicalServices",
                column: "SpecialistSpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialistSpecializations_SpecialistId",
                table: "SpecialistSpecializations",
                column: "SpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialistSpecializations_SpecializationId",
                table: "SpecialistSpecializations",
                column: "SpecializationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalServices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "HospitalMedicalProcedures");

            migrationBuilder.DropTable(
                name: "HospitalSpecialist");

            migrationBuilder.DropTable(
                name: "SpecialistSpecializations");

            migrationBuilder.DropTable(
                name: "MedicalProcedures");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Specialists");

            migrationBuilder.DropTable(
                name: "Specializations");
        }
    }
}
