using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class GetStudentsPage : Page
    {
        public GetStudentsPage(string title, DemoAppBootstrapper  demoAppBootstrapper) 
            : base(title, demoAppBootstrapper)
        {
            DemoAppBootstrapper = demoAppBootstrapper;
        }

        public DemoAppBootstrapper DemoAppBootstrapper { get; }

        public override void Display()
        {
            base.Display();

            DemoAppBootstrapper.Classroom.GetStudentList();


            Console.ReadLine();

            DemoAppBootstrapper.NavigateBack();


        }
    }
}
