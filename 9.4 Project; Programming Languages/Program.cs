using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages {
  class Program {
    static void Main() {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();
      
      // to print out all DB
      foreach (var lang in languages) {
        // Console.WriteLine(lang.Prettify());
      }

      // collection made with query
      var basicInfos = languages.Select(x => $"{x.Year}, {x.Name}, {x.ChiefDeveloper}");
      // prints collection
      foreach (var lang in basicInfos) {
        // Console.WriteLine(lang);
      }

      // query, to select C# from languages and print it
      var csharpLangs = languages.Where(x => x.Name == "C#");
      foreach (var lang in csharpLangs) {
        // Console.WriteLine(lang.Prettify());
      }

      // query, select all Microsoft languages
      var microsoftLangs = languages.Where(x => x.ChiefDeveloper.Contains("Microsoft"));
      foreach (var lang in microsoftLangs) {
        // Console.WriteLine(lang.Prettify());
      }

      // query, select all predesesors 'Lisp'
      var lispLangs = languages.Where(x => x.Predecessors.Contains("Lisp"));
      foreach (var lang in lispLangs) {
        // Console.WriteLine(lang.Prettify());
      }

      // query, select language name only that contain 'script'
      var scriptLangs = languages
        .Where(x => x.Name.Contains("Script"))
        .Select(x => x.Name);
      foreach (var lang in scriptLangs) {
        // Console.WriteLine(lang);
      }

      // how many langs
      Console.WriteLine($"Number of languages: {languages.Count}");

      // query, How many languages were launched between 1995 and 2005?
      // Print a string for each of those near-millennium languages.
      var nearMilleniumLangs = languages
        .Where(x => x.Year >= 1995 && x.Year <= 2005)
        .Select(x => $"{x.Name} was invented in {x.Year}");
      Console.WriteLine($"Near millenium languages: {nearMilleniumLangs.Count()}");
      foreach (var lang in nearMilleniumLangs) {
        // Console.WriteLine(lang);
      }

      // printing predesessor Lisp langs using new static method
      // PrettyPrintAll(lispLangs);

      // printing string collections with new static method
      // PrintAll(nearMilleniumLangs);

      // query, order langs
      var ordered = languages.OrderBy(x => x.Name);
      // PrettyPrintAll(ordered);

      // query, find oldest lang
      var oldest = languages.Min(x => x.Year);
      Console.WriteLine(oldest);

    }
    ////////////////////////////////////////////////////////////////
    // refactored code into methods, PrintAll(), PrettyPrintAll()

    public static void PrettyPrintAll(IEnumerable<Language> langs) {
      foreach(Language lang in langs) {
        Console.WriteLine(lang.Prettify());
      }
    }
    public static void PrintAll(IEnumerable<Object> sequence) {
      foreach(Object obj in sequence) {
        Console.WriteLine(obj);
      }
    }
  }
}
