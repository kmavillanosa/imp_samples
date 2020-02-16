using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class EnrollPage : Page
    {
        public EnrollPage(string title, DemoAppBootstrapper app) 
            : base(title, app)
        {
            demoAppBootstrapper = app;
        }

        public DemoAppBootstrapper demoAppBootstrapper { get; }

        public override void Display()
        {
            base.Display();

            string Name = Input.ReadString("Enter Name");
            Output.WriteLine(ConsoleColor.Green, "You Entered name {0}", Name);

            int Age = Input.ReadInt("Enter Age", 1, 100000);
            Output.WriteLine(ConsoleColor.Green, "You Entered age {0}", Age);

            var Gender = Input.ReadEnum<Gender>("Enter Gender");
            Output.WriteLine(ConsoleColor.Green, "You Entered gender {0}", Gender);

            demoAppBootstrapper.Classroom.Enroll(Name, Age, Gender);

            Console.ReadLine();


            Program.NavigateBack();

        }
    }
}
