// Spell.cs
using System;

namespace MagicalInheritance {
  // abstract => means that subclass needs to re-define it in Storm
  abstract class Spell {
    public string Essence { get; protected set; }
    public bool IsStrong { get; protected set; }
    public string Caster { get; protected set; }
    
    public abstract string Announce();
  }
}
