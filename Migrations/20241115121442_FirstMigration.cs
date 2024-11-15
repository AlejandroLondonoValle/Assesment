using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assesment.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identification_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "address", "email", "identification_number", "last_name", "name", "password", "role" },
                values: new object[,]
                {
                    { 1, "Cra 45 67 89", "medico.1@gmail.com", "1027809836", "Mosquera", "Medico 1", "$2a$11$QUOsByq/CBGNLvdJVTf7huqDoCUNQuyKVbX.tlGI45UYXzNdlBIF.", "medicate" },
                    { 2, "Cra 45 67 89", "medico.2@gmail.com", "1027809836", "Londoño", "Medico 2", "$2a$11$4vK.n4xqyomFCroRz2vXeulaKfWvIadYHpT3OcW8sYXUuHfffDEtq", "medicate" },
                    { 3, "Cra 45 67 89", "medico.3@gmail.com", "1027809836", "Garcia", "Medico 3", "$2a$11$.PhdtqyUe.b0eecvfVKmWuhAGFf7io.42WW9TwKFEdo4waTZwp2NG", "medicate" },
                    { 4, "Cra 45 67 89", "medico.4@gmail.com", "1027809836", "Yepes", "Medico 4", "$2a$11$CwzcoNeBL/mDLwkqTSG7CO0Lc6Wd9X4vF6Di12e.UN.rYS7DQUd/a", "medicate" },
                    { 5, "Cra 45 67 89", "medico.5@gmail.com", "1027809836", "Alvarez", "Medico 5", "$2a$11$kiiI2tUtwLkpd8IVR95LDuwmRvRPp20.LHXL9UUgtsgWpkkF7QA.G", "medicate" },
                    { 6, "Cra 45 67 89", "medico.6@gmail.com", "1027809836", "Jimenez", "Medico 6", "$2a$11$AlIsXm2qCLGHYGhbcGEpS.y.wKlW5xzQsGohIYeNdGqw./zPNlJDi", "medicate" },
                    { 7, "Cra 45 67 89", "alejandro.londono@gmail.com", "1027809836", "Londoño Valle", "Alejandro", "$2a$11$ZQC.EG/iOgfa9NkxWEGMme6uRKPDK9Hp87B3OwtQIaN5o5.cP6p3C", "patient" },
                    { 8, "Cra 45 67 89", "kevin.alvarez@gmail.com", "1027809836", "Alvarez Diaz", "Kevin", "$2a$11$oKcAK9QjLpTrSjQvvmnrMeuwSjk8LBA48msobryoHA0Eb2wt1aKaa", "patient" },
                    { 9, "Cra 45 67 89", "nataly.jimenez@gmail.com", "1027809836", "Jimenez Cardozo", "Nataly", "$2a$11$UuqVzRBXSaXKym.An/JvheDFZfuqcDAREEROCNLC4TZHPE7Vj.p.q", "patient" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
