// Pupil.cs
using System;

namespace MagicalInheritance {
  class Pupil {
    // automatic properties
    public string Title { get; private set; }
    public string Origin { get; private set; }

    // constructor
    public Pupil (string title) { Title = title; }
    // : this(title) => will grab title via 'this', and will allow to creat a Pupil with/without 'origin'
    public Pupil (string title, string origin) : this(title) {
      Origin = origin;
    }

    // method
    public Storm CastWindStorm() {
      return new Storm("wind", false, Title);
    }
  }
}
