using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyPortfolioServer.Migrations
{
    /// <inheritdoc />
    public partial class init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Users_UserId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs");

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("004e159b-acd5-406a-8984-fe7c36be0319"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("0d2056a4-0971-4840-b0b0-a5c46977cf66"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("10d92214-dc30-4971-91a0-0e390cef5fe7"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("1545572b-6f41-4abd-a0c5-97b171982895"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("31326848-f5a6-4442-b572-0e72f53cd7e2"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("8fb24e78-93db-416a-ba57-c431fa697778"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("b7318076-626a-463d-b131-55d46028e621"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("e0df6e7a-b081-49a1-b58f-7efa8972621e"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Blogs");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Blogs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "Status", "URL", "UserId" },
                values: new object[,]
                {
                    { new Guid("004e159b-acd5-406a-8984-fe7c36be0319"), "Angular", "Frontend", "angular.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("0d2056a4-0971-4840-b0b0-a5c46977cf66"), "HTML", "Frontend", "html.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("10d92214-dc30-4971-91a0-0e390cef5fe7"), "MongoDB", "Database", "mongo.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("1545572b-6f41-4abd-a0c5-97b171982895"), "MSSQL", "Database", "mssql.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("31326848-f5a6-4442-b572-0e72f53cd7e2"), "CSS", "Frontend", "css.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("8fb24e78-93db-416a-ba57-c431fa697778"), "JavaScript", "Frontend", "javascript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("b7318076-626a-463d-b131-55d46028e621"), "TypeScript", "Frontend", "typescript.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") },
                    { new Guid("e0df6e7a-b081-49a1-b58f-7efa8972621e"), ".NET", "Backend", "NET_Core_Logo.svg.png", new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Users_UserId",
                table: "Blogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
