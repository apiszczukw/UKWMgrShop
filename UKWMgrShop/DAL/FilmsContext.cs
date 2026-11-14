
using Microsoft.EntityFrameworkCore;
using UKWMgrShop.Models;

namespace UKWMgrShop.DAL
{
    public class FilmsContext : DbContext
    {
        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Film> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Horror",
                    Desc = "Filmy grozy"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Komedia",
                    Desc = "Filmy komediowe pełne humoru i zabawnych sytuacji"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Akcja",
                    Desc = "Filmy pełne dynamicznych scen, walk i pościgów"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Science Fiction",
                    Desc = "Filmy o przyszłości, kosmosie i zaawansowanej technologii"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Dramat",
                    Desc = "Filmy poruszające trudne tematy i ludzkie emocje"
                },
                new Category()
                {
                    Id = 6,
                    Name = "Thriller",
                    Desc = "Filmy pełne napięcia, tajemnic i nieoczekiwanych zwrotów akcji"
                }
            };

            modelBuilder.Entity<Category>().HasData(categories);

            var films = new List<Film>()
{
    // HORROR (CategoryId = 1)
    new Film()
    {
        Id = 1,
        Title = "Obecność",
        Director = "James Wan",
        Desc = "Małżeństwo demonologów bada nawiedzony dom, w którym dochodzi do przerażających wydarzeń.",
        Price = 19.99m,
        CategoryId = 1,
        DateAdded = new DateTime(2013, 7, 19)
    },
    new Film()
    {
        Id = 2,
        Title = "Lśnienie",
        Director = "Stanley Kubrick",
        Desc = "Pisarz podejmuje pracę w odizolowanym hotelu, gdzie zaczyna doświadczać przerażających zjawisk.",
        Price = 14.99m,
        CategoryId = 1,
        DateAdded = new DateTime(1980, 5, 23)
    },
    new Film()
    {
        Id = 3,
        Title = "To",
        Director = "Andy Muschietti",
        Desc = "Grupa dzieci musi zmierzyć się z tajemniczym klaunem terroryzującym ich miasteczko.",
        Price = 17.99m,
        CategoryId = 1,
        DateAdded = new DateTime(2017, 9, 8)
    },
    new Film()
    {
        Id = 4,
        Title = "Piła",
        Director = "James Wan",
        Desc = "Dwóch mężczyzn zostaje uwięzionych i zmuszonych do udziału w makabrycznej grze.",
        Price = 12.99m,
        CategoryId = 1,
        DateAdded = new DateTime(2004, 10, 29)
    },
    new Film()
    {
        Id = 5,
        Title = "Egzorcysta",
        Director = "William Friedkin",
        Desc = "Dziewczynka zostaje opętana przez demoniczną siłę, a jej rodzina szuka pomocy.",
        Price = 13.99m,
        CategoryId = 1,
        DateAdded = new DateTime(1973, 12, 26)
    },

    // KOMEDIA (CategoryId = 2)
    new Film()
    {
        Id = 6,
        Title = "Maska",
        Director = "Chuck Russell",
        Desc = "Nieśmiały pracownik banku znajduje magiczną maskę, która zmienia jego osobowość.",
        Price = 14.99m,
        CategoryId = 2,
        DateAdded = new DateTime(1994, 7, 29)
    },
    new Film()
    {
        Id = 7,
        Title = "Kevin sam w domu",
        Director = "Chris Columbus",
        Desc = "Ośmioletni Kevin zostaje sam w domu i musi bronić go przed włamywaczami.",
        Price = 12.99m,
        CategoryId = 2,
        DateAdded = new DateTime(1990, 11, 16)
    },
    new Film()
    {
        Id = 8,
        Title = "Bruce Wszechmogący",
        Director = "Tom Shadyac",
        Desc = "Niezadowolony prezenter telewizyjny otrzymuje boskie moce i próbuje zmienić świat.",
        Price = 16.99m,
        CategoryId = 2,
        DateAdded = new DateTime(2003, 5, 23)
    },
    new Film()
    {
        Id = 9,
        Title = "Kac Vegas",
        Director = "Todd Phillips",
        Desc = "Trzech przyjaciół próbuje odtworzyć wydarzenia szalonej nocy w Las Vegas.",
        Price = 18.99m,
        CategoryId = 2,
        DateAdded = new DateTime(2009, 6, 5)
    },
    new Film()
    {
        Id = 10,
        Title = "Chłopaki nie płaczą",
        Director = "Olaf Lubaszenko",
        Desc = "Młody skrzypek zostaje przypadkowo wciągnięty w świat gangsterów i niebezpiecznych sytuacji.",
        Price = 14.99m,
        CategoryId = 2,
        DateAdded = new DateTime(2000, 2, 25)
    },

    // AKCJA (CategoryId = 3)
    new Film()
    {
        Id = 11,
        Title = "John Wick",
        Director = "Chad Stahelski",
        Desc = "Były płatny zabójca powraca do świata przestępczego, aby zemścić się na swoich wrogach.",
        Price = 19.99m,
        CategoryId = 3,
        DateAdded = new DateTime(2014, 10, 24)
    },
    new Film()
    {
        Id = 12,
        Title = "Gladiator",
        Director = "Ridley Scott",
        Desc = "Rzymski generał zostaje zdradzony i zmuszony do walki na arenie jako gladiator.",
        Price = 16.99m,
        CategoryId = 3,
        DateAdded = new DateTime(2000, 5, 5)
    },
    new Film()
    {
        Id = 13,
        Title = "Szklana pułapka",
        Director = "John McTiernan",
        Desc = "Policjant samotnie stawia czoła grupie terrorystów, którzy opanowali wieżowiec.",
        Price = 14.99m,
        CategoryId = 3,
        DateAdded = new DateTime(1988, 7, 15)
    },
    new Film()
    {
        Id = 14,
        Title = "Mad Max: Na drodze gniewu",
        Director = "George Miller",
        Desc = "W postapokaliptycznym świecie bohaterowie walczą o przetrwanie podczas szalonego pościgu.",
        Price = 19.99m,
        CategoryId = 3,
        DateAdded = new DateTime(2015, 5, 15)
    },
    new Film()
    {
        Id = 15,
        Title = "Top Gun: Maverick",
        Director = "Joseph Kosinski",
        Desc = "Legendarny pilot powraca do szkoły lotniczej, aby szkolić nowe pokolenie pilotów.",
        Price = 19.99m,
        CategoryId = 3,
        DateAdded = new DateTime(2022, 5, 27)
    },

    // SCIENCE FICTION (CategoryId = 4)
    new Film()
    {
        Id = 16,
        Title = "Interstellar",
        Director = "Christopher Nolan",
        Desc = "Grupa astronautów wyrusza w podróż przez tunel czasoprzestrzenny w poszukiwaniu nowego domu dla ludzkości.",
        Price = 19.99m,
        CategoryId = 4,
        DateAdded = new DateTime(2014, 11, 7)
    },
    new Film()
    {
        Id = 17,
        Title = "Matrix",
        Director = "Lana Wachowski, Lilly Wachowski",
        Desc = "Haker odkrywa, że rzeczywistość, którą zna, jest jedynie komputerową symulacją.",
        Price = 17.99m,
        CategoryId = 4,
        DateAdded = new DateTime(1999, 3, 31)
    },
    new Film()
    {
        Id = 18,
        Title = "Incepcja",
        Director = "Christopher Nolan",
        Desc = "Zespół specjalistów potrafi wkradać się do ludzkich snów i manipulować podświadomością.",
        Price = 18.99m,
        CategoryId = 4,
        DateAdded = new DateTime(2010, 7, 16)
    },
    new Film()
    {
        Id = 19,
        Title = "Avatar",
        Director = "James Cameron",
        Desc = "Były żołnierz trafia na planetę Pandora i poznaje niezwykłą kulturę jej mieszkańców.",
        Price = 18.99m,
        CategoryId = 4,
        DateAdded = new DateTime(2009, 12, 18)
    },
    new Film()
    {
        Id = 20,
        Title = "Diuna",
        Director = "Denis Villeneuve",
        Desc = "Młody książę trafia na pustynną planetę, która skrywa najcenniejszy surowiec we wszechświecie.",
        Price = 19.99m,
        CategoryId = 4,
        DateAdded = new DateTime(2021, 9, 3)
    },

    // DRAMAT (CategoryId = 5)
    new Film()
    {
        Id = 21,
        Title = "Skazani na Shawshank",
        Director = "Frank Darabont",
        Desc = "Niesłusznie skazany bankier próbuje odnaleźć nadzieję i wolność w więzieniu.",
        Price = 17.99m,
        CategoryId = 5,
        DateAdded = new DateTime(1994, 9, 23)
    },
    new Film()
    {
        Id = 22,
        Title = "Zielona mila",
        Director = "Frank Darabont",
        Desc = "Strażnik więzienny poznaje niezwykłego więźnia obdarzonego tajemniczymi zdolnościami.",
        Price = 18.99m,
        CategoryId = 5,
        DateAdded = new DateTime(1999, 12, 10)
    },
    new Film()
    {
        Id = 23,
        Title = "Forrest Gump",
        Director = "Robert Zemeckis",
        Desc = "Mężczyzna o niezwykłym spojrzeniu na świat staje się świadkiem ważnych wydarzeń historii USA.",
        Price = 16.99m,
        CategoryId = 5,
        DateAdded = new DateTime(1994, 7, 6)
    },
    new Film()
    {
        Id = 24,
        Title = "Pianista",
        Director = "Roman Polański",
        Desc = "Poruszająca historia żydowskiego pianisty próbującego przetrwać okupację Warszawy.",
        Price = 17.99m,
        CategoryId = 5,
        DateAdded = new DateTime(2002, 9, 25)
    },
    new Film()
    {
        Id = 25,
        Title = "Whiplash",
        Director = "Damien Chazelle",
        Desc = "Młody perkusista marzy o wielkiej karierze i trafia pod opiekę bezwzględnego nauczyciela.",
        Price = 18.99m,
        CategoryId = 5,
        DateAdded = new DateTime(2014, 10, 10)
    },

    // THRILLER (CategoryId = 6)
    new Film()
    {
        Id = 26,
        Title = "Siedem",
        Director = "David Fincher",
        Desc = "Dwóch detektywów prowadzi śledztwo w sprawie seryjnego mordercy inspirującego się siedmioma grzechami głównymi.",
        Price = 17.99m,
        CategoryId = 6,
        DateAdded = new DateTime(1995, 9, 22)
    },
    new Film()
    {
        Id = 27,
        Title = "Wyspa tajemnic",
        Director = "Martin Scorsese",
        Desc = "Dwóch agentów federalnych bada tajemnicze zniknięcie pacjentki ze szpitala psychiatrycznego.",
        Price = 18.99m,
        CategoryId = 6,
        DateAdded = new DateTime(2010, 2, 19)
    },
    new Film()
    {
        Id = 28,
        Title = "Zaginiona dziewczyna",
        Director = "David Fincher",
        Desc = "Po zaginięciu żony mężczyzna staje się głównym podejrzanym w sprawie jej zniknięcia.",
        Price = 19.99m,
        CategoryId = 6,
        DateAdded = new DateTime(2014, 10, 3)
    },
    new Film()
    {
        Id = 29,
        Title = "Milczenie owiec",
        Director = "Jonathan Demme",
        Desc = "Agentka FBI szuka pomocy u niebezpiecznego psychiatry, aby schwytać seryjnego mordercę.",
        Price = 17.99m,
        CategoryId = 6,
        DateAdded = new DateTime(1991, 2, 14)
    },
    new Film()
    {
        Id = 30,
        Title = "Labirynt",
        Director = "Denis Villeneuve",
        Desc = "Ojciec z pomocą detektywa desperacko poszukuje swojej zaginionej córki.",
        Price = 18.99m,
        CategoryId = 6,
        DateAdded = new DateTime(2013, 9, 20)
    }
};

            modelBuilder.Entity<Film>().HasData(films);
        }
    }
}
