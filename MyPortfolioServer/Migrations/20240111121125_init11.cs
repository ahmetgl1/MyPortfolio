using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyPortfolioServer.Migrations
{
    /// <inheritdoc />
    public partial class init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Resume",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "Status", "URL", "UserId" },
                values: new object[,]
                {
                    { new Guid("0eb10c6e-5896-4870-a513-3ad86f135762"), "MongoDB", "Database", "mongo.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("0f851ec8-1b4b-4e30-adb8-df6271b5889f"), "HTML", "Frontend", "html.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("4ea3abff-25af-4778-a867-4ee0d840ffc2"), "CSS", "Frontend", "css.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("67d99907-fa72-46df-ad14-bb36b35b8795"), "MSSQL", "Database", "mssql.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("91bd7b2d-13f5-4aaa-9f2b-180ee38c7130"), "JavaScript", "Frontend", "javascript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("db8291c6-213d-484f-bbaa-bc38fa1beacf"), "TypeScript", "Frontend", "typescript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("e58ef06f-331b-4c20-9870-548989f468f1"), ".NET", "Backend", "NET_Core_Logo.svg.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("f7518fb4-5033-425c-a27c-1eb06f69cf3d"), "Angular", "Frontend", "angular.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("0eb10c6e-5896-4870-a513-3ad86f135762"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("0f851ec8-1b4b-4e30-adb8-df6271b5889f"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("4ea3abff-25af-4778-a867-4ee0d840ffc2"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("67d99907-fa72-46df-ad14-bb36b35b8795"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("91bd7b2d-13f5-4aaa-9f2b-180ee38c7130"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("db8291c6-213d-484f-bbaa-bc38fa1beacf"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("e58ef06f-331b-4c20-9870-548989f468f1"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("f7518fb4-5033-425c-a27c-1eb06f69cf3d"));

            migrationBuilder.DropColumn(
                name: "Resume",
                table: "UserDetails");

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
        }
    }
}
