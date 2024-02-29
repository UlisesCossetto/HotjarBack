using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotjar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BOOKS_INITIAL_INSERTION : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Book",
            columns: new[] { "Id", "Description", "Name", "Author", "Publisher", "ReleaseDate" },
            values: new object[,]
            {
                { 1, "Libro acerca de mafia rusa", "Anna Karenina", "Leo Tolstoy", "Metro-Goldwyn", "2022-10-10T00:00:00.000" },
                { 2, "Un libro acerca del racismo", "To Kill a Mockingbird", "Harper Lee", "Grand Central Publishing", "2022-10-10T00:00:00.000" },
                { 3, "Un libro acerca de un hombre millonario y su amigo", "The Great Gatsby", "F. Scott Fitzgerald’", "Grand Central Publishing", "2022-10-10T00:00:00.000" },
                { 4, "Un libro acerca de muchas generaciones de familias con elementos magicos", "One Hundred Years of Solitude", "Gabriel García Márquez", "Metro-Goldwyn", "2022-10-10T00:00:00.000" },
                { 5, "Un libro acerca de un doctor indio y su amigo profesor ingles", "A Passage to India", "E.M. Forster", "Columbia Pictures", "2022-10-10T00:00:00.000" },
                { 6, "Un libro acerca de un hombre invisible", "Invisible Man", "Ralph Ellison", "Metro-Goldwyn", "2022-10-10T00:00:00.000" },
                { 7, "Un libro acerca de Don Quijote", "Don Quijote", "Miguel de Cervantes", "Project Gutenberg", "2022-10-10T00:00:00.000" },
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "Book",
            keyColumns: new[] { "Id" },
            keyValues: new object[,]
            {
                  { 1 },
                  { 2 },
                  { 3 },
                  { 4 },
                  { 5 },
                  { 6 },
                  { 7 },
            });
        }
    }
}
