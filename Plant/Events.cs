using System;
//using System.Collections.Generic;

namespace Disaster.Plant
{
  public class Events
  {
    // Fields
    public bool WindStorm { get; set; }
    public bool AphidAttack { get; set; }
    public bool SlugBite { get; set; }

    // Constructor
    public Events ()
    {
      WindStorm = false;
      AphidAttack = false;
      SlugBite = false;
    }
    // Disaster method to determine which event initiates
    public void Disaster()
    {
      Random rand = new Random();
      int count = rand.Next(1, 5);

      if(count == 1)
      {
        WindStorm = true;
        Console.WriteLine("Oh no! A wind storm damaged your plant!");
      }
      else if(count == 2)
      {
        AphidAttack = true;
        Console.WriteLine("Here comes the aphid horde, brace for impact!");
      }
      else if(count == 3)
      {
        SlugBite = true;
        Console.WriteLine("Slime Time! The slugs are sliding in...");
      }
      else
      {
        Console.WriteLine("It is a great day to grow!");
      }
    }
  }
}