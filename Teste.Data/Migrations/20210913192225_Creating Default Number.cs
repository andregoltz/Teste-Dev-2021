using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste.Data.Migrations
{
    public partial class CreatingDefaultNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 16, 22, 24, 578, DateTimeKind.Local).AddTicks(3104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 16, 12, 4, 796, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 16, 22, 24, 577, DateTimeKind.Local).AddTicks(3789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 16, 12, 4, 795, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.InsertData(
                table: "Telephones",
                columns: new[] { "Id", "DDD", "IdClient", "TelephoneNumber" },
                values: new object[] { 1, "041", new Guid("198770ac-2cea-4b6e-a272-82c6816939f7"), "999999999" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 16, 12, 4, 796, DateTimeKind.Local).AddTicks(6029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 16, 22, 24, 578, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 16, 12, 4, 795, DateTimeKind.Local).AddTicks(6018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 16, 22, 24, 577, DateTimeKind.Local).AddTicks(3789));
        }
    }
}
