using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Duolingo" },
                    { 2, "Coding" },
                    { 3, "Languages" }
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "CompletionDate", "Description", "DueDate", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { 1, null, "", new DateTime(2024, 2, 24, 20, 18, 43, 150, DateTimeKind.Utc).AddTicks(7561), (byte)2, (byte)1, "Complete level 7 on Duolingo" },
                    { 2, new DateTime(2024, 2, 23, 8, 18, 43, 150, DateTimeKind.Utc).AddTicks(7724), "At least one challenge must be level 5", new DateTime(2024, 2, 21, 23, 18, 43, 150, DateTimeKind.Utc).AddTicks(7718), (byte)2, (byte)3, "Solve 5 Codewars challenges" },
                    { 3, null, "Finish week 2, day 6", new DateTime(2024, 2, 24, 6, 18, 43, 150, DateTimeKind.Utc).AddTicks(7875), (byte)2, (byte)2, "TTMIK weekly vocab" }
                });

            migrationBuilder.InsertData(
                table: "TagToDo",
                columns: new[] { "TagsId", "ToDosId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TagToDo",
                keyColumns: new[] { "TagsId", "ToDosId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TagToDo",
                keyColumns: new[] { "TagsId", "ToDosId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TagToDo",
                keyColumns: new[] { "TagsId", "ToDosId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TagToDo",
                keyColumns: new[] { "TagsId", "ToDosId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
