using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCBook.Models;

namespace MVCBook.Models
{
    public class MVCBookContext : DbContext
    {
        public MVCBookContext (DbContextOptions<MVCBookContext> options)
            : base(options)
        {
        }

        public DbSet<MVCBook.Models.Genre> Genre { get; set; } = default!;
        public DbSet<MVCBook.Models.Author> Author { get; set; } = default!;
        public DbSet<MVCBook.Models.Book> Book { get; set; } = default!;
        public DbSet<MVCBook.Models.BookGenre> BookGenre { get; set; } = default!;
        public DbSet<MVCBook.Models.Review> Review { get; set; } = default!;
        public DbSet<MVCBook.Models.UserBook> UserBook { get; set; } = default!;

    
    }
}
