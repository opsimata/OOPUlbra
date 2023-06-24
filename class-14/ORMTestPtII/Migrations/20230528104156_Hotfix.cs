using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMtest.Migrations
{
    /// <inheritdoc />
    public partial class Hotfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_PersonCityId",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "PersonCityId",
                table: "People",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_People_PersonCityId",
                table: "People",
                newName: "IX_People_CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Cities_CityId",
                table: "People",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_CityId",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "People",
                newName: "PersonCityId");

            migrationBuilder.RenameIndex(
                name: "IX_People_CityId",
                table: "People",
                newName: "IX_People_PersonCityId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Cities_PersonCityId",
                table: "People",
                column: "PersonCityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }
    }
}
