using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal_API.Migrations
{
    public partial class OptionalFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "animals",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<bool>(
                name: "SpayedNeutered",
                table: "animals",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "IntakeDate",
                table: "animals",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "GoodWithKids",
                table: "animals",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "GoodWithDogs",
                table: "animals",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "GoodWithCats",
                table: "animals",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<float>(
                name: "Age",
                table: "animals",
                nullable: true,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "animals",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SpayedNeutered",
                table: "animals",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IntakeDate",
                table: "animals",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "GoodWithKids",
                table: "animals",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "GoodWithDogs",
                table: "animals",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "GoodWithCats",
                table: "animals",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Age",
                table: "animals",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);
        }
    }
}
