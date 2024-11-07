using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{   public class BankAccount{
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
        }
       public void Deposite(decimal amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Deposite must be positive");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: { amount} ");

            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            
            account.Deposite(1000);
            Console.WriteLine($"Current Balance: {account.Balance}");

            
            account.Withdraw(500);
            //Console.WriteLine($"Current Balance: {account.Balance:C}");

            
            account.Withdraw(600);

            
            Console.WriteLine($"Final Balance: {account.Balance}");
            Console.ReadKey();
        }
    }
    }

