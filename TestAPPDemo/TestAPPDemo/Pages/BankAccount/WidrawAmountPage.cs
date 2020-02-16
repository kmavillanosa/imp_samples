using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    class WidrawAmountPage : Page
    {
        public WidrawAmountPage(string title, DemoAppBootstrapper  demoAppBootstrapper) : base(title, demoAppBootstrapper)
        {
            DemoAppBootstrapper = demoAppBootstrapper;
        }

        public DemoAppBootstrapper DemoAppBootstrapper { get; }

        public override void Display()
        {
            base.Display();


            int amount = Input.ReadInt("Enter Amount", 1, 500000);

            DemoAppBootstrapper.BankAccount.Withdraw(amount);


            Console.ReadLine();

            DemoAppBootstrapper.NavigateBack();
        }
    }
}
