using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroniqueApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LignesFactures_Factures_FactureId1",
                table: "LignesFactures");

            migrationBuilder.DropForeignKey(
                name: "FK_LignesFactures_Products_ProduitId1",
                table: "LignesFactures");

            migrationBuilder.AlterColumn<int>(
                name: "ProduitId1",
                table: "LignesFactures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FactureId1",
                table: "LignesFactures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_LignesFactures_Factures_FactureId1",
                table: "LignesFactures",
                column: "FactureId1",
                principalTable: "Factures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LignesFactures_Products_ProduitId1",
                table: "LignesFactures",
                column: "ProduitId1",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LignesFactures_Factures_FactureId1",
                table: "LignesFactures");

            migrationBuilder.DropForeignKey(
                name: "FK_LignesFactures_Products_ProduitId1",
                table: "LignesFactures");

            migrationBuilder.AlterColumn<int>(
                name: "ProduitId1",
                table: "LignesFactures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FactureId1",
                table: "LignesFactures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LignesFactures_Factures_FactureId1",
                table: "LignesFactures",
                column: "FactureId1",
                principalTable: "Factures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LignesFactures_Products_ProduitId1",
                table: "LignesFactures",
                column: "ProduitId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
