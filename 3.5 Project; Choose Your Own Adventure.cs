/*

Choose Your Own Adventure

In this project, you’ll use logic and conditional statements to write a classic text-based Choose Your Own Adventure Game. Depending on what choices your user makes, the program will have a different result. If you’re interested in game development, this is a great project to get your started! While we’re only working with text, the principles of user input and control flow are used to build even highly advanced games.

We’ve provided you with a template to write a game, but we highly encourage you to take what you’ve learned here and use your creativity to write an original game, either here on Codecademy or off-platform!

*/

using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      
      // Ask user for a choice
      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();
      
      // user choice
      if (noiseChoice == "NO") {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("THE END.");
      } else if (noiseChoice == "YES") {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
        Console.WriteLine("You walk towards it. Do you open it or knock?");
        // user choice
        Console.Write("Type OPEN or KNOCK: ");
        string doorChoice = Console.ReadLine();
        doorChoice = doorChoice.ToUpper();

        if (doorChoice == "KNOCK") {
          Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
          Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
          // user choice
          Console.Write("Type your answer: ");
          string riddleAnswer = Console.ReadLine();
          riddleAnswer = riddleAnswer.ToUpper();

          if (riddleAnswer == "NOTHING") {
            Console.WriteLine("The door opens and NOTHING is there.");
            Console.WriteLine("You turn off the light and run back to your room and lock the door.");
            Console.WriteLine("THE END.");
          } else {
            Console.WriteLine("You answered incorrectly. The door doesn't open.");
            Console.WriteLine("THE END.");
            
          }
        } else if (doorChoice == "OPEN") {
          Console.WriteLine("The door is locked! See if one of your three keys will open it.");
          Console.Write("Enter a number (1-3): ");
          string keyChoice = Console.ReadLine();

          switch (keyChoice) {
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice!");
              Console.WriteLine("The door opens and NOTHING is there. Strange...");
              Console.WriteLine("THE END.");
              break;
            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open.");
              Console.WriteLine("THE END.");
              break;
            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open.");
              Console.WriteLine("THE END.");
              break;
          }
        }
      }
    }
  }
}
