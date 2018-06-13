using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            // This function initializes the Rating and reviews


            float[] Raten = new float[12];
            // Input of reviews
            // "La La Land" rate
            int[] array1 = { 10, 5, 5, 7 };
            
            Raten [0] = array1.Sum() / array1.Length;
            // "Logan" rate
            int[] array2 = { 8, 10, 8, 7 };

            Raten [1] = array2.Sum() / array2.Length;
            // "Blade Runner 2049" rate
            int[] array3 = { 10, 8, 5, 7 };

            Raten[2] = array3.Sum() / array3.Length;
            //T == "Dunkirk"rate
            int[] array4 = { 7, 7, 5, 7 };

            Raten[3] = array4.Sum() / array4.Length;
            //T == "The Lure" rate
            int[] array5 = { 9, 4, 8, 7 };

            Raten[4] = array5.Sum() / array5.Length;
            //T == "Thor: Ragnarok" rate
            int[] array6 = { 10, 10, 9 };

            Raten[5] = array6.Sum() / array6.Length;
            //T == "The Greatest Showman" rate
            int[] array7 = { 9, 8, 8, 8 };

            Raten[6] = array7.Sum() / array7.Length;
            //T == "Guardians of the Galaxy Vol. 2" rate
            int[] array8 = { 7, 7, 5, 7 };

            Raten[7] = array8.Sum() / array8.Length;
            //T == "Baby Driver" rate
            int[] array9 = { 9, 8, 8, 7 };

            Raten[8] = array9.Sum() / array9.Length;
            //"Spider-Man: Homecoming" rate
            int[] array10 = { 8, 7, 8, 9 };

            Raten[9] = array10.Sum() / array10.Length;
            // (T == "Wonder Woman")rate
            int[] array11 = { 5, 6, 7, 17, 10 };

            Raten[10] = array11.Sum() / array11.Length;
            //"Star Wars: Episode VIII - The Last Jedi")
            
            int[] array12 = { 10, 10, 10, 10 };

            Raten[11] = array12.Sum() / array12.Length;

            string[] Reviewn = new string[12];
            for (int i = 0; i <= 11; i++)
            {
               

                if (Raten [i] <=1.4)
                {
                    Reviewn[i] = "*";
                }
                else if (Raten[i] <= 2.4)
                {
                    Reviewn[i] = "**";
                }
                else if (Raten[i] <= 3.4)
                {
                    Reviewn[i] = "***";
                }
                else if (Raten[i] <= 4.4)
                {
                    Reviewn[i] = "****";
                }
                else if (Raten[i] <= 5.4)
                {
                    Reviewn[i] = "*****";
                }
                else if (Raten[i] <= 6.4)
                {
                    Reviewn[i] = "******";
                }
                else if (Raten[i] <= 7.4)
                {
                    Reviewn[i] = "*******";
                }
                else if (Raten[i] <= 8.4)
                {
                    Reviewn[i] = "********";
                }
                else if (Raten[i] <= 9.4)
                {
                    Reviewn[i] = "*********";
                }
                else
                {
                    Reviewn[i] = "**********";
                }
            }
              IEnumerable<Tuple<int, string, int, string, float, string>> Movies =
                new[]
                {
                      Tuple.Create(1, "La La Land", 2259, "Ryan Gosling, Emma Stone, Rosemarie DeWitt", Raten [0], Reviewn[0]),
                      Tuple.Create(2, "Logan", 860, "Hugh Jackman, Patrick Stewart, Dafne Keen", Raten [1], Reviewn[1]),
                      Tuple.Create(3, "Blade Runner 2049", 500, "Harrison Ford, Ryan Gosling, Ana de Armas", Raten [2], Reviewn[2]),
                      Tuple.Create(4, "Dunkirk", 1080, "Fionn Whitehead, Barry Keoghan, Mark Rylance ", Raten [3], Reviewn[3]),
                      Tuple.Create(5, "The Lure", 270, "Amanda Fry, Paulina Longenbaugh, David Rice", Raten [4], Reviewn[4]),
                      Tuple.Create(6, "Thor: Ragnarok", 1321, "Chris Hemsworth, Tom Hiddleston, Cate Blanchett", Raten [5], Reviewn[5]),
                      Tuple.Create(7, "The Greatest Showman", 1120, "Hugh Jackman, Michelle Williams, Zac Efron", Raten [6], Reviewn[6]),
                      Tuple.Create(8, "Guardians of the Galaxy Vol. 2", 214, "Chris Pratt, Zoe Saldana, Dave Bautista", Raten [7], Reviewn[7]),
                      Tuple.Create(9, "Baby Driver", 255, "Ansel Elgort, Jon Bernthal, Jon Hamm", Raten [8], Reviewn[8]),
                      Tuple.Create(10, "Spider-Man: Homecoming", 1100, "Tom Holland, Michael Keaton, Robert Downey Jr.", Raten [9], Reviewn[9]),
                      Tuple.Create(11, "Wonder Woman", 871, "Gal Gadot, Chris Pine, Robin Wright", Raten [10], Reviewn[10]),
                      Tuple.Create(12, "Star Wars: Episode VIII - The Last Jedi", 2678, "Rian Johnson, George Lucas", Raten [11], Reviewn[11])
                      
                };
            Console.WriteLine(Movies.ToStringTable(
               new[] { "Id", "Title", "Receipts", "Actors", "Rating", "Reviews" },
               a => a.Item1, a => a.Item2, a => a.Item3, a => a.Item4, a => a.Item5, a => a.Item6));


            /* Result:        
            | Id | First Name | Surname  |
            |----------------------------|
            | 1  | Isaac      | Asimov   |
            | 2  | Robert     | Heinlein |
            | 3  | Frank      | Herbert  |
            | 4  | Aldous     | Huxley   |*/


           


            // Order by descending on Item1.
            var result = Movies.OrderByDescending(a => a.Item5).ToList();
            /* foreach (var item in result)
             {
                 Console.WriteLine(item);
             }
            */
            

            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("////Top 10 movies, based on the reviews they have received:////");
            Console.WriteLine("//////////////////////////////////////////////////////////////");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(result[i]);
                
            }

            Console.ReadLine();
            // This function initializes the list of movies

            /* 
             Console.WriteLine(result.ToStringTable(
               new[] { "Id", "Title", "Receipts", "Actors", "Rating", "Reviews" },
               a => a.Item1, a => a.Item2, a => a.Item3, a => a.Item4, a => a.Item5, a => a.Item6));


                       var movies = new List<Movie>();

                                   // Input of 12 movies with their features
                                   movies.Add(new Movie { Id = 1, Title = "La La Land", Receipts = 2259, Actors = "Ryan Gosling, Emma Stone, Rosemarie DeWitt", Rating = Raten[0], Reviews = Reviewn[0] });
                                   movies.Add(new Movie { Id = 2, Title = "Logan", Receipts = 860, Actors = "Hugh Jackman, Patrick Stewart, Dafne Keen", Rating = Raten[1], Reviews = Reviewn[1] });
                                   movies.Add(new Movie { Id = 3, Title = "Blade Runner 2049", Receipts = 500, Actors = "Harrison Ford, Ryan Gosling, Ana de Armas", Rating = Raten[2], Reviews = Reviewn[2] });
                                   movies.Add(new Movie { Id = 4, Title = "Dunkirk", Receipts = 1080, Actors = "Fionn Whitehead, Barry Keoghan, Mark Rylance", Rating = Raten[3], Reviews = Reviewn[3] });
                                   movies.Add(new Movie { Id = 5, Title = "The Lure", Receipts = 270, Actors = "Amanda Fry, Paulina Longenbaugh, David Rice", Rating = Raten[4], Reviews = Reviewn[4] });
                                   movies.Add(new Movie { Id = 6, Title = "Thor: Ragnarok", Receipts = 1321, Actors = "Chris Hemsworth, Tom Hiddleston, Cate Blanchett", Rating = Raten[5], Reviews = Reviewn[5] });
                                   movies.Add(new Movie { Id = 7, Title = "The Greatest Showman", Receipts = 1120, Actors = "Hugh Jackman, Michelle Williams, Zac Efron", Rating = Raten[6], Reviews = Reviewn[6] });
                                   movies.Add(new Movie { Id = 8, Title = "Guardians of the Galaxy Vol. 2", Receipts = 214, Actors = "Chris Pratt, Zoe Saldana, Dave Bautista", Rating = Raten[7], Reviews = Reviewn[7] });
                                   movies.Add(new Movie { Id = 9, Title = "Baby Driver", Receipts = 255, Actors = "Ansel Elgort, Jon Bernthal, Jon Hamm", Rating = Raten[8], Reviews = Reviewn[8] });
                                   movies.Add(new Movie { Id = 10, Title = "Spider-Man: Homecoming", Receipts = 1100, Actors = "Tom Holland, Michael Keaton, Robert Downey Jr.", Rating = Raten[9], Reviews = Reviewn[9] });
                                   movies.Add(new Movie { Id = 11, Title = "Wonder Woman", Receipts = 871, Actors = "Gal Gadot, Chris Pine, Robin Wright", Rating = Raten[10], Reviews = Reviewn[10] });
                                   movies.Add(new Movie { Id = 12, Title = "Star Wars: Episode VIII - The Last Jedi", Receipts = 2678, Actors = "Rian Johnson, George Lucas", Rating = Raten[11], Reviews = Reviewn[11] });

                             
                               Console.WriteLine("Unsorted list");
                               movies.ForEach(delegate (Movie p)
                               { Console.WriteLine(String.Format("{0} {1} {2} {3} {4} {5}", p.Id, p.Title, p.Receipts, p.Actors, p.Rating, p.Reviews)); });


                              
    */

        }

    }
}
