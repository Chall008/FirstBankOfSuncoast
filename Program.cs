using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

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
        static List<Transaction> Withdraw(List<Transaction> transactions, int totalAmountInChecking, int totalAmountInSavings)
        {
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


            return transactions;




        }

        static List<Transaction> Deposit(List<Transaction> transactions)
        {

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
            return transactions;


        }
        static void WriteFile(List<Transaction> transactions)
        {
            var fileWriter = new StreamWriter("Transactions.csv");
            var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(transactions);
            fileWriter.Close();


        }
        static void Main(string[] args)
        {
            TextReader fileReader;
            if (File.Exists("Transactions.csv"))
            {
                fileReader = new StreamReader("Transactions.csv");
            }
            else
            {
                fileReader = new StringReader("");
            }
            var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

            var transactions = csvReader.GetRecords<Transaction>().ToList();
            fileReader.Close();
            // return csvReader.GetRecords<Transaction>().ToList();


            //  List<Pet> pets = ReadPets("pets.csv");
            // var transactions = new List<Transaction>();

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
                Console.WriteLine("VIEW");
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
                        Deposit(transactions);



                        WriteFile(transactions);

                        // Write all the transactions to the file (the four lines of code for the fileWriter)

                        break;

                    case "WITHDRAW":

                        Withdraw(transactions, totalAmountInChecking, totalAmountInSavings);
                        WriteFile(transactions);


                        break;

                    case "BALANCE":

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Here is your CHECKING and SAVINGS balance. ");
                        Console.WriteLine();
                        Console.WriteLine($"Checking balance: ${totalAmountInChecking}");
                        Console.WriteLine($"Savings balance: ${totalAmountInSavings}");
                        break;

                    case "VIEW":


                        transactions.OrderBy(transTime => transTime.History);
                        Console.WriteLine();
                        Console.WriteLine("Here is your transaction history!");


                        foreach (var transaction in transactions)
                        {
                            Console.WriteLine($" ${transaction.Amount} {transaction.Type} in {transaction.Account} ");



                        }

                        break;



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
