using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eodg.MedicalTracker.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoseMeasurements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Abbreviation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoseMeasurements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.UniqueConstraint("AK_Members_Email", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberMedications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MemberId = table.Column<Guid>(nullable: false),
                    MedicationId = table.Column<Guid>(nullable: false),
                    DoseQuantity = table.Column<int>(nullable: false),
                    DoseMeasurementId = table.Column<Guid>(nullable: false),
                    DoseFrequencyInHours = table.Column<int>(nullable: false),
                    ListingOrder = table.Column<int>(nullable: false),
                    HasReminder = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberMedications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberMedications_DoseMeasurements_DoseMeasurementId",
                        column: x => x.DoseMeasurementId,
                        principalTable: "DoseMeasurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberMedications_Medications_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberMedications_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberSymptoms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MemberId = table.Column<Guid>(nullable: false),
                    SymptomId = table.Column<Guid>(nullable: false),
                    ListingOrder = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberSymptoms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberSymptoms_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberSymptoms_Symptoms_SymptomId",
                        column: x => x.SymptomId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DosageOccurrences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MemberMedicationId = table.Column<Guid>(nullable: false),
                    OccurredOn = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosageOccurrences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosageOccurrences_MemberMedications_MemberMedicationId",
                        column: x => x.MemberMedicationId,
                        principalTable: "MemberMedications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SymptomOccurences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MemberSymptomId = table.Column<Guid>(nullable: false),
                    OccurredOn = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymptomOccurences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SymptomOccurences_MemberSymptoms_MemberSymptomId",
                        column: x => x.MemberSymptomId,
                        principalTable: "MemberSymptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DosageOccurrences_MemberMedicationId",
                table: "DosageOccurrences",
                column: "MemberMedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberMedications_DoseMeasurementId",
                table: "MemberMedications",
                column: "DoseMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberMedications_MedicationId",
                table: "MemberMedications",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberMedications_MemberId",
                table: "MemberMedications",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberSymptoms_MemberId",
                table: "MemberSymptoms",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberSymptoms_SymptomId",
                table: "MemberSymptoms",
                column: "SymptomId");

            migrationBuilder.CreateIndex(
                name: "IX_SymptomOccurences_MemberSymptomId",
                table: "SymptomOccurences",
                column: "MemberSymptomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DosageOccurrences");

            migrationBuilder.DropTable(
                name: "SymptomOccurences");

            migrationBuilder.DropTable(
                name: "MemberMedications");

            migrationBuilder.DropTable(
                name: "MemberSymptoms");

            migrationBuilder.DropTable(
                name: "DoseMeasurements");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Symptoms");
        }
    }
}
