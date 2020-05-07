using System;
using System.Collections.Generic;

namespace Disaster.Plant
{
  public class Events
  {
    // Properties
    public string Windstorm { get; set; }
    public string AphidAttack { get; set; }
    public string SlugBite { get; set; }

    // Constructor
    public Events (string Windstorm, string AphidAttack, string SlugBite)
    {
      Windstorm = windStorm;
      AphidAttack = AphidAttack;
      SlugBite = slugBite;
    }
  }
}