using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scenarios.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Europe" });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "North America" });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "South America" });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Asia" });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Australia" });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Africa" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 1, 1, null, "Albania" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 2, 1, null, "Andorra" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 3, 1, null, "Austria" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 4, 1, null, "Belarus" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 5, 1, null, "Belgium" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 6, 1, null, "Bosnia and Herzegovina" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 7, 1, null, "Bulgaria" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 8, 1, null, "Croatia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 9, 1, null, "Cyprus" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 10, 1, null, "Czechia/Czech Republic" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 11, 1, null, "Denmark" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 12, 1, null, "Estonia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 13, 1, null, "Finland" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 14, 1, null, "France" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 15, 1, null, "Germany" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 16, 1, null, "Greece" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 17, 1, null, "Hungary" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 18, 1, null, "Iceland" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 19, 1, null, "Ireland" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 20, 1, null, "Italy" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 21, 1, null, "Latvia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 22, 1, null, "Liechtenstein" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 23, 1, null, "Lithuania" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 24, 1, null, "Luxembourg" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 25, 1, null, "Malta" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 26, 1, null, "Moldova" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 27, 1, null, "Monaco" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 28, 1, null, "Montenegro" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 29, 1, null, "Netherlands" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 30, 1, null, "North Macedonia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 31, 1, null, "Norway" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 32, 1, null, "Poland" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 33, 1, null, "Portugal" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 34, 1, null, "Romania" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 35, 1, null, "Russia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 36, 1, null, "San Marino" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 37, 1, null, "Serbia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 38, 1, null, "Slovakia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 39, 1, null, "Slovenia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 40, 1, null, "Spain" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 41, 1, null, "Sweden" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 42, 1, null, "Switzerland" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 43, 1, null, "Turkey" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 44, 1, null, "Ukraine" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 45, 1, null, "United Kingdom" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 46, 1, null, "Vatican City (Holy See)" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 47, 2, null, "Antigua and Barbuda" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 48, 2, null, "Bahamas" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 49, 2, null, "Barbados" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 50, 2, null, "Belize" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 51, 2, null, "Canada" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 52, 2, null, "Costa Rica" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 53, 2, null, "Cuba" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 54, 2, null, "Dominica" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 55, 2, null, "Dominican Republic" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 56, 2, null, "El Salvador" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 57, 2, null, "Grenada" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 58, 2, null, "Guatemala" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 59, 2, null, "Haiti" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 60, 2, null, "Honduras" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 61, 2, null, "Jamaica" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 62, 2, null, "Mexico" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 63, 2, null, "Nicaragua" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 64, 2, null, "Panama" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 65, 2, null, "Saint Kitts and Nevis" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 66, 2, null, "Saint Lucia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 67, 2, null, "Saint Vincent and the Grenadines" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 68, 2, null, "Trinidad and Tobago" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 69, 2, null, "United States of America" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 70, 3, null, "Argentina" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 71, 3, null, "Bolivia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 72, 3, null, "Brazil" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 73, 3, null, "Chile" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 74, 3, null, "Colombia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 75, 3, null, "Ecuador" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 76, 3, null, "Guyana" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 77, 3, null, "Paraguay" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 78, 3, null, "Peru" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 79, 3, null, "Suriname" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 80, 3, null, "Uruguay" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 81, 3, null, "Venezuela" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 82, 4, null, "Afghanistan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 83, 4, null, "Armenia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 84, 4, null, "Azerbaijan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 85, 4, null, "Bahrain" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 86, 4, null, "Bangladesh" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 87, 4, null, "Bhutan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 88, 4, null, "British Indian Ocean Territory" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 89, 4, null, "Brunei" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 90, 4, null, "Cambodia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 91, 4, null, "China" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 92, 4, null, "Georgia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 93, 4, null, "Hong Kong" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 94, 4, null, "India" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 95, 4, null, "Indonesia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 96, 4, null, "Iran" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 97, 4, null, "Iraq" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 98, 4, null, "Israel" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 99, 4, null, "Japan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 100, 4, null, "Jordan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 101, 4, null, "Kazakhstan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 102, 4, null, "Kuwait" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 103, 4, null, "Kyrgyzstan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 104, 4, null, "Laos" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 105, 4, null, "Lebanon" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 106, 4, null, "Macau" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 107, 4, null, "Malaysia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 108, 4, null, "Maldives" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 109, 4, null, "Mongolia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 110, 4, null, "Myanmar" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 111, 4, null, "Nepal" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 112, 4, null, "North Korea" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 113, 4, null, "Oman" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 114, 4, null, "Pakistan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 115, 4, null, "Palestine" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 116, 4, null, "Philippines" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 117, 4, null, "Qatar" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 118, 4, null, "Saudi Arabia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 119, 4, null, "Singapore" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 120, 4, null, "South Korea" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 121, 4, null, "Sri Lanka" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 122, 4, null, "Syria" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 123, 4, null, "Taiwan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 124, 4, null, "Tajikistan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 125, 4, null, "Thailand" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 126, 4, null, "Timor-Leste/East Timor" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 127, 4, null, "Turkmenistan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 128, 4, null, "United Arab Emirates" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 129, 4, null, "Uzbekistan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 130, 4, null, "Vietnam" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 131, 4, null, "Yemen" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 132, 4, null, "Afghanistan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 133, 4, null, "Armenia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 134, 5, null, "Australia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 135, 5, null, "Fiji" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 136, 5, null, "Kiribati" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 137, 5, null, "Marshall Islands" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 138, 5, null, "Micronesia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 139, 5, null, "Nauru" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 140, 5, null, "New Zealand" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 141, 5, null, "Palau" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 142, 5, null, "Papua New Guinea" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 143, 5, null, "Samoa" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 144, 5, null, "Solomon Islands" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 145, 5, null, "Tonga" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 146, 5, null, "Tuvalu" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 147, 5, null, "Vanuatu" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 148, 6, null, "Algeria" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 149, 6, null, "Angola" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 150, 6, null, "Benin" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 151, 6, null, "Botswana" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 152, 6, null, "Burkina Faso" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 153, 6, null, "Burundi" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 154, 6, null, "Cabo Verde/Cape Verde" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 155, 6, null, "Cameroon" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 156, 6, null, "Central African Republic" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 157, 6, null, "Chad" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 158, 6, null, "Comoros" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 159, 6, null, "Congo/Republic of the Congo" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 160, 6, null, "Democratic Republic of the Congo" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 161, 6, null, "Djibouti" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 162, 6, null, "Egypt" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 163, 6, null, "Equatorial Guinea" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 164, 6, null, "Eritrea" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 165, 6, null, "Eswatini (formerly Swaziland)" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 166, 6, null, "Ethiopia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 167, 6, null, "Gabon" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 168, 6, null, "Gambia, The" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 169, 6, null, "Ghana" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 170, 6, null, "Guinea" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 171, 6, null, "Guinea-Bissau" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 172, 6, null, "Ivory Coast/Republic of Côte d'Ivoire" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 173, 6, null, "Kenya" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 174, 6, null, "Lesotho" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 175, 6, null, "Liberia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 176, 6, null, "Libya" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 177, 6, null, "Madagascar" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 178, 6, null, "Malawi" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 179, 6, null, "Mali" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 180, 6, null, "Mauritania" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 181, 6, null, "Mauritius" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 182, 6, null, "Morocco" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 183, 6, null, "Mozambique" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 184, 6, null, "Namibia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 185, 6, null, "Niger" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 186, 6, null, "Nigeria" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 187, 6, null, "Rwanda" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 188, 6, null, "Sao Tome and Principe" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 189, 6, null, "Senegal" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 190, 6, null, "Seychelles" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 191, 6, null, "Sierra Leone" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 192, 6, null, "Somalia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 193, 6, null, "South Africa" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 194, 6, null, "South Sudan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 195, 6, null, "Sudan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 196, 6, null, "Tanzania" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 197, 6, null, "Togo" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 198, 6, null, "Tunisia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 199, 6, null, "Uganda" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 200, 6, null, "Zambia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "Currency", "Name" },
                values: new object[] { 201, 6, null, "Zimbabwe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
