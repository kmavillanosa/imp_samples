using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class MakePokemonRoar : Page
    {
        public MakePokemonRoar(string title, DemoAppBootstrapper  demoAppBootstrapper) 
            : base(title, demoAppBootstrapper)
        {
            DemoAppBootstrapper = demoAppBootstrapper;
        }

        public DemoAppBootstrapper DemoAppBootstrapper { get; }

        public override void Display()
        {
            base.Display();

            string Name = Input.ReadString("Enter Name");

            var pokemon = new Pokemon(Name);

            string roar = Input.ReadString("What to say?");

            pokemon.Roar(roar);

            Console.ReadLine();

            DemoAppBootstrapper.NavigateBack();


        }
    }
}
