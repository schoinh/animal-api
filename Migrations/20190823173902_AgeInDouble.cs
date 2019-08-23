using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal_API.Migrations
{
    public partial class AgeInDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Age",
                table: "animals",
                nullable: true,
                oldClrType: typeof(float),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Age",
                table: "animals",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
