using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations;

namespace MVCBook.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Year Published")]
        public int? YearPublished { get; set; }

        [Display(Name = "Number of Pages")]
        public int? NumPages { get; set; }

        [Display(Name = "Description")]
        [StringLength(int.MaxValue)]
        public string? Description { get; set; }

        [Display(Name = "Publisher")]
        [StringLength(50)]
        public string? Publisher { get; set; }

        [Url]
        [StringLength(int.MaxValue)]
        public string? FrontPage { get; set; }

        [Url]
        [StringLength(int.MaxValue)]
        public string? DownloadUrl { get; set; }

        [Display(Name = "Author")]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
         public ICollection<Review>? Reviews { get; set; }
        public ICollection<UserBook>? User { get; set; }

        public ICollection<BookGenre>? BookGenres { get; set; }
        
    }
}
