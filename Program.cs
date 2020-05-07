using System;
using System.Collections.Generic;
using Garden.Plant;
using Disaster.Plant;

namespace Garden
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Let's go on a herb adventure!  What would you like to name your plant?");
      string myName = Console.ReadLine();

      Herb myHerb = new Herb(myName, 1, 0, 1);

      Console.WriteLine("Your plant " + myName + "is ready for you to take care of it!");
      
      while (myHerb.health > 0) 
      {
        Console.WriteLine("What would you like to do?  Enter 'water', 'sun', or 'feed', 'exit'.");
        string action = Console.ReadLine();

        if (action == "water")
        {
          myHerb.Height = myHerb.Height + 1;
        }
        else if (action == "sun")
        {
          
        }
        else if (action == "feed")
        {
          
        }
        else if (action == "exit")
        {

        }
        else
        {
          Console.WriteLine("Sorry I didn't understand your input");
        }
      }
    }
  }
}