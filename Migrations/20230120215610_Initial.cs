using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dogo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shelter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decsription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shelter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShelterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dog_Shelter_ShelterId",
                        column: x => x.ShelterId,
                        principalTable: "Shelter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Dog_Shelter",
                columns: table => new
                {
                    DogId = table.Column<int>(type: "int", nullable: false),
                    ShelterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog_Shelter", x => new { x.DogId, x.ShelterId });
                    table.ForeignKey(
                        name: "FK_Dog_Shelter_Dog_DogId",
                        column: x => x.DogId,
                        principalTable: "Dog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dog_Shelter_Shelter_ShelterId",
                        column: x => x.ShelterId,
                        principalTable: "Shelter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dog_ShelterId",
                table: "Dog",
                column: "ShelterId");

            migrationBuilder.CreateIndex(
                name: "IX_Dog_Shelter_ShelterId",
                table: "Dog_Shelter",
                column: "ShelterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dog_Shelter");

            migrationBuilder.DropTable(
                name: "Dog");

            migrationBuilder.DropTable(
                name: "Shelter");
        }
    }
}
