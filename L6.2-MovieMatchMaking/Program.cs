using System;

namespace L6._2_MovieMatchMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Movie Match Making.");

            string[] Actors = { 
                "Tom Hanks", "Brad Pitt", 
                "Uma Thurman", "Laurence Fishburne", 
                "Edward Norton", "John Travolta", 
                "Christrian Bale", "Samuel L. Jackson", 
                "Keanu Reeves" };

            string[] Movies = { 
                "Fight Club",
                "Pulp Fiction", 
                "The Dark Knight",
                "Forrest Gump",
                "The Matrix"
                };

            Console.WriteLine(Actors[8] + " and " + Actors[3] + " starred in " + Movies[4]);

            //Your codes goes here
            
            
        }
    }
}
