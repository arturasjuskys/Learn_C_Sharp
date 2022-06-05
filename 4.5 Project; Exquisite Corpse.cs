/*

Exquisite Corpse

In the game Exquisite Corpse, participants draw either a head, body, or feet of a creature. The players don’t know how their part of the body connects to the other two, until the drawing is finished and revealed.

For this project, you’ll write a program that mimics the Exquisite Corpse game. Using methods, you’ll be able to randomly combine different parts of ASCII characters so they create a new creature.

If you get stuck or would like to see an experienced programmer tackle this project, click “get help” for a walkthrough video.

*/

using System;

namespace ExquisiteCorpse {
  class Program {
    static void Main(string[] args) {
      RandomMode();
    }

    // method to create a creature
    static void BuildACreature(string head, string body, string feet) {
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);

      SwitchCase(headNum, bodyNum, feetNum);
    }

    // method for a random mode
    static void RandomMode() {
      // Next, we want to use the Random class’s Next() method to randomly pick a number between 1 and inclusive of 3. For that reason, the range we will use is (1, 4) where 1 is the minimum value and 4 is the maximum.
      // https://docs.microsoft.com/en-us/dotnet/api/system.random.next
      // Since there are three things we want to randomly select, we’ll want to call the Next() method three times, each time saving it to a new variable. In total, there should be three variables with a random value, one of the head, body, and feet.

      Random randomNumber = new Random();
      int head = randomNumber.Next(1, 4);
      int body = randomNumber.Next(1, 4);
      int feet = randomNumber.Next(1, 4);
      SwitchCase(head, body, feet);
    }

    static void SwitchCase(int head, int body, int feet) {
      switch(head) {
        case 1:
          GhostHead();
          break;
        case 2:
          MonsterHead();
          break;
        case 3:
          BugHead();
          break;
      }
      switch(body) {
        case 1:
          GhostBody();
          break;
        case 2:
          MonsterBody();
          break;
        case 3:
          BugBody();
          break;
      }
      switch(feet) {
        case 1:
          GhostFeet();
          break;
        case 2:
          MonsterFeet();
          break;
        case 3:
          BugFeet();
          break;
      }
    }

    static int TranslateToNumber(string creature) {
      switch(creature) {
        case "ghost":
          return 1;
        case "bug":
          return 2;
        case "monster":
          return 3;
        default:
          return 1;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
