using System;
using Models;

public class Program
{
  public static void Main()
  {
    Bread bread = new Bread();
    Pastry pastries = new Pastry();
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
        //prompt number of bread
      }
      else if(purchaseMenuChoice == "pastry")
      {
        invalidInput = false;
        //prompt number of pastries
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
}
