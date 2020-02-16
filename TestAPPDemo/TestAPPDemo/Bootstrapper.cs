using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class DemoAppBootstrapper : Program
    {
        public Classroom Classroom { get; set; }
        public BankAccount BankAccount { get; set; }

        public DemoAppBootstrapper()
          : base("Excercise", breadcrumbHeader: true)
        {


            Classroom = new Classroom();
            BankAccount = new BankAccount();


            AddPage(new MainPage(this));

            //classroom management
            AddPage(new ClassroomPage(this));
            AddPage(new EnrollPage("Enrollment",this));
            AddPage(new ExpelPage("Expulsion", this));
            AddPage(new GetStudentsPage("Get Student list", this));

            //bank Account Management
            AddPage(new BankAccountPage(this));
            AddPage(new DepositAmountPage("Deposit money to account", this));
            AddPage(new WidrawAmountPage("Get money to account", this));
            AddPage(new GetBalancePage("Get Balance", this));


            AddPage(new ChoosePokemon(this));
            AddPage(new MakePokemonRoar("Choose Pokemon", this));



            SetPage<MainPage>();
        }

    }
}
