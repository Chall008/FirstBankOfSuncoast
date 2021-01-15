using System;
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


            // - Console.WriteLine("Welcome to First Bank Of Suncoast!");
            // - Console.WriteLine("Thanks for visiting First Bank Of Suncoast!");
            // - Ask user Console.WriteLine("Which would you like to choose?"):

            // 3. Add a List<Transactions>
            // 4. Add some features:

            // - DEPOSIT:
            //   - Console.WriteLine("Checking or Savings?");
            //   - Console.ReadLine();
            //   - if (choice == "Checking")
            //     - then access Deposit information
            //   - if (choice == "SAVINGS")
            //     - then access withdraw information
            //   - withing Deposit add: or
            //   - give the total for either option: Console.WriteLine($"Your remaining Checking balance is n{number})
            // - WITHDRAW:
            //   - withing Savings add: Checking or Savings
            //   - Console.WriteLine("Checking or Savings?");
            //   - Console.ReadLine();
            //   - if (choice == "Checking")
            //     - then access Deposit information
            //   - if (choice == "Savings")
            //     - then access savings information
            //   - give the total for either option: Console.WriteLine($"Your remaining Savings balance is {number})
            //     //This is unclear on how to provide
            // - BALANCE:
            //   - Console.WriteLine("Checking or Savings)
            //   - if (choice == "BALANCE")
            //   - Console.ReadLine();
            //   - if (choice == "Savings")
            //   - Console.ReadLine();
            //   - keep track of transactions for both Checking and Savings


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

                BannerMessage("Welcome to First Bank Of  ");
                Console.WriteLine();
                Console.WriteLine("As you can see below we have some options for you to chose!");
                Console.WriteLine();
                Console.WriteLine("DEPOSIT:");
                Console.WriteLine("WITHRAW:");
                Console.WriteLine("BALANCE");
                Console.WriteLine("TRANSACTIONS");
                Console.WriteLine("QUIT:");
                Console.WriteLine();
                Console.WriteLine("What would you like to use? ");
                var choice = Console.ReadLine().ToUpper().Trim();

                if (choice == "QUIT")
                {

                    userHasChosenToQuit = true;
                }

                switch (choice)
                {
                    // case "Deposit":
                    case "DEPOSIT":

                        Console.WriteLine("Do you want to deposit into Checking or Savings?");
                        var whereDepositIsGoing = Console.ReadLine().Trim().ToLower();
                        Console.WriteLine($"How much into {whereDepositIsGoing}?");
                        var amountOfDeposit = Console.ReadLine().Trim().ToLower();
                        var howMuchDeposit = int.Parse(amountOfDeposit);


                        var newDeposit = new Transaction()
                        {
                            Account = whereDepositIsGoing,
                            // Amount = amountOfDeposit,




                        };

                        transactions.OrderBy(transTime => transTime.History);



                        // Write all the transactions to the file (the four lines of code for the fileWriter)

                        break;

                    case "WITHDRAW":

                        Console.WriteLine("Would you like to withdraw from Checking or Savings? ");
                        var whereWithdrawIsGoing = Console.ReadLine().Trim().ToLower();
                        Console.WriteLine($"How much from {whereWithdrawIsGoing}? ");
                        var amountOfWithdraw = Console.ReadLine().Trim().ToLower();


                        var neWithdraw = new Transaction()
                        {







                        };
                        break;




                        // case "BALANCE":

                        // Console.WriteLine("Would you like you balance from Checking or Savings? ");
                        // var whichBalanceAccount = Console.ReadLine().Trim().ToLower();
                        // Console.WriteLine($"Here is your balance for {whichBalanceAccount}? ");

                }

                //                 if (userChoice == Deposit) ADD
                //                    - Write a question(savings or checking)
                //  --var newAccount = Answer(savings or checkings)
                //  - How much do you want to add ?
                //   --var newAmount = answer(How much)
                //   --var newType = deposit(deposit or withdraw)


                //  var newtransaction = new Transaction()


                //  newtransaction.Account = newAccount
                //  newtransaction.Amount = newAmount
                //  newtransaction.Type = newType


                //  transaction.Add(newtransaction)











            }


            // - EXIT:
            //  Exits the app and prompts the Console.WriteLine("Thanks for visiting First Bank Of Suncoast!")
            BannerMessage("Thanks for using First Bank of Suncoast! ");

        }
    }
}
