using System;
using System.Collections.Generic;

namespace CastleGrimtol.Game
{
  public class Player : IPlayer
  {
    public string CharacterName;
    public int Score { get; set; }
    public List<Item> Inventory { get; set; }
    public Player()
    {
      CharacterName = NameCharacter();
      Score = 0;
      Inventory = new List<Item>();
    }
    public string NameCharacter()
    {
      
      Console.WriteLine("What would you like your character's name to be?\n");
        string CharacterName = Console.ReadLine();
        Console.WriteLine("Your character is now named " + CharacterName + "\n");
         return CharacterName;
    }
    public void ShowInventory(Player player)
    {
      System.Console.WriteLine("Your inventory:\n");
      for (int i = 0; i < player.Inventory.Count; i++)
      {
          System.Console.WriteLine($"{player.Inventory[i].Name}\n{player.Inventory[i].Description}");
      }
    }
  }
}