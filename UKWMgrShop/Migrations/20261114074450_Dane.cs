using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UKWMgrShop.Migrations
{
    /// <inheritdoc />
    public partial class Dane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Filmy grozy", "Horror" },
                    { 2, "Filmy komediowe pełne humoru i zabawnych sytuacji", "Komedia" },
                    { 3, "Filmy pełne dynamicznych scen, walk i pościgów", "Akcja" },
                    { 4, "Filmy o przyszłości, kosmosie i zaawansowanej technologii", "Science Fiction" },
                    { 5, "Filmy poruszające trudne tematy i ludzkie emocje", "Dramat" },
                    { 6, "Filmy pełne napięcia, tajemnic i nieoczekiwanych zwrotów akcji", "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CategoryId", "DateAdded", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2013, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Małżeństwo demonologów bada nawiedzony dom, w którym dochodzi do przerażających wydarzeń.", "James Wan", 19.99m, "Obecność" },
                    { 2, 1, new DateTime(1980, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pisarz podejmuje pracę w odizolowanym hotelu, gdzie zaczyna doświadczać przerażających zjawisk.", "Stanley Kubrick", 14.99m, "Lśnienie" },
                    { 3, 1, new DateTime(2017, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupa dzieci musi zmierzyć się z tajemniczym klaunem terroryzującym ich miasteczko.", "Andy Muschietti", 17.99m, "To" },
                    { 4, 1, new DateTime(2004, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dwóch mężczyzn zostaje uwięzionych i zmuszonych do udziału w makabrycznej grze.", "James Wan", 12.99m, "Piła" },
                    { 5, 1, new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dziewczynka zostaje opętana przez demoniczną siłę, a jej rodzina szuka pomocy.", "William Friedkin", 13.99m, "Egzorcysta" },
                    { 6, 2, new DateTime(1994, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nieśmiały pracownik banku znajduje magiczną maskę, która zmienia jego osobowość.", "Chuck Russell", 14.99m, "Maska" },
                    { 7, 2, new DateTime(1990, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ośmioletni Kevin zostaje sam w domu i musi bronić go przed włamywaczami.", "Chris Columbus", 12.99m, "Kevin sam w domu" },
                    { 8, 2, new DateTime(2003, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niezadowolony prezenter telewizyjny otrzymuje boskie moce i próbuje zmienić świat.", "Tom Shadyac", 16.99m, "Bruce Wszechmogący" },
                    { 9, 2, new DateTime(2009, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trzech przyjaciół próbuje odtworzyć wydarzenia szalonej nocy w Las Vegas.", "Todd Phillips", 18.99m, "Kac Vegas" },
                    { 10, 2, new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Młody skrzypek zostaje przypadkowo wciągnięty w świat gangsterów i niebezpiecznych sytuacji.", "Olaf Lubaszenko", 14.99m, "Chłopaki nie płaczą" },
                    { 11, 3, new DateTime(2014, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Były płatny zabójca powraca do świata przestępczego, aby zemścić się na swoich wrogach.", "Chad Stahelski", 19.99m, "John Wick" },
                    { 12, 3, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rzymski generał zostaje zdradzony i zmuszony do walki na arenie jako gladiator.", "Ridley Scott", 16.99m, "Gladiator" },
                    { 13, 3, new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Policjant samotnie stawia czoła grupie terrorystów, którzy opanowali wieżowiec.", "John McTiernan", 14.99m, "Szklana pułapka" },
                    { 14, 3, new DateTime(2015, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "W postapokaliptycznym świecie bohaterowie walczą o przetrwanie podczas szalonego pościgu.", "George Miller", 19.99m, "Mad Max: Na drodze gniewu" },
                    { 15, 3, new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legendarny pilot powraca do szkoły lotniczej, aby szkolić nowe pokolenie pilotów.", "Joseph Kosinski", 19.99m, "Top Gun: Maverick" },
                    { 16, 4, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupa astronautów wyrusza w podróż przez tunel czasoprzestrzenny w poszukiwaniu nowego domu dla ludzkości.", "Christopher Nolan", 19.99m, "Interstellar" },
                    { 17, 4, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haker odkrywa, że rzeczywistość, którą zna, jest jedynie komputerową symulacją.", "Lana Wachowski, Lilly Wachowski", 17.99m, "Matrix" },
                    { 18, 4, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zespół specjalistów potrafi wkradać się do ludzkich snów i manipulować podświadomością.", "Christopher Nolan", 18.99m, "Incepcja" },
                    { 19, 4, new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Były żołnierz trafia na planetę Pandora i poznaje niezwykłą kulturę jej mieszkańców.", "James Cameron", 18.99m, "Avatar" },
                    { 20, 4, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Młody książę trafia na pustynną planetę, która skrywa najcenniejszy surowiec we wszechświecie.", "Denis Villeneuve", 19.99m, "Diuna" },
                    { 21, 5, new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niesłusznie skazany bankier próbuje odnaleźć nadzieję i wolność w więzieniu.", "Frank Darabont", 17.99m, "Skazani na Shawshank" },
                    { 22, 5, new DateTime(1999, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strażnik więzienny poznaje niezwykłego więźnia obdarzonego tajemniczymi zdolnościami.", "Frank Darabont", 18.99m, "Zielona mila" },
                    { 23, 5, new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mężczyzna o niezwykłym spojrzeniu na świat staje się świadkiem ważnych wydarzeń historii USA.", "Robert Zemeckis", 16.99m, "Forrest Gump" },
                    { 24, 5, new DateTime(2002, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poruszająca historia żydowskiego pianisty próbującego przetrwać okupację Warszawy.", "Roman Polański", 17.99m, "Pianista" },
                    { 25, 5, new DateTime(2014, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Młody perkusista marzy o wielkiej karierze i trafia pod opiekę bezwzględnego nauczyciela.", "Damien Chazelle", 18.99m, "Whiplash" },
                    { 26, 6, new DateTime(1995, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dwóch detektywów prowadzi śledztwo w sprawie seryjnego mordercy inspirującego się siedmioma grzechami głównymi.", "David Fincher", 17.99m, "Siedem" },
                    { 27, 6, new DateTime(2010, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dwóch agentów federalnych bada tajemnicze zniknięcie pacjentki ze szpitala psychiatrycznego.", "Martin Scorsese", 18.99m, "Wyspa tajemnic" },
                    { 28, 6, new DateTime(2014, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Po zaginięciu żony mężczyzna staje się głównym podejrzanym w sprawie jej zniknięcia.", "David Fincher", 19.99m, "Zaginiona dziewczyna" },
                    { 29, 6, new DateTime(1991, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agentka FBI szuka pomocy u niebezpiecznego psychiatry, aby schwytać seryjnego mordercę.", "Jonathan Demme", 17.99m, "Milczenie owiec" },
                    { 30, 6, new DateTime(2013, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ojciec z pomocą detektywa desperacko poszukuje swojej zaginionej córki.", "Denis Villeneuve", 18.99m, "Labirynt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
