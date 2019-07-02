﻿// <auto-generated />
using System;
using HealthCareSystem.DbContextFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthCareSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190510080947_creatingRoles")]
    partial class creatingRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthCareSystem.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("DoctorId");

                    b.Property<int>("PatientId");

                    b.Property<int>("TimeId");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("TimeId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("HealthCareSystem.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ambulance");

                    b.Property<int>("FacilityId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Password");

                    b.Property<int>("TitleId")
                        .HasMaxLength(200);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.HasIndex("TitleId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HealthCareSystem.Models.DoctorShift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("DoctorId");

                    b.Property<string>("Shift")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("DoctorShifts");
                });

            modelBuilder.Entity("HealthCareSystem.Models.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("HealthCareSystem.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<DateTime>("DateOfBirth")
                        .HasMaxLength(50);

                    b.Property<int>("DoctorId");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("HasAppointment");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HealthCareSystem.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HealthCareSystem.Models.Tehnician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacilityId");

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Password");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Tehnicians");
                });

            modelBuilder.Entity("HealthCareSystem.Models.TehnicianShift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Shift")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("TehnicianId");

                    b.HasKey("Id");

                    b.HasIndex("TehnicianId");

                    b.ToTable("TehniciansShifts");
                });

            modelBuilder.Entity("HealthCareSystem.Models.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppointmentTime")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("HealthCareSystem.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsSpecialist");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("HealthCareSystem.Models.Appointment", b =>
                {
                    b.HasOne("HealthCareSystem.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthCareSystem.Models.Time", "Time")
                        .WithMany()
                        .HasForeignKey("TimeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthCareSystem.Models.Doctor", b =>
                {
                    b.HasOne("HealthCareSystem.Models.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthCareSystem.Models.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthCareSystem.Models.DoctorShift", b =>
                {
                    b.HasOne("HealthCareSystem.Models.Doctor", "Doctor")
                        .WithMany("DoctorShifts")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthCareSystem.Models.Patient", b =>
                {
                    b.HasOne("HealthCareSystem.Models.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthCareSystem.Models.TehnicianShift", b =>
                {
                    b.HasOne("HealthCareSystem.Models.Tehnician", "Tehnician")
                        .WithMany()
                        .HasForeignKey("TehnicianId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
