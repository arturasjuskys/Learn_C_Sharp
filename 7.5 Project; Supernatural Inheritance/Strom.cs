// Storm.cs
using System;

namespace MagicalInheritance {
  class Storm : Spell {
    // automatic properties
      // these automatic properties are required if Spell class would not be set up as abstract
    // public string Essence { get; private set; }
    // public bool IsStrong { get; private set; }
    // public string Caster { get; private set; }

    // public constructor
    public Storm(string essence, bool isStrong, string caster) {
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }

    public override string Announce() {
      if (IsStrong) {
        return $"{Caster} cast a strong {Essence} storm!";
      } else {
        return $"{Caster} cast a weak {Essence} storm!";
      }
    }
  }
}
