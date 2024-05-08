using System.ComponentModel.DataAnnotations;

namespace MVCBook.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string GenreName { get; set; }

        public ICollection<BookGenre> BookGenre { get; set; }
    }
}
