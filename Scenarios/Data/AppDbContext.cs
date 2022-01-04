using Microsoft.EntityFrameworkCore;

namespace Scenarios.Data;

public class AppDbContext : DbContext
{

    public DbSet<Continent> Continents { get; set; }

    public DbSet<Country> Countries { get; set; }
    public DbSet<AppTask> Tasks { get; set; }

    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=data.db");
        }

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Continent>()
            .HasData(
                new Continent() { Id = 1, Name = "Europe" },
                new Continent() { Id = 2, Name = "North America" },
                new Continent() { Id = 3, Name = "South America" },
                new Continent() { Id = 4, Name = "Asia" },
                new Continent() { Id = 5, Name = "Australia" },
                new Continent() { Id = 6, Name = "Africa" }
            );

        modelBuilder.Entity<Country>()
            .HasData(
                new Country() { Id = 1, ContinentId = 1, Name = "Albania" },
                new Country() { Id = 2, ContinentId = 1, Name = "Andorra" },
                new Country() { Id = 3, ContinentId = 1, Name = "Austria" },
                new Country() { Id = 4, ContinentId = 1, Name = "Belarus" },
                new Country() { Id = 5, ContinentId = 1, Name = "Belgium" },
                new Country() { Id = 6, ContinentId = 1, Name = "Bosnia and Herzegovina" },
                new Country() { Id = 7, ContinentId = 1, Name = "Bulgaria" },
                new Country() { Id = 8, ContinentId = 1, Name = "Croatia" },
                new Country() { Id = 9, ContinentId = 1, Name = "Cyprus" },
                new Country() { Id = 10, ContinentId = 1, Name = "Czechia/Czech Republic" },
                new Country() { Id = 11, ContinentId = 1, Name = "Denmark" },
                new Country() { Id = 12, ContinentId = 1, Name = "Estonia" },
                new Country() { Id = 13, ContinentId = 1, Name = "Finland" },
                new Country() { Id = 14, ContinentId = 1, Name = "France" },
                new Country() { Id = 15, ContinentId = 1, Name = "Germany" },
                new Country() { Id = 16, ContinentId = 1, Name = "Greece" },
                new Country() { Id = 17, ContinentId = 1, Name = "Hungary" },
                new Country() { Id = 18, ContinentId = 1, Name = "Iceland" },
                new Country() { Id = 19, ContinentId = 1, Name = "Ireland" },
                new Country() { Id = 20, ContinentId = 1, Name = "Italy" },
                new Country() { Id = 21, ContinentId = 1, Name = "Latvia" },
                new Country() { Id = 22, ContinentId = 1, Name = "Liechtenstein" },
                new Country() { Id = 23, ContinentId = 1, Name = "Lithuania" },
                new Country() { Id = 24, ContinentId = 1, Name = "Luxembourg" },
                new Country() { Id = 25, ContinentId = 1, Name = "Malta" },
                new Country() { Id = 26, ContinentId = 1, Name = "Moldova" },
                new Country() { Id = 27, ContinentId = 1, Name = "Monaco" },
                new Country() { Id = 28, ContinentId = 1, Name = "Montenegro" },
                new Country() { Id = 29, ContinentId = 1, Name = "Netherlands" },
                new Country() { Id = 30, ContinentId = 1, Name = "North Macedonia" },
                new Country() { Id = 31, ContinentId = 1, Name = "Norway" },
                new Country() { Id = 32, ContinentId = 1, Name = "Poland" },
                new Country() { Id = 33, ContinentId = 1, Name = "Portugal" },
                new Country() { Id = 34, ContinentId = 1, Name = "Romania" },
                new Country() { Id = 35, ContinentId = 1, Name = "Russia" },
                new Country() { Id = 36, ContinentId = 1, Name = "San Marino" },
                new Country() { Id = 37, ContinentId = 1, Name = "Serbia" },
                new Country() { Id = 38, ContinentId = 1, Name = "Slovakia" },
                new Country() { Id = 39, ContinentId = 1, Name = "Slovenia" },
                new Country() { Id = 40, ContinentId = 1, Name = "Spain" },
                new Country() { Id = 41, ContinentId = 1, Name = "Sweden" },
                new Country() { Id = 42, ContinentId = 1, Name = "Switzerland" },
                new Country() { Id = 43, ContinentId = 1, Name = "Turkey" },
                new Country() { Id = 44, ContinentId = 1, Name = "Ukraine" },
                new Country() { Id = 45, ContinentId = 1, Name = "United Kingdom" },
                new Country() { Id = 46, ContinentId = 1, Name = "Vatican City (Holy See)"},
                new Country() { Id = 47, ContinentId = 2, Name = "Antigua and Barbuda" },
                new Country() { Id = 48, ContinentId = 2, Name = "Bahamas" },
                new Country() { Id = 49, ContinentId = 2, Name = "Barbados" },
                new Country() { Id = 50, ContinentId = 2, Name = "Belize" },
                new Country() { Id = 51, ContinentId = 2, Name = "Canada" },
                new Country() { Id = 52, ContinentId = 2, Name = "Costa Rica" },
                new Country() { Id = 53, ContinentId = 2, Name = "Cuba" },
                new Country() { Id = 54, ContinentId = 2, Name = "Dominica" },
                new Country() { Id = 55, ContinentId = 2, Name = "Dominican Republic" },
                new Country() { Id = 56, ContinentId = 2, Name = "El Salvador" },
                new Country() { Id = 57, ContinentId = 2, Name = "Grenada" },
                new Country() { Id = 58, ContinentId = 2, Name = "Guatemala" },
                new Country() { Id = 59, ContinentId = 2, Name = "Haiti" },
                new Country() { Id = 60, ContinentId = 2, Name = "Honduras" },
                new Country() { Id = 61, ContinentId = 2, Name = "Jamaica" },
                new Country() { Id = 62, ContinentId = 2, Name = "Mexico" },
                new Country() { Id = 63, ContinentId = 2, Name = "Nicaragua" },
                new Country() { Id = 64, ContinentId = 2, Name = "Panama" },
                new Country() { Id = 65, ContinentId = 2, Name = "Saint Kitts and Nevis" },
                new Country() { Id = 66, ContinentId = 2, Name = "Saint Lucia" },
                new Country() { Id = 67, ContinentId = 2, Name = "Saint Vincent and the Grenadines" },
                new Country() { Id = 68, ContinentId = 2, Name = "Trinidad and Tobago" },
                new Country() { Id = 69, ContinentId = 2, Name = "United States of America" },
                new Country() { Id = 70, ContinentId = 3, Name = "Argentina" },
                new Country() { Id = 71, ContinentId = 3, Name = "Bolivia" },
                new Country() { Id = 72, ContinentId = 3, Name = "Brazil" },
                new Country() { Id = 73, ContinentId = 3, Name = "Chile" },
                new Country() { Id = 74, ContinentId = 3, Name = "Colombia" },
                new Country() { Id = 75, ContinentId = 3, Name = "Ecuador" },
                new Country() { Id = 76, ContinentId = 3, Name = "Guyana" },
                new Country() { Id = 77, ContinentId = 3, Name = "Paraguay" },
                new Country() { Id = 78, ContinentId = 3, Name = "Peru" },
                new Country() { Id = 79, ContinentId = 3, Name = "Suriname" },
                new Country() { Id = 80, ContinentId = 3, Name = "Uruguay" },
                new Country() { Id = 81, ContinentId = 3, Name = "Venezuela" },
                new Country() { Id = 82, ContinentId = 4, Name = "Afghanistan" },
                new Country() { Id = 83, ContinentId = 4, Name = "Armenia" },
                new Country() { Id = 84, ContinentId = 4, Name = "Azerbaijan" },
                new Country() { Id = 85, ContinentId = 4, Name = "Bahrain" },
                new Country() { Id = 86, ContinentId = 4, Name = "Bangladesh" },
                new Country() { Id = 87, ContinentId = 4, Name = "Bhutan" },
                new Country() { Id = 88, ContinentId = 4, Name = "British Indian Ocean Territory" },
                new Country() { Id = 89, ContinentId = 4, Name = "Brunei" },
                new Country() { Id = 90, ContinentId = 4, Name = "Cambodia" },
                new Country() { Id = 91, ContinentId = 4, Name = "China" },
                new Country() { Id = 92, ContinentId = 4, Name = "Georgia" },
                new Country() { Id = 93, ContinentId = 4, Name = "Hong Kong" },
                new Country() { Id = 94, ContinentId = 4, Name = "India" },
                new Country() { Id = 95, ContinentId = 4, Name = "Indonesia" },
                new Country() { Id = 96, ContinentId = 4, Name = "Iran" },
                new Country() { Id = 97, ContinentId = 4, Name = "Iraq" },
                new Country() { Id = 98, ContinentId = 4, Name = "Israel" },
                new Country() { Id = 99, ContinentId = 4, Name = "Japan" },
                new Country() { Id = 100, ContinentId = 4, Name = "Jordan" },
                new Country() { Id = 101, ContinentId = 4, Name = "Kazakhstan" },
                new Country() { Id = 102, ContinentId = 4, Name = "Kuwait" },
                new Country() { Id = 103, ContinentId = 4, Name = "Kyrgyzstan" },
                new Country() { Id = 104, ContinentId = 4, Name = "Laos" },
                new Country() { Id = 105, ContinentId = 4, Name = "Lebanon" },
                new Country() { Id = 106, ContinentId = 4, Name = "Macau" },
                new Country() { Id = 107, ContinentId = 4, Name = "Malaysia" },
                new Country() { Id = 108, ContinentId = 4, Name = "Maldives" },
                new Country() { Id = 109, ContinentId = 4, Name = "Mongolia" },
                new Country() { Id = 110, ContinentId = 4, Name = "Myanmar" },
                new Country() { Id = 111, ContinentId = 4, Name = "Nepal" },
                new Country() { Id = 112, ContinentId = 4, Name = "North Korea" },
                new Country() { Id = 113, ContinentId = 4, Name = "Oman" },
                new Country() { Id = 114, ContinentId = 4, Name = "Pakistan" },
                new Country() { Id = 115, ContinentId = 4, Name = "Palestine" },
                new Country() { Id = 116, ContinentId = 4, Name = "Philippines" },
                new Country() { Id = 117, ContinentId = 4, Name = "Qatar" },
                new Country() { Id = 118, ContinentId = 4, Name = "Saudi Arabia" },
                new Country() { Id = 119, ContinentId = 4, Name = "Singapore" },
                new Country() { Id = 120, ContinentId = 4, Name = "South Korea" },
                new Country() { Id = 121, ContinentId = 4, Name = "Sri Lanka" },
                new Country() { Id = 122, ContinentId = 4, Name = "Syria" },
                new Country() { Id = 123, ContinentId = 4, Name = "Taiwan" },
                new Country() { Id = 124, ContinentId = 4, Name = "Tajikistan" },
                new Country() { Id = 125, ContinentId = 4, Name = "Thailand" },
                new Country() { Id = 126, ContinentId = 4, Name = "Timor-Leste/East Timor" },
                new Country() { Id = 127, ContinentId = 4, Name = "Turkmenistan" },
                new Country() { Id = 128, ContinentId = 4, Name = "United Arab Emirates" },
                new Country() { Id = 129, ContinentId = 4, Name = "Uzbekistan" },
                new Country() { Id = 130, ContinentId = 4, Name = "Vietnam" },
                new Country() { Id = 131, ContinentId = 4, Name = "Yemen" },
                new Country() { Id = 132, ContinentId = 4, Name = "Afghanistan" },
                new Country() { Id = 133, ContinentId = 4, Name = "Armenia" },
                new Country() { Id = 134, ContinentId = 5, Name = "Australia" },
                new Country() { Id = 135, ContinentId = 5, Name = "Fiji" },
                new Country() { Id = 136, ContinentId = 5, Name = "Kiribati" },
                new Country() { Id = 137, ContinentId = 5, Name = "Marshall Islands"},
                new Country() { Id = 138, ContinentId = 5, Name = "Micronesia" },
                new Country() { Id = 139, ContinentId = 5, Name = "Nauru" },
                new Country() { Id = 140, ContinentId = 5, Name = "New Zealand" },
                new Country() { Id = 141, ContinentId = 5, Name = "Palau" },
                new Country() { Id = 142, ContinentId = 5, Name = "Papua New Guinea" },
                new Country() { Id = 143, ContinentId = 5, Name = "Samoa" },
                new Country() { Id = 144, ContinentId = 5, Name = "Solomon Islands" },
                new Country() { Id = 145, ContinentId = 5, Name = "Tonga" },
                new Country() { Id = 146, ContinentId = 5, Name = "Tuvalu" },
                new Country() { Id = 147, ContinentId = 5, Name = "Vanuatu" },
                new Country() { Id = 148, ContinentId = 6, Name = "Algeria" },
                new Country() { Id = 149, ContinentId = 6, Name = "Angola" },
                new Country() { Id = 150, ContinentId = 6, Name = "Benin" },
                new Country() { Id = 151, ContinentId = 6, Name = "Botswana" },
                new Country() { Id = 152, ContinentId = 6, Name = "Burkina Faso" },
                new Country() { Id = 153, ContinentId = 6, Name = "Burundi" },
                new Country() { Id = 154, ContinentId = 6, Name = "Cabo Verde/Cape Verde" },
                new Country() { Id = 155, ContinentId = 6, Name = "Cameroon" },
                new Country() { Id = 156, ContinentId = 6, Name = "Central African Republic" },
                new Country() { Id = 157, ContinentId = 6, Name = "Chad" },
                new Country() { Id = 158, ContinentId = 6, Name = "Comoros" },
                new Country() { Id = 159, ContinentId = 6, Name = "Congo/Republic of the Congo" },
                new Country() { Id = 160, ContinentId = 6, Name = "Democratic Republic of the Congo" },
                new Country() { Id = 161, ContinentId = 6, Name = "Djibouti" },
                new Country() { Id = 162, ContinentId = 6, Name = "Egypt" },
                new Country() { Id = 163, ContinentId = 6, Name = "Equatorial Guinea" },
                new Country() { Id = 164, ContinentId = 6, Name = "Eritrea" },
                new Country() { Id = 165, ContinentId = 6, Name = "Eswatini (formerly Swaziland)" },
                new Country() { Id = 166, ContinentId = 6, Name = "Ethiopia" },
                new Country() { Id = 167, ContinentId = 6, Name = "Gabon" },
                new Country() { Id = 168, ContinentId = 6, Name = "Gambia, The" },
                new Country() { Id = 169, ContinentId = 6, Name = "Ghana" },
                new Country() { Id = 170, ContinentId = 6, Name = "Guinea" },
                new Country() { Id = 171, ContinentId = 6, Name = "Guinea-Bissau" },
                new Country() { Id = 172, ContinentId = 6, Name = "Ivory Coast/Republic of Côte d'Ivoire" },
                new Country() { Id = 173, ContinentId = 6, Name = "Kenya" },
                new Country() { Id = 174, ContinentId = 6, Name = "Lesotho" },
                new Country() { Id = 175, ContinentId = 6, Name = "Liberia" },
                new Country() { Id = 176, ContinentId = 6, Name = "Libya" },
                new Country() { Id = 177, ContinentId = 6, Name = "Madagascar" },
                new Country() { Id = 178, ContinentId = 6, Name = "Malawi" },
                new Country() { Id = 179, ContinentId = 6, Name = "Mali" },
                new Country() { Id = 180, ContinentId = 6, Name = "Mauritania" },
                new Country() { Id = 181, ContinentId = 6, Name = "Mauritius" },
                new Country() { Id = 182, ContinentId = 6, Name = "Morocco" },
                new Country() { Id = 183, ContinentId = 6, Name = "Mozambique" },
                new Country() { Id = 184, ContinentId = 6, Name = "Namibia" },
                new Country() { Id = 185, ContinentId = 6, Name = "Niger" },
                new Country() { Id = 186, ContinentId = 6, Name = "Nigeria" },
                new Country() { Id = 187, ContinentId = 6, Name = "Rwanda" },
                new Country() { Id = 188, ContinentId = 6, Name = "Sao Tome and Principe" },
                new Country() { Id = 189, ContinentId = 6, Name = "Senegal" },
                new Country() { Id = 190, ContinentId = 6, Name = "Seychelles" },
                new Country() { Id = 191, ContinentId = 6, Name = "Sierra Leone" },
                new Country() { Id = 192, ContinentId = 6, Name = "Somalia" },
                new Country() { Id = 193, ContinentId = 6, Name = "South Africa" },
                new Country() { Id = 194, ContinentId = 6, Name = "South Sudan" },
                new Country() { Id = 195, ContinentId = 6, Name = "Sudan" },
                new Country() { Id = 196, ContinentId = 6, Name = "Tanzania" },
                new Country() { Id = 197, ContinentId = 6, Name = "Togo" },
                new Country() { Id = 198, ContinentId = 6, Name = "Tunisia" },
                new Country() { Id = 199, ContinentId = 6, Name = "Uganda" },
                new Country() { Id = 200, ContinentId = 6, Name = "Zambia" },
                new Country() { Id = 201, ContinentId = 6, Name = "Zimbabwe" }
            );

        modelBuilder.Entity<Country>()
            .Property("Name")
            .HasColumnType("TEXT COLLATE NOCASE");

        modelBuilder.Entity<AppTask>()
            .HasData(
                new AppTask() { Id = 1, Text = "Go shopping" },
                new AppTask() { Id = 2, Text = "Walk the dog", IsCompleted = true }
            );
    }
}