using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste.Data.Migrations
{
    public partial class CreatingTelephonesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 16, 12, 4, 796, DateTimeKind.Local).AddTicks(6029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 11, 15, 5, 22, 620, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 13, 16, 12, 4, 795, DateTimeKind.Local).AddTicks(6018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 11, 15, 5, 22, 619, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DDD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 11, 15, 5, 22, 620, DateTimeKind.Local).AddTicks(5245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 16, 12, 4, 796, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 11, 15, 5, 22, 619, DateTimeKind.Local).AddTicks(5341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 13, 16, 12, 4, 795, DateTimeKind.Local).AddTicks(6018));
        }
    }
}
