class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to your bank!");

        BankEncapsulation.BankAccount account = new BankAccount();

        while(true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Get Balance");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the amount to deposit: ");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                    {
                        account.Deposit(depositAmount);
                        Console.WriteLine("Deposit successful!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount.");
                    }
                    break;

                case "2":
                    Console.WriteLine($"Your current balance is: {account.GetBalance()}");
                    break;

                case "3":
                    Console.WriteLine("Exiting the application. Thank you!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }

    private class BankAccount : BankEncapsulation.BankAccount
    {
    }
}

//Create a new public class named BankAccount
//In your BankAccount class, create the following:

//A private field of type double named **balance **with a value of 0
//Define a method named Deposit that will accept a double and store that value
//in the balance field
//Define a method named GetBalance that will return the amount stored in the balance field
//In the main method of your application, create a new instance of the BankAccount class.
//Allow the user of the application to Deposit money and
//retrieve their balance through the console.
//Once finished save, commit, and push back to Github