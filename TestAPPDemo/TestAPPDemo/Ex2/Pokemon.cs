using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    /// <summary>
    /// Create an pokemon
    /// </summary>
    public class Pokemon
    {

        /// <summary>
        /// Pokemon name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Give pokemon initial Name
        /// </summary>
        /// <param name="name"></param>
        public Pokemon(string name)
        {
            Name = name;
        }


        /// <summary>
        /// Rule: can growl based on their respective names (example pickachu can scream "Pikachu!")
        /// </summary>
        /// <param name="roarMessage"></param>
        public void Roar(string roarMessage)
        {
            Console.WriteLine($"{Name} said {roarMessage}");
            Console.ReadLine();
        }
    }
}
