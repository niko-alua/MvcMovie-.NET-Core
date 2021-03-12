using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Director = "Todd Phillips",
                        Genre = "Crime , Drama , Thriller",
                        Title = "Joker",
                        Poster = "https://avatars.mds.yandex.net/get-kinopoisk-image/1946459/84934543-5991-4c93-97eb-beb6186a3ad7/300x450",
                        ReleaseDate = new DateTime(2019, 10, 3)
                    },
                    new Movie
                    {
                        Director = "David Leitch",
                        Genre = "Action , Adventure",
                        Title = "Fast & Furious Presents: Hobbs & Shaw",
                        Poster = "https://avatars.mds.yandex.net/get-kinopoisk-image/1629390/33e21e7f-229d-4630-9460-80dbd1eed74a/300x450",
                        ReleaseDate = new DateTime(2019, 8, 2)
                    },
                    new Movie
                    {
                        Director = "Jon Favreau",
                        Genre = "Adventure , Animation , Drama , Family , Musical",
                        Title = "The Lion King",
                        Poster = "https://avatars.mds.yandex.net/get-kinopoisk-image/1599028/543dce27-3a14-4d8b-9d85-3a1b80ec7368/300x450",
                        ReleaseDate = new DateTime(2019, 7, 19)
                    },
                    new Movie
                    {
                        Director = "Joachim Rønning",
                        Genre = "Adventure , Family , Fantasy",
                        Title = "Maleficent: Mistress of Evil",
                        Poster = "https://avatars.mds.yandex.net/get-kinopoisk-image/1599028/2e3875b7-ecfe-4db1-8504-3fc1d41cbc9f/300x450",
                        ReleaseDate = new DateTime(2019, 10, 18)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}