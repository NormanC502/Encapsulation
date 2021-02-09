using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // explicit type would be BankAccount = new BankAccount();
            var account = new BankAccount(); // inferred type

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you!   Your balance is now ${account.GetBalance()}");
        }
    }
}
