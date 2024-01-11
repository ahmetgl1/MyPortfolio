using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyPortfolioServer.Migrations
{
    /// <inheritdoc />
    public partial class init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("25f5b4ba-857a-47d2-b34f-1e92fadbcdcb"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("575c3152-181a-401c-81ef-71307ba0ef7a"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("863e6d58-70fa-4c0c-b0d1-998df7464ffd"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("97146b8b-f05d-4110-be17-e145079125b6"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("aa7d6511-c50f-414d-b56d-e68842bac704"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("abdd39a8-c930-43ed-bc9d-9daea1159f3f"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("e5818e59-27ee-41df-9b0d-1872676dda4c"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("fd8815cb-9b57-44c7-a238-91c249d6ebe0"));

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

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

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "Status", "URL", "UserId" },
                values: new object[,]
                {
                    { new Guid("25f5b4ba-857a-47d2-b34f-1e92fadbcdcb"), "CSS", "Frontend", "css.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("575c3152-181a-401c-81ef-71307ba0ef7a"), "Angular", "Frontend", "angular.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("863e6d58-70fa-4c0c-b0d1-998df7464ffd"), "JavaScript", "Frontend", "javascript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("97146b8b-f05d-4110-be17-e145079125b6"), ".NET", "Backend", "NET_Core_Logo.svg.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("aa7d6511-c50f-414d-b56d-e68842bac704"), "MSSQL", "Database", "mssql.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("abdd39a8-c930-43ed-bc9d-9daea1159f3f"), "MongoDB", "Database", "mongo.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("e5818e59-27ee-41df-9b0d-1872676dda4c"), "HTML", "Frontend", "html.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("fd8815cb-9b57-44c7-a238-91c249d6ebe0"), "TypeScript", "Frontend", "typescript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") }
                });
        }
    }
}
