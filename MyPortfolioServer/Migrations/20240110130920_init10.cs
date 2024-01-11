using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyPortfolioServer.Migrations
{
    /// <inheritdoc />
    public partial class init10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsedTechnologies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedTechnologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsedTechnologies_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "Status", "URL", "UserId" },
                values: new object[,]
                {
                    { new Guid("3102f8f6-d0b7-45bb-84e0-9e3ec6e20596"), "HTML", "Frontend", "html.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("40de2973-ed5b-4cbb-a8fb-50ad7c8dcf2b"), "CSS", "Frontend", "css.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("84412608-2bb9-479e-a180-4cda25b61834"), "JavaScript", "Frontend", "javascript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("97a08611-9a6d-4ec9-ba8c-2e190af3846e"), ".NET", "Backend", "NET_Core_Logo.svg.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("ce7400b1-0d44-46fb-938a-f55368db78d5"), "MSSQL", "Database", "mssql.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("e20c1e8f-52b8-44b3-ae72-0e3d02b381fa"), "TypeScript", "Frontend", "typescript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("ea0b3b2c-69b2-48d8-b361-4464d5c7ef23"), "MongoDB", "Database", "mongo.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("efc95eef-6d85-4375-afaf-a8f9d1555715"), "Angular", "Frontend", "angular.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsedTechnologies_ProjectId",
                table: "UsedTechnologies",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsedTechnologies");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("3102f8f6-d0b7-45bb-84e0-9e3ec6e20596"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("40de2973-ed5b-4cbb-a8fb-50ad7c8dcf2b"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("84412608-2bb9-479e-a180-4cda25b61834"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("97a08611-9a6d-4ec9-ba8c-2e190af3846e"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("ce7400b1-0d44-46fb-938a-f55368db78d5"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("e20c1e8f-52b8-44b3-ae72-0e3d02b381fa"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("ea0b3b2c-69b2-48d8-b361-4464d5c7ef23"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("efc95eef-6d85-4375-afaf-a8f9d1555715"));

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
    }
}
