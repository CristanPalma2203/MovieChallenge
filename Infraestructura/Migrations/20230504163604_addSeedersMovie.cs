using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class addSeedersMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Category", "CreatedByUserId", "CreatedDate", "Name", "ReleaseYear", "Synopsis" },
                values: new object[,]
                {
                    { 1, "Drama", 1, new DateTime(2023, 5, 4, 16, 36, 4, 572, DateTimeKind.Utc).AddTicks(2346), "The Shawshank Redemption", 1994, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency." },
                    { 2, "Crime", 1, new DateTime(2023, 5, 4, 16, 36, 4, 572, DateTimeKind.Utc).AddTicks(2347), "The Godfather", 1972, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son." },
                    { 3, "Action", 1, new DateTime(2023, 5, 4, 16, 36, 4, 572, DateTimeKind.Utc).AddTicks(2348), "The Dark Knight", 2008, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice." },
                    { 4, "Crime", 1, new DateTime(2023, 5, 4, 16, 36, 4, 572, DateTimeKind.Utc).AddTicks(2348), "Pulp Fiction", 1994, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption." },
                    { 5, "Drama", 1, new DateTime(2023, 5, 4, 16, 36, 4, 572, DateTimeKind.Utc).AddTicks(2349), "Forrest Gump", 1994, "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75." },
                    { 6, "Action", 1, new DateTime(2023, 5, 4, 16, 36, 4, 572, DateTimeKind.Utc).AddTicks(2350), "The Matrix", 1999, "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers." },
                    { 7, "Sci-Fi", 1, new DateTime(2023, 5, 4, 16, 36, 4, 572, DateTimeKind.Utc).AddTicks(2350), "Inception", 2010, "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O." },
                    { 8, "Thriller", 1, new DateTime(2023, 5, 4, 16, 36, 4, 572, DateTimeKind.Utc).AddTicks(2351), "The Silence of the Lambs", 1991, "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims." }
                });

            migrationBuilder.UpdateData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 4, 10, 36, 4, 572, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 4, 10, 36, 4, 572, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 4, 10, 36, 4, 572, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.InsertData(
                table: "RatingMovie",
                columns: new[] { "Id", "MovieId", "Rating", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, 4, 1 },
                    { 2, 1, 3, 1 },
                    { 3, 2, 5, 2 },
                    { 4, 2, 4, 1 },
                    { 5, 2, 2, 2 },
                    { 6, 3, 4, 2 },
                    { 7, 4, 3, 1 },
                    { 8, 5, 5, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RatingMovie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RatingMovie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RatingMovie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RatingMovie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RatingMovie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RatingMovie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RatingMovie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RatingMovie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 4, 10, 16, 50, 921, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 4, 10, 16, 50, 921, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2023, 5, 4, 10, 16, 50, 921, DateTimeKind.Local).AddTicks(2979));
        }
    }
}
