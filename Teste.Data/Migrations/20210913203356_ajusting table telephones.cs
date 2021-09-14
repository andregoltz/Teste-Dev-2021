using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste.Data.Migrations
{
    public partial class ajustingtabletelephones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 17, 33, 55, 166, DateTimeKind.Local).AddTicks(4952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 16, 22, 24, 578, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Telephones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 17, 33, 55, 165, DateTimeKind.Local).AddTicks(5131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 16, 22, 24, 577, DateTimeKind.Local).AddTicks(3789));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Telephones");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 16, 22, 24, 578, DateTimeKind.Local).AddTicks(3104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 17, 33, 55, 166, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 16, 22, 24, 577, DateTimeKind.Local).AddTicks(3789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 17, 33, 55, 165, DateTimeKind.Local).AddTicks(5131));
        }
    }
}
