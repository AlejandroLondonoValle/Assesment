using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assesment.Migrations
{
    /// <inheritdoc />
    public partial class AddAllModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    medical_history = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.id);
                    table.ForeignKey(
                        name: "FK_patients_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "appointments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    reason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    medicate_id = table.Column<int>(type: "int", nullable: false),
                    patient_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointments", x => x.id);
                    table.ForeignKey(
                        name: "FK_appointments_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "availabilities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    start_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    medicate_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_availabilities", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    specialty = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    availability_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicates", x => x.id);
                    table.ForeignKey(
                        name: "FK_medicates_availabilities_availability_id",
                        column: x => x.availability_id,
                        principalTable: "availabilities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicates_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$b11DVcHAaErFa/b9bUuUse6qIeC/JpDeW56rch/3NDtTgjmOwBJPe");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$8X96kmlcOVNxN8aKtHEOsOu48/NC9ezE4KP1Wswr4cJFT7CP1XU2G");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$Sj2pO2tNZqgTr9HBtPfv/.f/eWYHr/vCovuYFa67A9Sd6ZAshZYjS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$9F149Y8FXC8NcQ4GuSg7dO5ez1bnUtPaceVVuVOk8lLHrSFLkT7f.");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$q2rfHOZDihHR3RlOvcyRx.Zmcn.p64Ek4n9puQe5nS/88wZdiypTS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$csyBHQ6508iuJqEZS6JQa.xE6E1HXJM6c0G4ZdrhTHOYiOEQL3Hfy");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$EbYOgWQ5tn0JNwzUSflGjuncq1qQwBpj04M.2lVpxMdT646Kip31.");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$h.W8GjZShKBtdpU5Q6Mp7uxr9GpwhaRjMwMli5h/gnE/B2vo6Krmq");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$XpG2Tcl.UfCR/i9uRB.5Ru509kaTyJaYbubWdslEoIvzQDlhgppGC");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_medicate_id",
                table: "appointments",
                column: "medicate_id");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_patient_id",
                table: "appointments",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_availabilities_medicate_id",
                table: "availabilities",
                column: "medicate_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicates_availability_id",
                table: "medicates",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicates_user_id",
                table: "medicates",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_patients_user_id",
                table: "patients",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_medicates_medicate_id",
                table: "appointments",
                column: "medicate_id",
                principalTable: "medicates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_availabilities_medicates_medicate_id",
                table: "availabilities",
                column: "medicate_id",
                principalTable: "medicates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_availabilities_medicates_medicate_id",
                table: "availabilities");

            migrationBuilder.DropTable(
                name: "appointments");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "medicates");

            migrationBuilder.DropTable(
                name: "availabilities");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$QUOsByq/CBGNLvdJVTf7huqDoCUNQuyKVbX.tlGI45UYXzNdlBIF.");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$4vK.n4xqyomFCroRz2vXeulaKfWvIadYHpT3OcW8sYXUuHfffDEtq");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$.PhdtqyUe.b0eecvfVKmWuhAGFf7io.42WW9TwKFEdo4waTZwp2NG");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$CwzcoNeBL/mDLwkqTSG7CO0Lc6Wd9X4vF6Di12e.UN.rYS7DQUd/a");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$kiiI2tUtwLkpd8IVR95LDuwmRvRPp20.LHXL9UUgtsgWpkkF7QA.G");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$AlIsXm2qCLGHYGhbcGEpS.y.wKlW5xzQsGohIYeNdGqw./zPNlJDi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$ZQC.EG/iOgfa9NkxWEGMme6uRKPDK9Hp87B3OwtQIaN5o5.cP6p3C");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$oKcAK9QjLpTrSjQvvmnrMeuwSjk8LBA48msobryoHA0Eb2wt1aKaa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 9,
                column: "password",
                value: "$2a$11$UuqVzRBXSaXKym.An/JvheDFZfuqcDAREEROCNLC4TZHPE7Vj.p.q");
        }
    }
}
