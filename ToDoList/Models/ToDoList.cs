using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private static List<Item> _instances = new List<Item>{};

    public Item (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
        public static void ClearAll()
    {
      _instances.Clear();
    }
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List.");
      Console.WriteLine("Would you like to add an item to your list or view your list(Add/View)");
      string addViewList = Console.ReadLine();

      if(addViewList == "Add")
      {
        Console.WriteLine("Please add a description for the item added");
        string addedItem = Console.ReadLine();
        Item itemAddedItem = new Item(addedItem);
        itemAddedItem.Save();
        Main();
      }
      else if (addViewList == "View")
      {
        List<Item> result = Item.GetAll();
        foreach (Item thisItem in result)
        {
          Console.WriteLine("Output " + thisItem.GetDescription());
        }
        Main();
      }
    }
  }
}
