using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class MainPage : MenuPage
    {

        public MainPage(DemoAppBootstrapper program)
             : base("Exercise", program,
                   new Option("Classroom Management", () => program.NavigateTo<ClassroomPage>()),
                   new Option("Pokemon Battle", () => program.NavigateTo<ChoosePokemon>()),
                   new Option("Bank Account Management", () => program.NavigateTo<BankAccountPage>()))
        {

        }
    }
}
