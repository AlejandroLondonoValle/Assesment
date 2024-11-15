﻿// <auto-generated />
using Assesment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assesment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

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
                            Password = "$2a$11$QUOsByq/CBGNLvdJVTf7huqDoCUNQuyKVbX.tlGI45UYXzNdlBIF.",
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
                            Password = "$2a$11$4vK.n4xqyomFCroRz2vXeulaKfWvIadYHpT3OcW8sYXUuHfffDEtq",
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
                            Password = "$2a$11$.PhdtqyUe.b0eecvfVKmWuhAGFf7io.42WW9TwKFEdo4waTZwp2NG",
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
                            Password = "$2a$11$CwzcoNeBL/mDLwkqTSG7CO0Lc6Wd9X4vF6Di12e.UN.rYS7DQUd/a",
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
                            Password = "$2a$11$kiiI2tUtwLkpd8IVR95LDuwmRvRPp20.LHXL9UUgtsgWpkkF7QA.G",
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
                            Password = "$2a$11$AlIsXm2qCLGHYGhbcGEpS.y.wKlW5xzQsGohIYeNdGqw./zPNlJDi",
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
                            Password = "$2a$11$ZQC.EG/iOgfa9NkxWEGMme6uRKPDK9Hp87B3OwtQIaN5o5.cP6p3C",
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
                            Password = "$2a$11$oKcAK9QjLpTrSjQvvmnrMeuwSjk8LBA48msobryoHA0Eb2wt1aKaa",
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
                            Password = "$2a$11$UuqVzRBXSaXKym.An/JvheDFZfuqcDAREEROCNLC4TZHPE7Vj.p.q",
                            Role = "patient"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}