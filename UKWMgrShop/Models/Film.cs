using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UKWMgrShop.Models
{
    public class Film
    {
        public int Id { get; set; }

        //public int FilmId { get; set; }

        //[Key]
        //public int IdFilm { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł")]
        public string Title { get; set; }

        public string Director { get; set; }

        [StringLength(5000)]
        public string Desc { get; set; }

        public decimal Price { get; set; }

        public DateTime DateAdded { get; set; }

        // nazwa klasy dołączanej + nazwa PK
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }

        // nazwa klasy dołączanej + Id
        

    }
}
