/*

Money Maker

You have three types of coins:
* A bronze coin is worth 1 cent
* A silver coin is worth 5 cents
* A gold coin is worth 10 cents

What is the minimum number of coins that equals 98 cents?

It’s a hard question to answer in your head, but it’s a fun problem to solve with programming. In this project you’ll use C# to build a Money Maker: a program in which a user enters an amount and gets the minimum number of coins that equal that value.

For example, 16 cents could be:
* 16 bronze coins,
* 3 silver coins and 1 bronze coin, or
* 1 gold coin, 1 silver coin, 1 bronze coin

*/

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      // Greet the user and get the input
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins:");
      string totalAsString = Console.ReadLine();
      double total = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{total} is equal to...");

      // Define coin value
      int goldValue = 10;
      int silverValue = 5;

      // Calculate the change
      double goldCoins = Math.Floor(total / goldValue);
      double remainder = total % goldValue;
      double silverCoins = Math.Floor(remainder / silverValue);
      remainder = remainder % silverValue;

      // Printing the results
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");
    }
  }
}

/*

                  Command Line

$ dotnet run
Welcome to Money Maker!
Enter an amount to convert to coins:
16
16 is equal to...
Gold coins: 1
Silver coins: 1
Bronze coins: 1

*/
