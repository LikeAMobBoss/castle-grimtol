using System.Collections.Generic;
using System;


namespace CastleGrimtol.Game
{
  public class Game : IGame
  {
    public Boolean Running { get; set; }
    public Room CurrentRoom { get; set; }
    public List<Room> Rooms { get; set; }
    public Player CurrentPlayer { get; set; }
    public void Setup()
    {
      CurrentPlayer = new Player();
      Rooms = new List<Room>();
      Help();
    }
    public string GetUserInput()
    {
      System.Console.WriteLine("What would you like to do?\n");
      string input = Console.ReadLine();
      return input;
    }
    public void Reset()
    {
      Running = true;

        Setup();
        AllRooms();
        Look(CurrentRoom);
        
    }
    public void UseItem(string ItemName)
    {
      string key = "Key";
      string sword = "Sword";
      string potion = "Potion";
      string wand = "Wand";

      if (ItemName.ToLower() == key)
      {
          CurrentRoom = CellRoom;
        Console.WriteLine("You use the key to unlock the cage");
      }
      if (ItemName.ToLower() == sword)
      {
        Console.WriteLine("As you pick up the sword it turn to dust in your hand.\n You start to sneeze uncontrollably and the metal shaving enter your throat.\n You feel the countless cuts and slowly bleed out internally.");
        System.Console.WriteLine("\nWhat a way to go!");
        System.Console.WriteLine("Do you want to play again?Y/N");
        string input = Console.ReadLine().ToLower();
        if(input == "y")
        {
          Reset();   
        }
        if(input == "n")
        {
        Running = false;
        }
      }
       if (ItemName.ToLower() == wand)
      {
        Console.WriteLine("As you pick up the wand, you hear a manic laughter inside your head.\n 'Finally, A body worthy to suit my needs'.\n You soon feel a coldness creeping into your limbs,\n as your vision fades to black you hear maniacle laughter echoing...");
        System.Console.WriteLine("\nTold you not to mess with magic.");
        System.Console.WriteLine("Do you want to play again?Y/N");
        string input = Console.ReadLine().ToLower();
        if(input == "y")
        {
          Reset();   
        }
        if(input == "n")
        {
        Running = false;
        }
      }
       if (ItemName.ToLower() == potion)
      {
        Console.WriteLine("As you drink the potion, A sense of happiness fills you.\n You feel as light as a feather, until you hear voices in your mind slowly chanting.\n'One of us..One of us...One Of Us..One Of Us...One Of Us...'\n When you look back at the table you see the potion back as if it had never left.\n As you look closer you see a shape in the swirling cloud. \n It's your own reflection torn and howling.\n The chanting get louder with every passing second \n 'One Of Us..One Of Us...ONE OF US...ONE OF US...ONE OF US!!!!' ");
        System.Console.WriteLine("\nOne of Us...Priceless");
        System.Console.WriteLine("Do you want to play again?Y/N");
        string input = Console.ReadLine().ToLower();
        if(input == "y")
        {
          Reset();   
        }
        if(input == "n")
        {
        Running = false;
        }
      }
     
      
    }
    public void TakeItem(string itemName)
    {
      Item item = CurrentRoom.Items.Find(Item => Item.Name.ToLower() == itemName);
      if (item != null)
      {
        CurrentRoom.Items.Remove(item);
        CurrentPlayer.Inventory.Add(item);
      }
    }
    public Boolean Quit(Boolean running)
    {
      System.Console.WriteLine("Leave the game? You coward. Y/N");
      string input = Console.ReadLine().ToLower();
      if (input == "y" || input == "yes")
      {
        return running = false;
      }
      else
      {
        System.Console.WriteLine("OK");
        return running = true;
      }
    }
    public void Look(Room room)
    {
      
      System.Console.WriteLine($"{room.Name}:\n{room.Description}\nItems:\n");
      for (int i = 0; i < room.Items.Count; i++)
      {
        System.Console.WriteLine($"{room.Items[i].Name}\n");
      }
      System.Console.WriteLine($"Score: {CurrentPlayer.Score}");
    
    }
    public void Help()
    {
      System.Console.WriteLine("\nDirection Only have East.\nlook which allows you to search the room for items\nHELP or h: which displays help \nTAKE or t: which takes an item and adds it to your inventory.\nINVENTORY or i: Views the items in your inventory.\nQUIT or q: leaves the game.\n");
    }
    public void AllRooms()
    {

    Room Cell = new Room ("Cell", "You wake up to the screams of pain coming from your body,\n as you focus you realize you are in a cramped cage.\n The rough bars made of hard iron press hard against your frame, barely able to hold you.\n As you gaze outside the cage, you can see just within your reach is what look like an old key. ");
    Room CellRoom = new Room("CellRoom", "As you escape the cell you look at your surroundings,\n you see three table which each hold an object. \n East of you is a door that looks as though it has stood for all of time.\n The walls are filled with bookshelves filled with books,\n all in a strange language you are unable to read.");
    Room VictoryRoom = new Room("VictoryRoom", "Congratulations Clever Adventurer,\n you have completed this wonderfully short game made by yours truely.\n Dont you feel so great now. If not, your taste is found wanting.\n Anyways lets look at your score....... Oh my. ITS OVER 9000!!  (╭ರ_⊙)  ");
    Room HiddenHatch = new Room("HiddenHatch", "You find a Hidden Hatch underneath your cell,\n its open maw seems to be an abyss call for you to enter its murky depths.\n As you progress eastward in the pitch blackness you seem to have hit the end.");
    Room HiddenDragon = new Room("HiddenDragon"," As you peek out from the hidden hatch, \n you see an immense dragon in front of you. Luckly its facing the other direction. As you look around you spy a door to the east.");
    Room DragonRoom = new Room("DragonRoom", "As you walk through the door you hear a massive clang behind you.\n A Massive portcullus has slid down, blocking the door \n and you know there is no way to open it from this side. \n As you inspect the door behind you, you hear a low rumble.\n When you turn to face the interior of the room,\n your heart seizes in your chest, across from you,\n not more than 20 paces is the largest dragon you have ever seen. \n You watch waiting to be eaten, only then do you realize the dragon is sleeping.\n Or you hope it is..... \n Suddenly with a quick snap its eyes open and as you gaze at the massive creature,\n it seems to be licking its chops. The look it gives you is one of a cat might make to a mouse.\n With a quick jerk of its head it knocks you down, then it begins to swallows you whole feet first.\n As you began to slide down its throat you feel your legs hit something hard, \n as you try to see in the damp. You spot what looks like a skeleton in ancient armor, \n when you gaze into the helmet you see your death in the reflection as the throat fills with fire. ");
        System.Console.WriteLine("\nHow do you like your meat? Rare or Well Done");
        System.Console.WriteLine("Do you want to play again?Y/N");
        string input = Console.ReadLine().ToLower();
        if(input == "y")
        {
          Reset();   
        }
        if(input == "n")
        {
        Running = false;
        }
      }


      Move();
      Rooms();
      Items();

      void Move()
      {
        Rooms.Add(Cell);
        Rooms.Add(DragonRoom);
        Rooms.Add(CellRoom);
        Rooms.Add(VictoryRoom);
      }
      void Rooms()
      {
        Cell.Move("east1", CellRoom);
        CellRoom.Move("east2", DragonRoom);
        HiddenHatch.Move("east3", DragonRoom);
        DragonRoom.Move("east4", VictoryRoom);
       
      }

      void Items()
      {
    Item Wand = new Item("Wand", "As you gaze upon the mystic relic, you cant help but think that, perhaps it might be best to leave it where it lies.As you recall the last time you encountered such an object, one of your party members decided to give that particular item a swish, you still have the bloodstains on your trousers. But hey... who knows, this one might be different. hehe");
    CellRoom.Items.Add(Wand);
    Item Key = new Item("Key", "You pick up a rusty old key. As you look closer you see it has been shaped in the image of a dragon.");
    CellRoom.Items.Add(Key);
    Item Sword = new Item("Sword", "You inspect the ancient weapon, You fear that it might break just by picking it up, it looks so worn with age. ");
    CellRoom.Items.Add(Sword);
    Item Potion = new Item("Potion", "A fairly large Potion Bottle, upon closer inspection of the murky liquid you see what looks like faces, twisted in agony in a constant state of movement within the bottle.");
    CellRoom.Items.Add(Potion);

      }
      CurrentRoom = Cell;
    }
  }
}






