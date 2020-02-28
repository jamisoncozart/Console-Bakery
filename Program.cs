using System;
using System.Threading;
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
      Console.Clear();
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
        Thread.Sleep(2000);
      }
    }
  }
  public static void PurchaseMenu()
  {
    bool invalidInput = true;
    while(invalidInput)
    {
      Console.Clear();
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
        Thread.Sleep(2000);
      }
    }
  }
  public static void BuyItem(string item)
  {
    Console.Clear();
    bool result = false;
    int quantityToPurchase = 0;   
    while(!result)
    {
      Console.WriteLine($"Please enter the amount of {item} you would like to buy?\n(Only purchase the amount of {item} you want to pay for. We will add the free {item}(s) when you complete your order.)");
      string userString = Console.ReadLine();  
      result = int.TryParse(userString, out quantityToPurchase);
    }
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
      Console.Clear();
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
        Thread.Sleep(2000);
      }
    }
  }
  public static void CompleteOrder()
  {
    bread.CalculateOrder();
    pastries.CalculateOrder();
    Console.Clear();
    Console.WriteLine($"Your total is: ${bread.TotalCost + pastries.TotalCost}\nBread: {bread.Quantity}\nPastries: {pastries.Quantity}\nThank you for your purchase!");
    bool invalidInput = true;
    while(invalidInput)
    {
      Console.WriteLine("Would you like to:\n'restart' or 'exit'");
      string restartAnswer = Console.ReadLine();
      if(restartAnswer == "restart")
      {
        invalidInput = false;
        bread.ClearOrder();
        pastries.ClearOrder();
        MainMenu();
      }
      else if(restartAnswer == "exit")
      {
        Environment.Exit(0);
      }
      else
      {
        Console.Clear();
        Console.WriteLine("That was not a valid command.");
        Thread.Sleep(2000);
      }
    }
  }
}
