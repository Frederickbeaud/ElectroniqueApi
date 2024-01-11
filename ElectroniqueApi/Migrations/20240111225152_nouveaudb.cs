using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroniqueApi.Migrations
{
    /// <inheritdoc />
    public partial class nouveaudb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClienIn",
                table: "Factures",
                newName: "ClienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClienId",
                table: "Factures",
                newName: "ClienIn");
        }
    }
}
