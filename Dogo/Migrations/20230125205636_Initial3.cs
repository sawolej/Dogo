using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dogo.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dog_Shelter_ShelterId",
                table: "Dog");

            migrationBuilder.DropColumn(
                name: "Shelter",
                table: "Dog");

            migrationBuilder.AlterColumn<int>(
                name: "ShelterId",
                table: "Dog",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dog_Shelter_ShelterId",
                table: "Dog",
                column: "ShelterId",
                principalTable: "Shelter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dog_Shelter_ShelterId",
                table: "Dog");

            migrationBuilder.AlterColumn<int>(
                name: "ShelterId",
                table: "Dog",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Shelter",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Dog_Shelter_ShelterId",
                table: "Dog",
                column: "ShelterId",
                principalTable: "Shelter",
                principalColumn: "Id");
        }
    }
}
