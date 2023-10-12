using Banking.Logic;

Console.Write("Type of Account? ([c]hecking, [b]usiness, [s]avings): ");
var accountType = Console.ReadLine()!;
Console.Write("Account number: ");
var accountNumber = Console.ReadLine()!;
Console.Write("Account holder: ");
var accountHolder = Console.ReadLine()!;
Console.Write("Current balance: ");
var currentBalance = decimal.Parse(Console.ReadLine()!);

Account account;
Transaction transaction = new Transaction();

switch (accountType)
{
    case "c":
        account = new CheckingAccount();
        break;
    case "b":
        account = new BusinessAccount();
        break;
    case "s":
        account = new SavingsAccount();
        break;
    default:
        return;
}

Console.Write("Transaction account number: ");
var transactionNumber = Console.ReadLine()!;
Console.Write("Transaction description: ");
var description = Console.ReadLine()!;
Console.Write("Transaction amount: ");
var amount = decimal.Parse(Console.ReadLine()!);
Console.Write("Transaction timestamp: ");
var timestamp = DateTime.Parse(Console.ReadLine()!);

transaction.AccountNumber = transactionNumber;
account.AccountNumber = accountNumber;
account.CurrentBalance = currentBalance;
transaction.Amount = amount;


if (account.TryExecute(transaction) == true)
{
    Console.WriteLine($"Transaction executed successfully. The new current balance is {account.CurrentBalance}$.");
}

else { Console.WriteLine("Transaction not allowed."); }