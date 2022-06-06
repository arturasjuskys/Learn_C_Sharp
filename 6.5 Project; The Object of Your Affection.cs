/*

The Object of Your Affection

Your friend is building a new match-making service: The Object of Your Affection or OOYA for short (don’t worry, you still have time to convince them to change the name).

With your new understanding of C# objects and classes, your friend thought you could build a pretty well-organized system of dating profiles.

Your first step? Build a Profile class that allows users to generate profile objects.

The Profile should store the following information:
* User’s name
* User’s age
* User’s city
* User’s country
* User’s pronouns
* User’s hobbies

And this is how users should be able to interact with their own profiles:
* Create a new profile with some information
* Add hobbies
* View profile

*/

/////////////////////////////////////////////////////////////////////////////////
// Program.cs
using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args) {
      Profile sam = new Profile("Sam Draikla", 30, "New York", "USA", "he/him");
      sam.SetHobbies(new string[] {
        "listening to audiobooks and podcasts",
        "playing rec sports like bowling and kickball",
        "writing a speculative fiction novel",
        "reading advice column"
      });
      Console.WriteLine(sam.ViewProfile());
    }
  }
}

/////////////////////////////////////////////////////////////////////////////////
// Profile.cs
using System;

namespace DatingProfile { 
  class Profile {
    string name;
    int age;
    string city;
    string country;
    string pronouns;
    string[] hobbies;

    // constructor
    public Profile (
      string name,
      int age,
      // default parameters
      string city = "n/a",
      string country = "n/a",
      string pronouns = "they/them"
    ) {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
    }

    // methods
    public string ViewProfile() {
      string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}";

      // add hobbies in console output
      if (this.hobbies.Length > 0) {
        bio += "\nHobbies:\n";
        foreach (string hobby in hobbies) {
          bio += $"- {hobby}\n";
        }
      }

      return bio;
    }
    public void SetHobbies(string[] hobbies) {
      this.hobbies = hobbies;
    }
  }
}

/////////////////////////////////////////////////////////////////////////////////

/*
              Command Line

$ dotnet run
Name: Sam Draikla
Age: 30
City: New York
Country: USA
Pronouns: he/him
Hobbies:
- listening to audiobooks and podcasts
- playing rec sports like bowling and kickball
- writing a speculative fiction novel
- reading advice column

*/
