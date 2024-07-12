using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Run_Partner.Migrations
{
    /// <inheritdoc />
    public partial class addedusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { new Guid("3d655afc-1939-429f-ac99-cfb3140218f9"), "Ahmed" },
                    { new Guid("dad4aee9-fa78-44eb-ba21-beb10274972f"), "Joha" },
                    { new Guid("f0c07f18-a85b-4b16-860e-5ed4bcee4c83"), "Abbas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d655afc-1939-429f-ac99-cfb3140218f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dad4aee9-fa78-44eb-ba21-beb10274972f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0c07f18-a85b-4b16-860e-5ed4bcee4c83"));
        }
    }
}
