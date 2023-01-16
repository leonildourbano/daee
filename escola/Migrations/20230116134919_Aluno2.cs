using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace escola.Migrations
{
    /// <inheritdoc />
    public partial class Aluno2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Disponibilidade",
                table: "Aluno",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponibilidade",
                table: "Aluno");
        }
    }
}
