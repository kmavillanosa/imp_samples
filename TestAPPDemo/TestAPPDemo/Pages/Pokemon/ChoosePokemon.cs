using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class ChoosePokemon : MenuPage
    {
        public ChoosePokemon(DemoAppBootstrapper program)
        : base("Pokemon Battle", program,
                  new Option("I Choose you!", () => program.NavigateTo<MakePokemonRoar>()))
        {

        }
    }
}
