using System.Collections.Generic;
using System.Linq;
using FilmPlatform.Models;

namespace FilmPlatform.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    Id=1,
                    Name="Frida",
                    Description="<p>Julie Taymor, Frida'nın öyküsünü etkileyici bir dille anlatmaya çalışsa da film sonlarına doğru bir parça sarkmaya</p>", 
                    ShortDescription="Frida", 
                    ImageUrl="frida.jpg",
                    CategoryId=1
                },
                new Movie()
                {
                    Id=2,
                    Name="Pollock",
                    Description="<p>Julie Taymor, Frida'nın öyküsünü etkileyici bir dille anlatmaya çalışsa da film sonlarına doğru bir parça sarkmaya</p>",  
                    ShortDescription="Pollock",
                    ImageUrl="pollock.jpg",
                    CategoryId=2
                },
                new Movie()
                {
                    Id=3,
                    Name="Renoir",
                    Description="<p>Julie Taymor, Frida'nın öyküsünü etkileyici bir dille anlatmaya çalışsa da film sonlarına doğru bir parça sarkmaya</p>", 
                    ShortDescription="Renoir",
                    ImageUrl="renoir.jpg",
                    CategoryId=3
                },
                new Movie()
                {
                    Id=4,
                    Name="Van Gogh",
                    Description="<p>Julie Taymor, Frida'nın öyküsünü etkileyici bir dille anlatmaya çalışsa da film sonlarına doğru bir parça sarkmaya</p>", 
                    ShortDescription="Van Gogh",
                    ImageUrl="vangogh.jpg",
                    CategoryId=3
                },
            };
        }

        public static List<Movie>Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);


        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i=>i.Id==id);
        }

    }  
}