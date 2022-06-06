/*

Caesar Cipher

By 6 a.m. on Sunday, your team’s project is nearly finished. The Object of Your Affection (the name’s a work in progress) is getting attention from other teams in the hackathon. With one day left, they’re getting desperate. To steal your project idea, your competitors have been reading your team’s emails!

As the team’s C# expert, you have been asked to write a cipher: a tool to encrypt text, making it unreadable to other teams. You’ve decided to implement the Caesar Cipher, which was used by the Roman Empire to encode military secrets.

                  images are in ./img/caesar sipher.jpeg

Take every letter of your message and shift it three places to the right. For example, A becomes D, B becomes E, C becomes F, and “attack” becomes “dwwdfn”.

Your teammates can decrypt your message by reversing the process: shift each letter three places to the left.

For this project you’ll need to convert strings to arrays of characters with ToCharArray():

string msgString = "brutus";
char[] msgArray = msgString.ToCharArray();

You’ll also need to convert arrays of characters to strings with Join():

char[] msgArray = new char[] {'b', 'r', 'u', 't', 'u', 's'};
string msgString = String.Join("", msgArray);

*/

using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      // message to the user
      Console.WriteLine("Enter your secret message: ");

      // Prep for encryption
      string input = Console.ReadLine();
      char[] secretMessage = input.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      // encryption
      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];
        int letterPosition = Array.IndexOf(alphabet, letter);
        int newLetterPosition = (letterPosition + 3) % 26;
        char letterEncoded = alphabet[newLetterPosition];
        encryptedMessage[i] = letterEncoded;
      }

      string encodedString = String.Join("", encryptedMessage);

      Console.WriteLine($"Your encoded message is: {encodedString}");
    }
  }
}

/*

              Command Line
$ dotnet run
Enter your secret message: 
hello
Your encoded message is: khoor
$ dotnet run
Enter your secret message: 
citizen
Your encoded message is: flwlchq

*/
