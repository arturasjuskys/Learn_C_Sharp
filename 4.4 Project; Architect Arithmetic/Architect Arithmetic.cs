using System;

namespace ArchitectArithmetic
{
  class Program {
    public static void Main(string[] args) {
      // Greet user and get choice
      Console.WriteLine("What monument would you like to work with?");
      Console.Write("Choose: Teotihuacan (1), Taj Mahal (2), or Great Mosque of Mecca (3): ");
      string monument = Console.ReadLine();
      // global varialbe
      double totalArea;

      switch (monument) {
        case "1":
          totalArea = Rect(2500, 1500) + Triangle(750, 500) + 0.5 * Circle(375);
          break;
        case "2":
          totalArea = Rect(90.5, 90.5) - 2 * Rect(24, 24);
          break;
        case "3":
          totalArea = Rect(180, 106) + Rect(200, 264) + Triangle(264, 84);
          break;
        default:
          totalArea = 0;
          break;
      }
      
      double totalCost = totalArea * 180;
      Console.WriteLine($"My plan costs: {Math.Round(totalCost, 2)} pesos");
    }
    // rectangle area
    static double Rect(double length, double width) {
      return length * width;
    }
    // circle area
    static double Circle(double radius) {
      return Math.PI * Math.Pow(radius, 2);
    }
    // triangle area
    static double Triangle(double bottom, double height) {
      return 0.5 * bottom * height;
    }
  }
}

/*
                    Command Line

$ dotnet run
What monument would you like to work with?
Choose: Teotihuacan (1), Taj Mahal (2), or Great Mosque of Mecca (3): 1
My plan costs: 748510782.02 pesos
$ dotnet run
What monument would you like to work with?
Choose: Teotihuacan (1), Taj Mahal (2), or Great Mosque of Mecca (3): 2
My plan costs: 1266885 pesos
$ dotnet run
What monument would you like to work with?
Choose: Teotihuacan (1), Taj Mahal (2), or Great Mosque of Mecca (3): 3
My plan costs: 14934240 pesos
$ dotnet run
What monument would you like to work with?
Choose: Teotihuacan (1), Taj Mahal (2), or Great Mosque of Mecca (3): 4
My plan costs: 0 pesos

*/
