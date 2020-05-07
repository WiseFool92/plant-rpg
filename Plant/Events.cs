using System;
using System.Collections.Generic;

namespace Disaster.Plant
{
  public class Events
  {
    // Properties
    public bool Windstorm { get; set; }
    public bool AphidAttack { get; set; }
    public bool SlugBite { get; set; }

    // Constructor
    public Events (bool windStorm, bool aphidAttack, bool slugBite)
    {
      Windstorm = false;
      AphidAttack = false;
      SlugBite = false;
    }

    int min = 1;
    int max = 30;
    public int RandomNumber(int min, int max)
    {
      Random random = new Random();
      return random.Next(min, max);
    }
  }
}