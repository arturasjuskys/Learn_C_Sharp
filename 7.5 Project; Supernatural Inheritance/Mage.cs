// Mage.cs
using System;

namespace MagicalInheritance {
  // inherits from Pupil
  class Mage : Pupil {
    // constructor
    // base() accesses title property from Pupil
    public Mage (string title) : base(title) {}
    public Mage (string title, string origin) : base(title, origin) {}

    // virtual - marks that this method is expected to be overriden
    public virtual Storm CastRainStorm() {
      return new Storm("rain", false, Title);
    }
  }
}
