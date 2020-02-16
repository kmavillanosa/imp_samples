using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class GetBalancePage : Page
    {
        public GetBalancePage(string title, DemoAppBootstrapper  demoAppBootstrapper) : base(title, demoAppBootstrapper)
        {
            DemoAppBootstrapper = demoAppBootstrapper;
        }

        public DemoAppBootstrapper DemoAppBootstrapper { get; }

        public override void Display()
        {
            base.Display();

            DemoAppBootstrapper.BankAccount.BalanceCheck();

            Console.ReadLine();
            DemoAppBootstrapper.NavigateBack();

        }
    }
}
