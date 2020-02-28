using System;
using System.Threading;
using Models;

public class Program
{
  public static Bread bread = new Bread();
  public static Pastry pastries = new Pastry();
  public delegate void MyFunction();

  public static void Main()
  {
    MainMenu();
  }

  public static void MainMenu()
  {
    Console.Clear();
    ValidateInput("Welcome to Console Bakery! Our current prices are: \nBread - $5 each (Buy 2 get 1 Free) | Pastry - $2 each (3 for $5) \nWould you like to: 'buy' or 'quit'", "buy", PurchaseMenu);
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
        Console.WriteLine("That was not a valid command!");
        Thread.Sleep(2000);
      }
    }
  }

  // Prompts user how many of the item they wish to buy. Validates user input until integer.
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
      pastries.AddItems(quantityToPurchase);
      BuyMore();
    }
    else if(item == "bread")
    {
      bread.AddItems(quantityToPurchase);
      BuyMore();
    }
  }

  // Checks if user wants to buy more or complete purchase
  public static void BuyMore()
  {
    Console.Clear();
    ValidateInput("Would you like to:\n'complete order' or 'buy more'", "complete order", CompleteOrder, "buy more", PurchaseMenu);
  }

  // Calculates and prints reciept
  public static void CompleteOrder()
  {
    bread.CalculateOrder();
    pastries.CalculateOrder();
    Console.Clear();
    Console.WriteLine($"Your total is: ${bread.TotalCost + pastries.TotalCost}\nBread: {bread.Quantity}\nPastries: {pastries.Quantity}\nThank you for your purchase!");
    ValidateInput("Would you like to:\n'restart' or 'quit'", "restart", MainMenu);
  }

  // Runs loop to check for valid user input. Checks for passed in valid answers and runs passed in functions if user inputs valid answer
  public static void ValidateInput(string prompt, string option1, MyFunction f1, string option2 = null, MyFunction f2 = null, string option3 = null, MyFunction f3 = null)
  {
    bool invalidInput = true;
    while(invalidInput)
      {
      Console.WriteLine(prompt);
      string userChoice = Console.ReadLine();
      if(userChoice == option1)
      {
        invalidInput = false;
        if(option1 == "restart")
        {
          bread.ClearOrder();
          pastries.ClearOrder();
        }
        f1();
      }
      else if(userChoice == option2 && option2 != null && f2 != null)
      {
        invalidInput = false;
        f2();
      }
      else if(userChoice == option3 && option3 != null && f3 != null)
      {
        invalidInput = false;
        f3();
      }
      else if(userChoice == "quit")
      {
        Environment.Exit(0);
      }
      else
      {
        Console.WriteLine("That was not a valid command!");
        Thread.Sleep(2000);
        Console.Clear();
      }
    }
  }
}
