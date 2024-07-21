using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ATM_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int iDeposit = 0;
            int iWithdrawal = 0;
            int iBalance = 0;
            int iOption = 0;
            Console.WriteLine("=====Welcome to ABC Banking=====");
            Console.WriteLine();
            Console.WriteLine("Create an Account");

            Console.Write("Name: ");
            string sName = Console.ReadLine();

            Console.Write("Last Name: ");
            string sSurname = Console.ReadLine();

            Console.WriteLine("Choose a five digit pin ");
            Console.Write("Pin: ");
            int iPin = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Account successfully created!");
            

            while(iOption != 4)
            {
                Console.WriteLine(sName + " " + sSurname);
                Console.WriteLine();
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance");
                Console.WriteLine("4. Exit");
            }

            iOption = int.Parse(Console.ReadLine());

            switch (iOption)
            {

                case 1:
                    Console.Write("Amount: ");
                    iDeposit = int.Parse(Console.ReadLine());

                    if(iDeposit >= 0)
                    {
                        Deposit(iDeposit, ref iBalance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount! ");
                    }
                    break;
                case 2:
                    Console.Write("Amount: ");
                    iWithdrawal = int.Parse(Console.ReadLine());

                    if(iWithdrawal >= 0 && iWithdrawal <= iBalance)
                    {
                        Withdraw(iWithdrawal, ref iBalance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount or amount too low");
                    }
                    break;
                case 3:
                    Balance(ref iBalance);
                    break;
            }



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void Deposit(int _Deposit, ref int _Balance)
        {
            _Balance = _Balance + _Deposit;
        }

        static void Withdraw(int _withdrawal, ref int _Balance)
        {
            _Balance = _Balance - _withdrawal;
        }

        static void Balance(ref int _Balance)
        {
            Console.WriteLine("Balance: " + _Balance);
        }
    }
}
