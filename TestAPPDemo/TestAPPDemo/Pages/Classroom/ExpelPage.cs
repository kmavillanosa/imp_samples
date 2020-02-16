using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class ExpelPage : Page
    {
        public ExpelPage(string title, DemoAppBootstrapper demoAppBootstrapper) 
            : base(title, demoAppBootstrapper)
        {
            DemoAppBootstrapper = demoAppBootstrapper;
        }

        public DemoAppBootstrapper DemoAppBootstrapper { get; }

        public override void Display()
        {
            base.Display();

            string Name = Input.ReadString("Enter Name");
            Output.WriteLine(ConsoleColor.Green, "You Entered name {0}", Name);

            DemoAppBootstrapper.Classroom.Expel(Name);


            Console.ReadLine();


            Program.NavigateBack();

        }
    }
}
