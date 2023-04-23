using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTicket_project.Migrations
{
    /// <inheritdoc />
    public partial class update_movie_model_property : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "movieCategory",
                table: "Movies",
                newName: "MovieCategory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "movieCategory");
        }
    }
}
