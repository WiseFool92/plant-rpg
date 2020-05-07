using System;
using System.Collections.Generic;

namespace Garden.Plant
{
  public class Herb
  {
    public string Name { get; set; }
    public int Height { get; set; }
    public int Flowers { get; set; }
    public int Health { get; set; }
    public Herb(string name, int height, int flower, int health)
    {
      Name = name;
      Height = height;
      Flowers = flower;
      Health = health;
    }




  }
}