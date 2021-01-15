# FirstBankOfSuncoast

PEDAC

## PROBLEM:

Create a banking app that allows us to make and track withdrawals and deposits in two accounts, checking and savings. Doing this through Transactions.
Keep track of balance history by looking at all of the transactions that have been done
The transaction will be saved in a file, using CSV format to record the data.

C R U D
Create: (Deposit/ Withdraw) (create) a new transaction.
Read: Transaction History
Update: Update Checking and Savings
Delete: Removing funds from the account (Withdraw)

## EXAMPLES: 20min

1. If a user deposits 10 to their savings, then withdraws 8 from their savings, then deposits 25 to their checking, they have three transactions to consider. Compute the checking and saving balance, using the transaction list, when needed. In this case, their savings balance is 2 and their checking balance is 25.

2. If a user deposits 10 to their savings, then withdraws 10 from their savings, then deposits 20 into their checking. The user has three transactions:

- Compute the checking and the savings balance, using the transaction List<Transaction>.
- their checking would be balance is 20.
- their savings balance is 0.

3. If the user has 25 in their savings and wants to withdraw 30

- Cannot be negative
- Transactions amounts have to be positive

4. If a user tries to deposit 30 into savings and 15 into their checking.

- Compute and update the new savings account and checking account to reflect the new deposited number to 30 and 15.

5. I go to the bank and check my balances for both my Savings and Checking accounts.

6. I go to the bank and try to withdraw $30, but I only have $12 cause I’m broke. The bank doesn’t give me $30. They suck.

7. I request a list of my transactions from my Savings and Checking accounts.

8. My accounts can never go negative.

9. I go to the bank and deposit $10 into my checking account. Withdraw $5 from $20 in Savings and deposit $3 back into Checking. That is 3 transactions. I have $13 in checking left and $15 in savings left

10. Deposits 20 to checking, deposits 20 to savings, withdraws 12 from checking. 3 Transactions, 8 in checking 20 in savings

## DATA: 30-45min

Create a “Welcome” and “Goodbye” message!

Create a Class called Transaction

Properties:  
Amount (int): (how much is in the transaction)
Kind of Transactions: Deposit, Withdraw
TimeStamp (DateTime) (Could add a time stamp on your transactions as well.)
Where the transaction is going: Checking, Savings,

Add a List<Transactions>

Multiple options for menu:

Display the Menu Options:
Deposit
Withdraw
Balance - int
Transaction History -
Qui

Instead of If Statements, you can use Switch Statements

## ALGORITHM:

1. Create a Class Transaction
2. Create a greeting and a goodbye: BannerMessage();

- Console.WriteLine("Welcome to First Bank Of Suncoast!");
- Console.WriteLine("Thanks for visiting First Bank Of Suncoast!");
- Ask user Console.WriteLine("Which would you like to choose?"):

3. Add a List<Transactions>
4. Add some features:

- DEPOSIT:
  - Console.WriteLine("Checking or Savings?");
  - Console.ReadLine();
  - if (choice == "Checking")
    - then access Deposit information
  - if (choice == "SAVINGS")
    - then access withdraw information
  - withing Deposit add: or
  - give the total for either option: Console.WriteLine($"Your remaining Checking balance is n{number})
- WITHDRAW:
  - withing Savings add: Checking or Savings
  - Console.WriteLine("Checking or Savings?");
  - Console.ReadLine();
  - if (choice == "Checking")
    - then access Deposit information
  - if (choice == "Savings")
    - then access savings information
  - give the total for either option: Console.WriteLine($"Your remaining Savings balance is {number})
    //This is unclear on how to provide
- BALANCE:
  - Console.WriteLine("Checking or Savings)
  - if (choice == "BALANCE")
  - Console.ReadLine();
  - if (choice == "Savings")
  - Console.ReadLine();
  - keep track of transactions for both Checking and Savings
- EXIT:
  - Exits the app and prompts the Console.WriteLine("Thanks for visiting First Bank Of Suncoast!")
