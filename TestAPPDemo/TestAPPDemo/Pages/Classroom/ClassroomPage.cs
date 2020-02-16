using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class ClassroomPage : MenuPage
    {
        public ClassroomPage(DemoAppBootstrapper program)
        : base("Classroom Management Page", program,
                  new Option("Enroll", () => program.NavigateTo<EnrollPage>()),
                  new Option("Expel", () => program.NavigateTo<ExpelPage>()),
                  new Option("GetList", () => program.NavigateTo<GetStudentsPage>()))
        {

        }
    }
}
