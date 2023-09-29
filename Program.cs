using System;

namespace LINQYF
{
    internal class Program
    {
        /// <summary>
        /// An array of Games is called games & initialized with 10 games
        /// A LINQ Query is made to get all games with less than 9 characters in the title. & assigned to a var called shortGames
        /// Select prints "Game Title: <game.Title>.ToUpper()."
        /// Each element in shortGames is looped through and printed
        /// A LINQ method query is used to ofind the game "Minecraft" from the games array & assign it to var called mineCraft
        /// All the game properties of mineCraft are printed to console using the FIrstOrDefault method
        /// A var tRated selects the titles where the esrb rating is 'T'
        /// "T Rated Games" is printed to console
        /// tRated elements are looped through and printed to console
        /// "E Rated Action Games" is printed to console
        /// eRatedAction is looped through and each element is printed to console
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("CS:GO", 'M', "FPS"),
                new Game("Elden Ring", 'M', "Action-Adventure"),
                new Game("Valorant", 'T', "FPS"),
                new Game("Halo 3", 'M', "Action FPS"),
                new Game("ZombCube", 'E', "FPS Surivial"),
                new Game("Magnet Destroyer", 'E', "Hyper-Casual"),
                new Game("Paddle Balls", 'E', "Arcade Casual "),
                new Game("Rocket League", 'E', "Action Racing"),
                new Game("Fifa 22", 'E', "Sports"),
            };

            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";
            foreach ( var game in games )
            {
                Console.WriteLine(game);    
            }

            var mineCraft = games.Where(game => game.Title == "Minecraft")
                           .Select(game => $"Title: {game.Title}. ESRB: {game.Esrb}, Genre: {game.Genre}");
            Console.WriteLine(mineCraft.FirstOrDefault());

            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;
            Console.WriteLine("T Rated Games:");
            foreach(var game in tRated)
            {
                Console.WriteLine(game);
            }

            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;
            Console.WriteLine("E Rated Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }

        }
    }
}