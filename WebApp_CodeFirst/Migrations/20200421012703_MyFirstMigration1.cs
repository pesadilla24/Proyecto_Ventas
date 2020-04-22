using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_CodeFirst.Migrations
{
    public partial class MyFirstMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudad_Vendedor_VendedorId",
                table: "Ciudad");

            migrationBuilder.DropIndex(
                name: "IX_Ciudad_VendedorId",
                table: "Ciudad");

            migrationBuilder.DropColumn(
                name: "VendedorId",
                table: "Ciudad");

            migrationBuilder.RenameColumn(
                name: "Codigo_Ciudad",
                table: "Vendedor",
                newName: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_CiudadId",
                table: "Vendedor",
                column: "CiudadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Ciudad_CiudadId",
                table: "Vendedor",
                column: "CiudadId",
                principalTable: "Ciudad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Ciudad_CiudadId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_CiudadId",
                table: "Vendedor");

            migrationBuilder.RenameColumn(
                name: "CiudadId",
                table: "Vendedor",
                newName: "Codigo_Ciudad");

            migrationBuilder.AddColumn<int>(
                name: "VendedorId",
                table: "Ciudad",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_VendedorId",
                table: "Ciudad",
                column: "VendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudad_Vendedor_VendedorId",
                table: "Ciudad",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
