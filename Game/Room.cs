using System;
using System.Collections.Generic;

namespace CastleGrimtol.Game
{
  public class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public Dictionary<string, Room> Doors = new Dictionary<string, Room>();
    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      Items = new List<Item>();
    }
    public void UseItem(Item item)
    {
      
    }
     public void Move(string direction)
    {
        Doors.Add(east)
    }
  }
}