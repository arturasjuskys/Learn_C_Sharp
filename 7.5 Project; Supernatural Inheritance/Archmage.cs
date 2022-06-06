// Archmage.cs
using System;

namespace MagicalInheritance {
  class Archmage : Mage {
    // constructor
    // base() accesses title, origin property from Mage
    public Archmage (string title) : base(title) {}
    public Archmage (string title, string origin) : base (title, origin) {}

    // methods
    // overriding method from Mage
    public override Storm CastRainStorm() {
      return new Storm("rain", true, Title);
    }
    public Storm CastLightningStorm() {
      return new Storm("lightning", true, Title);
    }
  }
}
