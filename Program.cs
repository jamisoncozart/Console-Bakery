using System;
using Models;

public class Program
{
  public static Bread bread = new Bread();
  public static Pastry pastries = new Pastry();
  public static void Main()
  {
    MainMenu();
  }
  public static void MainMenu()
  {
    bool invalidInput = true;
    while(invalidInput)
      {
      Console.WriteLine("Welcome to Console Bakery! Our current prices are: \nBread - $5 each (Buy 2 get 1 Free) | Pastry - $2 each (3 for $5) \nWould you like to: 'buy' or 'quit'");
      string mainMenuChoice = Console.ReadLine();
      if(mainMenuChoice == "buy")
      {
        invalidInput = false;
        PurchaseMenu();
      }
      else if(mainMenuChoice == "quit")
      {
        Environment.Exit(0);
      }
      else
      {
        Console.WriteLine("That was not a valid command.");
      }
    }
  }
  public static void PurchaseMenu()
  {
    bool invalidInput = true;
    while(invalidInput)
    {
      Console.WriteLine("What would you like to buy? \n'bread' or 'pastry' or 'quit'");
      string purchaseMenuChoice = Console.ReadLine();
      if(purchaseMenuChoice == "bread")
      {
        invalidInput = false;
        BuyItem(purchaseMenuChoice);
      }
      else if(purchaseMenuChoice == "pastry")
      {
        invalidInput = false;
        BuyItem(purchaseMenuChoice);
      }
      else if(purchaseMenuChoice == "quit")
      {
        Environment.Exit(0);
      }
      else
      {
        Console.WriteLine("That was not a valid command.");
      }
    }
  }
  public static void BuyItem(string item)
  {
    Console.WriteLine($"Please enter the amount of {item} you would like to buy: ($5 each (Buy 2 get 1 Free)");
    int quantityToPurchase = int.Parse(Console.ReadLine());
    if(item == "pastry")
    {
      pastries.AddPastries(quantityToPurchase);
      BuyMore();
    }
    else if(item == "bread")
    {
      bread.AddBread(quantityToPurchase);
      BuyMore();
    }
  }
  public static void BuyMore()
  {
    bool invalidInput = true;
    while(invalidInput)
    {
      Console.WriteLine("Would you like to:\n'complete order' or 'buy more'");
      string answer = Console.ReadLine();
      if(answer == "complete order")
      {
        invalidInput = false;
        CompleteOrder();
      }
      else if(answer == "buy more")
      {
        invalidInput = false;
        PurchaseMenu();
      }
      else
      {
        Console.WriteLine("That was not a valid command.");
      }
    }
  }
}
