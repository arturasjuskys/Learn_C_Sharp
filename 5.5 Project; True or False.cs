using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Array setup
      string[] questions = new string[] {
        "An eggplant is also known as an aubergine",
        "Eggplant are a species in the nightshade family",
        "According to botanical definition, eggplant is a vegetable",
        "When cut open, eggpants do not brown",
        "Eggplants were originally domesticated from the wild species bitter apple, or S. incanum"
      };
      bool[] answers = new bool[] {true, true, false, false, true};
      bool[] responses = new bool[questions.Length];

      // Asking questions
      if (questions.Length != answers.Length) {
        Console.WriteLine("Warning! The number of answers supplied does not match the number of questions");
      }
      int askingIndex = 0;
      foreach (string question in questions) {
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine(question);
        Console.WriteLine("True or False?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

        while (!isBool) {
          Console.WriteLine("Please respond with 'true' or 'false'");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      // Calculating score
      int scoringIndex = 0;
      int score = 0;
      foreach (bool answer in answers) {
        bool response = responses[scoringIndex];
        Console.Write(scoringIndex + 1 + ".");
        Console.WriteLine($"Input: {response} | Answer: {answer}");

        if (response == answer) {
          score++;
        }

        scoringIndex++;
      }

      Console.WriteLine($"You got {score} out of {questions.Length} correct");
    }
  }
}

/*
            Command Line

$ dotnet run
Welcome to 'True or False?'
Press Enter to begin:

An eggplant is also known as an aubergine
True or False?
true
Eggplant are a species in the nightshade family
True or False?
false
According to botanical definition, eggplant is a vegetable
True or False?
false
When cut open, eggpants do not brown
True or False?
true
Eggplants were originally domesticated from the wild species bitter apple, or S. incanum
True or False?
true
1.Input: True | Answer: True
2.Input: False | Answer: True
3.Input: False | Answer: False
4.Input: True | Answer: False
5.Input: True | Answer: True
You got 3 out of 5 correct

*/
