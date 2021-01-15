﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstBankOfSuncoast
{
    //1. Create a Class Transaction
    class Transaction
    {
        public DateTime History = DateTime.Now;

        public string Account { get; set; }

        public int Amount { get; set; }

        public string Type { get; set; }


    }
    class Program
    {
        static void BannerMessage(string message)
        {
            //  Create a greeting and a goodbye: BannerMessage();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            var transactions = new List<Transaction>();

            var userHasChosenToQuit = false;

            while (userHasChosenToQuit == false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                BannerMessage("Welcome to First Bank Of Suncoast!!! ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("MENU OPTIONS:");
                Console.WriteLine("DEPOSIT");
                Console.WriteLine("WITHRAW");
                Console.WriteLine("BALANCE");
                Console.WriteLine("TRANSACTIONS");
                Console.WriteLine("QUIT");
                Console.WriteLine();
                Console.WriteLine("What would you like to use? ");
                var choice = Console.ReadLine().ToUpper().Trim();

                if (choice == "QUIT")
                {

                    userHasChosenToQuit = true;
                }
                var totalChecking = transactions.Where(transaction => transaction.Account == "CHECKING");
                var totalSavings = transactions.Where(transaction => transaction.Account == "SAVINGS");
                var totalAmountInChecking = 0;
                var totalAmountInSavings = 0;
                foreach (var transaction in totalChecking)
                {
                    if (transaction.Type == "DEPOSIT")
                    {
                        totalAmountInChecking = totalAmountInChecking + transaction.Amount;


                    }
                    else
                    {
                        totalAmountInChecking = totalAmountInChecking - transaction.Amount;

                    }

                }
                foreach (var transaction in totalSavings)
                {
                    if (transaction.Type == "DEPOSIT")
                    {
                        totalAmountInSavings = totalAmountInSavings + transaction.Amount;

                    }
                    else
                    {
                        totalAmountInSavings = totalAmountInSavings - transaction.Amount;
                    }
                }
                switch (choice)
                {
                    // case "Deposit":
                    case "DEPOSIT":
                        // - DEPOSIT:
                        //   - Console.WriteLine("Checking or Savings?");
                        //   - Console.ReadLine();
                        //   - if (choice == "Checking")
                        //     - then access Deposit information
                        //   - if (choice == "SAVINGS")
                        //     - then access withdraw information
                        //   - withing Deposit add: or
                        //   - give the total for either option: Console.WriteLine($"Your remaining Checking balance is n{number})

                        Console.WriteLine("Do you want to deposit into CHECKING or SAVINGS?");
                        var whereDepositIsGoing = Console.ReadLine().Trim().ToUpper();
                        Console.WriteLine($"How much into {whereDepositIsGoing}?");
                        var amountOfDeposit = Console.ReadLine();
                        var howMuchDeposit = int.Parse(amountOfDeposit);


                        var newDeposit = new Transaction()
                        {
                            Account = whereDepositIsGoing,
                            Amount = howMuchDeposit,
                            Type = "DEPOSIT",
                        };

                        transactions.Add(newDeposit);

                        //transactions.OrderBy(transTime => transTime.History);



                        // Write all the transactions to the file (the four lines of code for the fileWriter)

                        break;

                    case "WITHDRAW":
                        // - WITHDRAW:
                        //   - withing Savings add: Checking or Savings
                        //   - Console.WriteLine("Checking or Savings?");
                        //   - Console.ReadLine();
                        //   - if (choice == "Checking")
                        //     - then access Deposit information
                        //   - if (choice == "Savings")
                        //     - then access savings information
                        //   - give the total for either option: Console.WriteLine($"Your remaining Savings balance is {number})

                        Console.WriteLine("Would you like to withdraw from CHECKING or SAVINGS? ");
                        var whereWithdrawIsGoing = Console.ReadLine().Trim().ToUpper();
                        Console.WriteLine($"How much from {whereWithdrawIsGoing}? ");
                        var amountOfWithdraw = Console.ReadLine();
                        var howMuchWithdraw = int.Parse(amountOfWithdraw);
                        var newWithdraw = new Transaction();

                        //Got to add my checking and savings in withdraw
                        if (whereWithdrawIsGoing == "CHECKING")
                        {
                            if (totalAmountInChecking < howMuchWithdraw)
                            {
                                //console whatever


                            }
                            else
                            {

                                newWithdraw.Account = whereWithdrawIsGoing;
                                newWithdraw.Amount = howMuchWithdraw;
                                newWithdraw.Type = "WITHDRAW";

                                transactions.Add(newWithdraw);

                            }

                        }
                        //
                        else
                        {
                            if (totalAmountInSavings < howMuchWithdraw)
                            {
                                //console whatever


                            }
                            else
                            {

                                newWithdraw.Account = whereWithdrawIsGoing;
                                newWithdraw.Amount = howMuchWithdraw;
                                newWithdraw.Type = "WITHDRAW";

                                transactions.Add(newWithdraw);

                            }

                        }

                        // four lines of
                        break;

                    case "BALANCE":
                        // - BALANCE:
                        //   - Console.WriteLine("Checking or Savings)
                        //   - if (choice == "BALANCE")
                        //   - Console.ReadLine();
                        //   - if (choice == "Savings")
                        //   - Console.ReadLine();
                        //   - keep track of transactions for both Checking and Savings
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Here is your CHECKING and SAVINGS balance. ");
                        Console.WriteLine();
                        Console.WriteLine($"Checking balance: ${totalAmountInChecking}");
                        Console.WriteLine($"Savings balance: ${totalAmountInSavings}");
                        break;

                    case "TRANSACTION":
                    //transactions.OrderBy(transTime => transTime.History);



                    default:
                        break;


                }

            }


            // - EXIT:
            //  Exits the app and prompts the Console.WriteLine("Thanks for visiting First Bank Of Suncoast!")
            BannerMessage("Thanks for using First Bank of Suncoast! ");

        }
    }
}
