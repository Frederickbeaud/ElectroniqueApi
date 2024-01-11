using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectroniqueApi.Migrations
{
    /// <inheritdoc />
    public partial class modifDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "photo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photo",
                table: "Products");
        }
    }
}
