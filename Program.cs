using System;
//using System.Collections.Generic;
using Garden.Plant;
using Disaster.Plant;

namespace Garden
{
  public class Program
  {
    public static void Main()
    {
      bool play = false;
      Console.WriteLine("Let's go on a herb adventure! Do you want to play?");
      string response = Console.ReadLine();
      if (response == "yes") 
      {
        play = true;
        Console.WriteLine("Great! Let's get growing! What would you like to name your plant?");
      } 
      else 
      {
        play = false;
        Console.WriteLine("Too bad! See you later!");
      }
      
      string myName = Console.ReadLine();
      Herb myHerb = new Herb(myName, 1, 0, 1);

      Console.WriteLine("Your plant " + myHerb.Name + " is ready for you to take care of it!");

      while (play == true) 
      {
        Console.WriteLine( myHerb.Name + " is " + myHerb.Height + " inch tall and has " + myHerb.Flowers + " flowers. It has " + myHerb.Health + " health points.");
        Console.WriteLine("What would you like to do? Your action choices are: 'water', 'sun', 'feed', or 'exit'.");
        string action = Console.ReadLine(); 

        if (action == "water")
        {
          myHerb.Height = myHerb.Height + 1;
          Console.WriteLine(myHerb.Name + " is " + myHerb.Height);
        }
        else if (action == "sun")
        {
          myHerb.Flowers = myHerb.Flowers + 1;
          Console.WriteLine(myHerb.Name + " has " + myHerb.Flowers + " flowers.");
        }
        else if (action == "feed")
        {
          myHerb.Health = myHerb.Health + 1;
          Console.WriteLine(myHerb.Name + " has " + myHerb.Health + " health points.");
        }
        else if (myHerb.Health <= 0)
        {
          Console.WriteLine("Uh-oh! Your plant died!");
          play = false;
        }
        else if (action == "exit")
        {
          Console.WriteLine("Hope you enjoyed growing!");
          play = false;
        }
        else
        {
          Console.WriteLine("Sorry I didn't understand your input");
        }
        Events myEvent = new Events();
        myEvent.Disaster();
        if (myEvent.WindStorm == true) 
        {
          myHerb.Height = myHerb.Height -1;
        }
        else if (myEvent.AphidAttack == true) 
        {
          myHerb.Health = myHerb.Health -1;
        }
        else if (myEvent.SlugBite == true)
        {
          myHerb.Flowers = myHerb.Flowers -1;
        }
        else 
        {
          myHerb.Health = myHerb.Health + 1;
        }
      }
    }
  }
}