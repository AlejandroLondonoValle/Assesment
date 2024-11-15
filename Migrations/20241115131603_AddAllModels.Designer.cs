﻿// <auto-generated />
using System;
using Assesment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assesment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241115131603_AddAllModels")]
    partial class AddAllModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Assesment.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<int>("MedicateId")
                        .HasColumnType("int")
                        .HasColumnName("medicate_id");

                    b.Property<string>("Note")
                        .HasColumnType("longtext")
                        .HasColumnName("note");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.Property<string>("Reason")
                        .HasColumnType("longtext")
                        .HasColumnName("reason");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("MedicateId");

                    b.HasIndex("PatientId");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("Assesment.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_time");

                    b.Property<int>("MedicateId")
                        .HasColumnType("int")
                        .HasColumnName("medicate_id");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_time");

                    b.HasKey("Id");

                    b.HasIndex("MedicateId");

                    b.ToTable("availabilities");
                });

            modelBuilder.Entity("Assesment.Models.Medicate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailabilityId")
                        .HasColumnType("int")
                        .HasColumnName("availability_id");

                    b.Property<string>("Specialty")
                        .HasColumnType("longtext")
                        .HasColumnName("specialty");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("AvailabilityId");

                    b.HasIndex("UserId");

                    b.ToTable("medicates");
                });

            modelBuilder.Entity("Assesment.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MedicalHistory")
                        .HasColumnType("longtext")
                        .HasColumnName("medical_history");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("Assesment.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .HasColumnType("longtext")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cra 45 67 89",
                            Email = "medico.1@gmail.com",
                            IdentificationNumber = "1027809836",
                            LastName = "Mosquera",
                            Name = "Medico 1",
                            Password = "$2a$11$b11DVcHAaErFa/b9bUuUse6qIeC/JpDeW56rch/3NDtTgjmOwBJPe",
                            Role = "medicate"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cra 45 67 89",
                            Email = "medico.2@gmail.com",
                            IdentificationNumber = "1027809836",
                            LastName = "Londoño",
                            Name = "Medico 2",
                            Password = "$2a$11$8X96kmlcOVNxN8aKtHEOsOu48/NC9ezE4KP1Wswr4cJFT7CP1XU2G",
                            Role = "medicate"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Cra 45 67 89",
                            Email = "medico.3@gmail.com",
                            IdentificationNumber = "1027809836",
                            LastName = "Garcia",
                            Name = "Medico 3",
                            Password = "$2a$11$Sj2pO2tNZqgTr9HBtPfv/.f/eWYHr/vCovuYFa67A9Sd6ZAshZYjS",
                            Role = "medicate"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Cra 45 67 89",
                            Email = "medico.4@gmail.com",
                            IdentificationNumber = "1027809836",
                            LastName = "Yepes",
                            Name = "Medico 4",
                            Password = "$2a$11$9F149Y8FXC8NcQ4GuSg7dO5ez1bnUtPaceVVuVOk8lLHrSFLkT7f.",
                            Role = "medicate"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Cra 45 67 89",
                            Email = "medico.5@gmail.com",
                            IdentificationNumber = "1027809836",
                            LastName = "Alvarez",
                            Name = "Medico 5",
                            Password = "$2a$11$q2rfHOZDihHR3RlOvcyRx.Zmcn.p64Ek4n9puQe5nS/88wZdiypTS",
                            Role = "medicate"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Cra 45 67 89",
                            Email = "medico.6@gmail.com",
                            IdentificationNumber = "1027809836",
                            LastName = "Jimenez",
                            Name = "Medico 6",
                            Password = "$2a$11$csyBHQ6508iuJqEZS6JQa.xE6E1HXJM6c0G4ZdrhTHOYiOEQL3Hfy",
                            Role = "medicate"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Cra 45 67 89",
                            Email = "alejandro.londono@gmail.com",
                            IdentificationNumber = "1027809836",
                            LastName = "Londoño Valle",
                            Name = "Alejandro",
                            Password = "$2a$11$EbYOgWQ5tn0JNwzUSflGjuncq1qQwBpj04M.2lVpxMdT646Kip31.",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Cra 45 67 89",
                            Email = "kevin.alvarez@gmail.com",
                            IdentificationNumber = "1027809836",
                            LastName = "Alvarez Diaz",
                            Name = "Kevin",
                            Password = "$2a$11$h.W8GjZShKBtdpU5Q6Mp7uxr9GpwhaRjMwMli5h/gnE/B2vo6Krmq",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Cra 45 67 89",
                            Email = "nataly.jimenez@gmail.com",
                            IdentificationNumber = "1027809836",
                            LastName = "Jimenez Cardozo",
                            Name = "Nataly",
                            Password = "$2a$11$XpG2Tcl.UfCR/i9uRB.5Ru509kaTyJaYbubWdslEoIvzQDlhgppGC",
                            Role = "patient"
                        });
                });

            modelBuilder.Entity("Assesment.Models.Appointment", b =>
                {
                    b.HasOne("Assesment.Models.Medicate", "Medicate")
                        .WithMany()
                        .HasForeignKey("MedicateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assesment.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicate");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Assesment.Models.Availability", b =>
                {
                    b.HasOne("Assesment.Models.Medicate", "Medicate")
                        .WithMany()
                        .HasForeignKey("MedicateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicate");
                });

            modelBuilder.Entity("Assesment.Models.Medicate", b =>
                {
                    b.HasOne("Assesment.Models.Availability", "Availability")
                        .WithMany()
                        .HasForeignKey("AvailabilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assesment.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Availability");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Assesment.Models.Patient", b =>
                {
                    b.HasOne("Assesment.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}