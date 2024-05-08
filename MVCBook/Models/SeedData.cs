using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Security.Policy;

namespace MVCBook.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCBookContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MVCBookContext>>()))
            {
                // Look for any Books.
                if (context.Book.Any() || context.Author.Any() || context.BookGenre.Any()|| context.UserBook.Any()|| context.Review.Any())
                {
                    return; // DB has been seeded
                }

                context.Author.AddRange(
                    new Author { /*Id = 1, */FirstName = "Nicholas", LastName = "Sparks", BirthDate = DateTime.Parse("1965-12-31") ,Nationality="American",Gender="Male"},
                    new Author { /*Id = 2, */FirstName = "Collen", LastName = "Hoover", BirthDate = DateTime.Parse("1979-12-11"), Nationality = "American", Gender = "Female" },
                    new Author { /*Id = 3, */FirstName = "JK", LastName = "Rowling", BirthDate = DateTime.Parse("1865-7-31"), Nationality = "British", Gender = "Female" }
                );
                context.SaveChanges();

                context.Genre.AddRange(
                    new Genre { Id=1,GenreName="Fiction"},
                    new Genre { Id = 2, GenreName = "Mystery" },
                    new Genre { Id = 3, GenreName = "Romance" },
                    new Genre { Id = 4, GenreName = "Fantasy" },
                    new Genre { Id = 5, GenreName = "Thriller" },
                    new Genre { Id = 6, GenreName = "Drama" },
                    new Genre { Id = 7, GenreName = "Comedy" }
                );
                context.SaveChanges();
                context.Book.AddRange(
                    new Book { Id=1,
                               Title="It Ends with Us", 
                               YearPublished =2016,
                               NumPages=384,
                               Description= "It Ends with Us is a book that follows a girl named Lily " +
                               "who has just moved and is ready to start her life after college. Lily then" +
                               " meets a guy named Ryle and she falls for him. As she is developing feelings " +
                               "for Ryle, Atlas, her first love, reappears and challenges the relationship " +
                               "between Lily and Ryle.",
                               Publisher="Atria Books",
                               FrontPage="mmmm",
                               DownloadUrl="mmmm"},
                    new Book
                    {
                        Id = 2,
                        Title = "Maybe Someday",
                        YearPublished = 2014,
                        NumPages = 384,
                        Description = "Maybe Someday is a captivating novel by Colleen Hoover " +
                        "that delves into the complexities of love, betrayal, and second chances." +
                        " When aspiring musician Sydney discovers that her boyfriend has been cheating " +
                        "on her with her best friend," +
                        " she finds solace in her mysterious and talented neighbor, Ridge.",
                        Publisher = "Atria Books",
                        FrontPage = "mmm",
                        DownloadUrl = "mmm"
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "The Notebook",
                        YearPublished = 1996,
                        NumPages = 272,
                        Description = "The Notebook is a contemporary love"+
                        " story set in the pre- and post-World War II era." +
                        " Noah and Allie spend a wonderful summer together," +
                        " but her family and the socio-economic realities" +
                       " of the time prevent them from being together.",
                        Publisher = "Grand Central Publishing",
                        FrontPage = "mmm",
                        DownloadUrl = "mmm"
                    },
                    new Book
                    {
                        Id = 4,
                        Title = "A Walk to Remember",
                        YearPublished = 1999,
                        NumPages = 224,
                        Description = "Set in a small town during the 1950s," +
                        " A Walk to Remember is the story of an only son of a " +
                        "wealthy family that finds true love with the most unexpected person." +
                        " The daughter of a minister (Mandy Moore) meets the only son " +
                        "(Shane West) and the story takes us through hard times, love and" +
                        " bitter sweet passion.",
                        Publisher ="Grand Central Publishing",
                        FrontPage = "mmm",
                        DownloadUrl = "mmm"
                    },
                    new Book
                    {
                        Id = 5,
                        Title = "The Best of Me",
                        YearPublished = 2010,
                        NumPages = 336,
                        Description = "Based on the bestselling novel by" +
                        " acclaimed author Nicholas Sparks, The Best of Me" +
                        " tells the story of Dawson and Amanda, two former " +
                        "high school sweethearts who find themselves " +
                        "reunited after 20 years apart, when they return " +
                        "to their small town for the funeral of a beloved " +
                        "friend.",
                        Publisher = "Grand Central Publishing",
                        FrontPage = "mmm",
                        DownloadUrl = "mmm"
                    },
                    new Book
                    {
                        Id = 6,
                        Title = "Harry Potter and the Philosopher's Stone",
                        YearPublished = 1997,
                        NumPages = 223,
                        Description = "The first novel in the Harry Potter " +
                        "series and Rowling's debut novel, it follows Harry" +
                        " Potter, a young wizard who discovers his magical " +
                        "heritage on his eleventh birthday, when he receives" +
                        " a letter of acceptance to Hogwarts School of " +
                        "Witchcraft and Wizardry.",
                        Publisher = "Bloomsbury ",
                        FrontPage = "mmm",
                        DownloadUrl = "mmm"
                    },
                    new Book
                    {
                        Id = 7,
                        Title = "Harry Potter and the Deathly Hallows",
                        YearPublished = 2007,
                        NumPages = 784,
                        Description = "Harry Potter and the Deathly Hallows" +
                        " is the seventh and final installment of the Harry Potter" +
                        " series. It follows Harry's quest to find and destroy " +
                        "Voldemort's Horcruxes, while the wizarding world falls " +
                        "into chaos and darkness.",
                        Publisher = "Bloomsbury",
                        FrontPage = "mmm",
                        DownloadUrl = "mmm"
                    }
                );
                context.SaveChanges();
                context.Review.AddRange(
                    new Review { Id = 1, AppUser = "Nataly Mack",Comment="Great!",Rating=5},
                    new Review { Id = 2, AppUser = "Ivanna Yang", Comment = "Very Good!", Rating = 4 },
                    new Review { Id = 3, AppUser = "Conrad McClain", Comment = "Good!", Rating = 3 },
                    new Review { Id = 4, AppUser = "Eddie Arias", Comment = "Not Bad!", Rating = 2 },
                    new Review { Id = 5, AppUser = "Aileen Wilson" , Comment = "Bad!", Rating = 1 },
                    new Review { Id = 6, AppUser = "Celia Rice" , Comment = "Not Bad!", Rating = 2 },
                    new Review { Id = 7, AppUser = "Graham Perkins", Comment = "Great!", Rating = 5 },
                    new Review { Id = 8, AppUser = "Allison Dorsey", Comment = "Great!", Rating = 5 },
                    new Review { Id = 9, AppUser = "Naomi Burns", Comment = "Good!", Rating = 3 },
                    new Review { Id = 10, AppUser = "Cooper French", Comment = "Very Good!", Rating = 4 },
                    new Review { Id = 11, AppUser = "Isabelle Clements", Comment = "Very Good!", Rating = 4 },
                    new Review { Id = 12, AppUser = "Lucy Tran", Comment = "Great!", Rating = 5 },
                    new Review { Id = 13, AppUser = "Bruno Sloan", Comment = "Great!", Rating = 5 }
                );
                context.SaveChanges();
                context.UserBook.AddRange(
                    new UserBook { Id = 1, AppUser = "Nataly Mack" },
                    new UserBook { Id = 2, AppUser = "Ivanna Yang" },
                    new UserBook { Id = 3, AppUser = "Conrad McClain" },
                    new UserBook { Id = 4, AppUser = "Eddie Arias" },
                    new UserBook { Id = 5, AppUser = "Aileen Wilson" },
                    new UserBook { Id = 6, AppUser = "Celia Rice" },
                    new UserBook { Id = 7, AppUser = "Graham Perkins" },
                    new UserBook { Id = 8, AppUser = "Allison Dorsey" },
                    new UserBook { Id = 9, AppUser = "Naomi Burns" },
                    new UserBook { Id = 10, AppUser = "Cooper French" },
                    new UserBook { Id = 11, AppUser = "Isabelle Clements" },
                    new UserBook { Id = 12, AppUser = "Lucy Tran" },
                    new UserBook { Id = 13, AppUser = "Bruno Sloan" }
                );
                context.SaveChanges();
                context.BookGenre.AddRange();
                context.SaveChanges();

            }
        }
    }
}
