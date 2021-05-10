using System;

namespace MoviesDB2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool validate = true;
            Console.WriteLine("Hi welcome to this movie thing");
            Console.WriteLine("==============================");
            Console.WriteLine("Options");
            do
            {
                Console.WriteLine("1. Search by Genre");
                Console.WriteLine("2. Search by title keyword");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    GenreSearch();
                    validate = false;
                }
                else if (choice == "2")
                {
                    TitleSearch();
                    validate = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter 1 or 2");

                }
            } while (validate == true);    
        }

        static void MovieAdder()
        {
            using (var context = new MoviesDB2Context())
            {
                Movie movie1 = new Movie()
                {
                    Title = "BraveHeart",
                    Genre = "Drama",
                    Runtime = 248
                };
                context.Movies.Add(movie1);

                Movie movie2 = new Movie()
                {
                    Title = "Kill Bill",
                    Genre = "Action",
                    Runtime = 167
                };
                context.Movies.Add(movie2);

                Movie movie3 = new Movie()
                {
                    Title = "Scream",
                    Genre = "Horror",
                    Runtime = 173
                };
                context.Movies.Add(movie3);

                Movie movie4 = new Movie()
                {
                    Title = "Step Brothers",
                    Genre = "Comedy",
                    Runtime = 140
                };
                context.Movies.Add(movie4);

                Movie movie5 = new Movie()
                {
                    Title = "Aliens",
                    Genre = "Sci-Fi",
                    Runtime = 200
                };
                context.Movies.Add(movie5);

                Movie movie6 = new Movie()
                {
                    Title = "Shawshank Redemption",
                    Genre = "Drama",
                    Runtime = 300
                };
                context.Movies.Add(movie6);

                Movie movie7 = new Movie()
                {
                    Title = "Dark Knight",
                    Genre = "Action",
                    Runtime = 180
                };
                context.Movies.Add(movie7);

                Movie movie8 = new Movie()
                {
                    Title = "Pulp Fiction",
                    Genre = "Drama",
                    Runtime = 240
                };
                context.Movies.Add(movie8);

                Movie movie9 = new Movie()
                {
                    Title = "Django",
                    Genre = "Drama",
                    Runtime = 300
                };
                context.Movies.Add(movie9);

                Movie movie10 = new Movie()
                {
                    Title = "Fellowship of the Ring",
                    Genre = "Drama",
                    Runtime = 480
                };
                context.Movies.Add(movie10);

                context.SaveChanges();

            }
        }

        static void GenreSearch()
        {
            
          

                Console.WriteLine("Enter a Genre to search by");
                string result = Console.ReadLine();
            using (var context = new MoviesDB2Context())
                foreach (Movie movie in context.Movies)
                {
                    if (result.ToLower().Trim() == movie.Genre.ToLower().Trim())
                    {
                        Console.WriteLine($"Title: {movie.Title} Runtime: {movie.Runtime} minutes");
                        
                    }
                }

        } 


        static void TitleSearch()
        {
            
                Console.WriteLine("Enter a Title to search by");
                string result = Console.ReadLine();
            
            using (var context = new MoviesDB2Context())
                    foreach (Movie movie in context.Movies)
                    {

                        if (movie.Title.ToLower().Contains(result))
                        {
                            Console.WriteLine($"Title: {movie.Title}  Runtime: {movie.Runtime}");
                            
                        }
                      
                    }
            

        }







    }
}
