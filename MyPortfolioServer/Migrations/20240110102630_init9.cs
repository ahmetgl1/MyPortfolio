using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyPortfolioServer.Migrations
{
    /// <inheritdoc />
    public partial class init9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("14cd02ad-0f6e-40d1-95d0-b19325e339d5"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("230a6b05-2feb-4ac8-b663-da55d06190df"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("78ec30b7-7a24-47fa-96b5-189dae8e2cfb"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("9109591e-0055-4c7b-9b96-205d19af0aed"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("9854dd34-7efb-4ec6-a4d4-b91c87c3133e"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("b8a0de77-941e-4271-9cde-7136dcd93588"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("c306fee8-1a4d-451c-8465-6f6aed2c8f8d"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("cc42c606-490c-46d9-8950-6055b9c69bf7"));

            migrationBuilder.CreateTable(
                name: "Thesises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thesises", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "Status", "URL", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ea5adab-6d18-4d0d-91a8-833958d65487"), "MSSQL", "Database", "mssql.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("2fda360d-ec30-473c-a9e6-679251da9986"), "JavaScript", "Frontend", "javascript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("35b99eb6-2438-41f6-aaba-9ffaacb5740e"), ".NET", "Backend", "NET_Core_Logo.svg.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("52e3d00a-122b-4f05-b022-a760b854c7f3"), "CSS", "Frontend", "css.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("661d88a9-45a3-4da2-b972-72b16d322b44"), "TypeScript", "Frontend", "typescript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("7664e5e3-286d-4c99-9680-a04b9a0767c0"), "HTML", "Frontend", "html.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("9f0a6096-63e9-4695-b398-d4ed00a7fa27"), "MongoDB", "Database", "mongo.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("b4bb205b-b169-48d2-b94f-cb51290f53fc"), "Angular", "Frontend", "angular.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Thesises");

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("1ea5adab-6d18-4d0d-91a8-833958d65487"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("2fda360d-ec30-473c-a9e6-679251da9986"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("35b99eb6-2438-41f6-aaba-9ffaacb5740e"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("52e3d00a-122b-4f05-b022-a760b854c7f3"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("661d88a9-45a3-4da2-b972-72b16d322b44"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("7664e5e3-286d-4c99-9680-a04b9a0767c0"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("9f0a6096-63e9-4695-b398-d4ed00a7fa27"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("b4bb205b-b169-48d2-b94f-cb51290f53fc"));

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "Status", "URL", "UserId" },
                values: new object[,]
                {
                    { new Guid("14cd02ad-0f6e-40d1-95d0-b19325e339d5"), "Angular", "Frontend", "angular.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("230a6b05-2feb-4ac8-b663-da55d06190df"), "CSS", "Frontend", "css.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("78ec30b7-7a24-47fa-96b5-189dae8e2cfb"), ".NET", "Backend", "NET_Core_Logo.svg.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("9109591e-0055-4c7b-9b96-205d19af0aed"), "JavaScript", "Frontend", "javascript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("9854dd34-7efb-4ec6-a4d4-b91c87c3133e"), "TypeScript", "Frontend", "typescript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("b8a0de77-941e-4271-9cde-7136dcd93588"), "MongoDB", "Database", "mongo.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("c306fee8-1a4d-451c-8465-6f6aed2c8f8d"), "HTML", "Frontend", "html.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("cc42c606-490c-46d9-8950-6055b9c69bf7"), "MSSQL", "Database", "mssql.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") }
                });
        }
    }
}
