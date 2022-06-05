/*

Password Checker

A computer can run thousands of operations per minute. If someone wanted to steal your information, they use each operation to make a guess at your password. With one high-performance computer and the right software, a 6 letter single-case password can be broken in one day.

Apart from quitting the internet entirely, what can we do to protect ourselves? We can increase our password’s strength: make it longer and more complex.

In this project you’ll make a program that measures the strength of any given password based on the following criteria. A strong password:
* is at least 8 characters long
* has lowercase letters
* has uppercase letters
* has numerical digits
* has symbols, like #, ?, !

The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.

If you plan to do this project on your own computer, outside of Codecademy, make sure to copy the Tools.cs file in addition to Program.cs.

*/

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args) {
      // Setting up variables and asking user for a password
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "~!@#$%^&*-+";

      Console.Write("Enter a password: "); // this will keep user input on the same line
      string password = Console.ReadLine();

      // Testing password
      int score = 0;
      if (password.Length >= minLength) {
        score++;
      }
      if (Tools.Contains(password, uppercase)) {
        score++;
      }
      if (Tools.Contains(password, lowercase)) {
        score++;
      }
      if (Tools.Contains(password, digits)) {
        score++;
      }
      if (Tools.Contains(password, specialChars)) {
        score++;
      }
      // Give the user a feedback
      switch(score) {
        case 5:
        case 4:
          Console.WriteLine("Wow, your password is sooo string!");
          break;
        case 3:
          Console.WriteLine("Nice, your password is string.");
          break;
        case 2:
          Console.WriteLine("Eh, your password is medium");
          break;
        case 1:
          Console.WriteLine("Off, your password is weak!");
          break;
        default:
          Console.WriteLine("Sorry, your password doesn't meet any of our requirements");
          break;
      }
    }
  }
}

/*
                Command Line

$ dotnet run
Enter a password: word 
Off, your password is weak!
$ dotnet run
Enter a password: woRD
Eh, your password is medium
$ dotnet run
Enter a password: 1woRD
Nice, your password is string.
$ dotnet run
Enter a password: 2woRDsss!
Wow, your password is sooo string!
$ dotnet run
Enter a password: 2woRDsss
Wow, your password is sooo string!
$ dotnet run
Enter a password: 
Sorry, your password doesn't meet any of our requirements

*/
