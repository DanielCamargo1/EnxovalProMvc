using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NossoEnxoval.Migrations
{
    public partial class @return : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Intens",
                table: "Intens");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Intens");

            migrationBuilder.RenameTable(
                name: "Intens",
                newName: "Itens");

            migrationBuilder.AddColumn<string>(
                name: "Comodo",
                table: "Itens",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Itens",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Itens",
                table: "Itens",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Itens",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "Comodo",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Itens");

            migrationBuilder.RenameTable(
                name: "Itens",
                newName: "Intens");

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Intens",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Intens",
                table: "Intens",
                column: "Id");
        }
    }
}
