using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal_API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IntakeDate = table.Column<DateTime>(nullable: false),
                    Species = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<float>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Weight = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SpayedNeutered = table.Column<bool>(nullable: false),
                    GoodWithCats = table.Column<bool>(nullable: false),
                    GoodWithDogs = table.Column<bool>(nullable: false),
                    GoodWithKids = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animals", x => x.AnimalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "animals");
        }
    }
}
