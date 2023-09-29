using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQYF
{
    /// <summary>
    /// Game class is made to better understand LINQ
    /// Properties with automatic getters, string char Esrb, & string Genre
    /// A constructor that passes the Params title, esrb, & genre
    /// Each Param is assigned to the corresponding property
    /// </summary>
    internal class Game
    {
        public string Title { get; }

        public char Esrb { get; }

        public string Genre { get; }

        public Game(string titleParam, char esrbParam, string genreParam)
        {
            Title = titleParam; 
            Esrb = esrbParam;
            Genre = genreParam;
        }








    }
}
