using System;

namespace MagicalInheritance {
  class Program   {
    static void Main(string[] args) {
      // storing Strom objects in an array
      Storm[] storms = new Storm[10];
      int stormsIndex = 0;


      // instances
      Pupil pupil = new Pupil("Mezil-kree", "Icecrown");
      Mage mage = new Mage("Gul'dan", "Draenor");
      Archmage archmage = new Archmage("Nielas Aran", "Stormwind");

      // calling methods and incrementing index
      storms[stormsIndex] = pupil.CastWindStorm();
      stormsIndex++;
      storms[stormsIndex] = mage.CastRainStorm();
      stormsIndex++;
      storms[stormsIndex] = archmage.CastWindStorm();
      stormsIndex++;
      storms[stormsIndex] = archmage.CastRainStorm();
      stormsIndex++;
      storms[stormsIndex] = archmage.CastLightningStorm();
      stormsIndex++;

      Console.WriteLine("Mage Origin: " + mage.Origin);

      for (int i = 0; i < stormsIndex; i ++) {
        Console.WriteLine(storms[i].Announce());
      }
    }
  }
}
