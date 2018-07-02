﻿// <auto-generated />
using System;
using Eodg.MedicalTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Eodg.MedicalTracker.Data.Migrations
{
    [DbContext(typeof(MedicalTrackerContext))]
    [Migration("20180702010245_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.DosageOccurrence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<Guid>("MemberMedicationId");

                    b.Property<DateTime>("ModifiedOn")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("OccurredOn");

                    b.HasKey("Id");

                    b.HasIndex("MemberMedicationId");

                    b.ToTable("DosageOccurrences");
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.DoseMeasurement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("DoseMeasurements");
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.Medication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("ModifiedOn")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.MemberMedication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("DoseFrequencyInHours");

                    b.Property<Guid>("DoseMeasurementId");

                    b.Property<int>("DoseQuantity");

                    b.Property<bool>("HasReminder");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ListingOrder");

                    b.Property<Guid>("MedicationId");

                    b.Property<Guid>("MemberId");

                    b.Property<DateTime>("ModifiedOn");

                    b.HasKey("Id");

                    b.HasIndex("DoseMeasurementId");

                    b.HasIndex("MedicationId");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberMedications");
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.MemberSymptom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ListingOrder");

                    b.Property<Guid>("MemberId");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<Guid>("SymptomId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("SymptomId");

                    b.ToTable("MemberSymptoms");
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.Symptom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.SymptomOccurrence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<Guid>("MemberSymptomId");

                    b.Property<DateTime>("ModifiedOn")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("OccurredOn");

                    b.HasKey("Id");

                    b.HasIndex("MemberSymptomId");

                    b.ToTable("SymptomOccurences");
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.DosageOccurrence", b =>
                {
                    b.HasOne("Eodg.MedicalTracker.Data.Models.MemberMedication", "MemberMedication")
                        .WithMany("DosageOccurrences")
                        .HasForeignKey("MemberMedicationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.MemberMedication", b =>
                {
                    b.HasOne("Eodg.MedicalTracker.Data.Models.DoseMeasurement", "DoseMeasurement")
                        .WithMany("MemberMedications")
                        .HasForeignKey("DoseMeasurementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Eodg.MedicalTracker.Data.Models.Medication", "Medication")
                        .WithMany("MemberMedications")
                        .HasForeignKey("MedicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Eodg.MedicalTracker.Data.Models.Member", "Member")
                        .WithMany("MemberMedications")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.MemberSymptom", b =>
                {
                    b.HasOne("Eodg.MedicalTracker.Data.Models.Member", "Member")
                        .WithMany("MemberSymptoms")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Eodg.MedicalTracker.Data.Models.Symptom", "Symptom")
                        .WithMany("MemberSymptoms")
                        .HasForeignKey("SymptomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Eodg.MedicalTracker.Data.Models.SymptomOccurrence", b =>
                {
                    b.HasOne("Eodg.MedicalTracker.Data.Models.MemberSymptom", "MemberSymptom")
                        .WithMany("SymptomOccurrences")
                        .HasForeignKey("MemberSymptomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
