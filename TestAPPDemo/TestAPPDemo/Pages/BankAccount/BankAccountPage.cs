using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    public class BankAccountPage : MenuPage
    {

        public BankAccountPage(DemoAppBootstrapper program)
        : base("Bank Account Management Page", program,
                  new Option("Deposit", () => program.NavigateTo<DepositAmountPage>()),
                  new Option("Withdraw", () => program.NavigateTo<WidrawAmountPage>()),
                  new Option("Get Balance", () => program.NavigateTo<GetBalancePage>()))
        {

        }

    }
}
