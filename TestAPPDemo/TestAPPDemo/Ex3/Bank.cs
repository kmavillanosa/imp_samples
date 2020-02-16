using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyConsole;

namespace TestAPPDemo
{
    public class BankAccount
    {

        /// <summary>
        /// Bank account current balance
        /// </summary>
        public int Balance { get; set; }


        /// <summary>
        /// Start bank account balance with zero
        /// </summary>
        public BankAccount() { }

        /// <summary>
        /// Create account with initial amount
        /// </summary>
        /// <param name="initialAmount"></param>
        public BankAccount(int initialAmount)
        {
            Balance = initialAmount;

            Console.WriteLine($"Successfully created an acount with initial amount of {initialAmount}");
            Console.ReadLine();
        }

     

        /// <summary>
        /// Can Deposit money based on amount
        /// </summary>
        /// <param name="balance"></param>
        public void Deposit(int  balance)
        {
            Balance = Balance + balance;
            Console.WriteLine($"Deposited amount {balance}");

            BalanceCheck();
        }

        /// <summary>
        /// Rule 2: Can Withdraw money based on current balance
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(int amount)
        {
            var projected_amount = Balance - amount;
            ///rule 2.1 : if balance is insufficient must promt "You dont have enough balance"
            if (projected_amount <= 0)
            {
                Console.WriteLine("You dont have enough balance");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine($"Successfully withdrawn amount of {amount} from bank account");
            }
            Console.ReadLine();

            BalanceCheck();
        }

        /// <summary>
        /// Rule 3: Can Get current account balance
        /// </summary>
        public void BalanceCheck()
        {
            Console.WriteLine($"Current account balance is {Balance}");
            Console.ReadLine();
        }
    }
}
