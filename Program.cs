using System;
using Models;

public class Program
{
  public static void Main()
  {
    Bread bread = new Bread();
    Pastry pastries = new Pastry();
    bool invalidInput = true;
    while(invalidInput)
      {
      string mainMenuChoice = MainMenu();
      if(mainMenuChoice == "buy")
      {
        invalidInput = false;
        //start purchase menu
        Console.WriteLine($"Bread Cost: {bread.Cost}, Pastry Cost: {pastries.Cost}");
      }
      else if(mainMenuChoice == "quit")
      {
        Environment.Exit(0);
      }
      else
      {
        Console.WriteLine("That was not a valid command. Please type 'buy' or 'quit'");
      }
    }
  }
  public static string MainMenu()
  {
    Console.WriteLine("Welcome to Console Bakery! Our current prices are: \nBread - $5 each (Buy 2 get 1 Free) | Pastry - $2 each (3 for $5) \nWould you like to: 'buy' or 'quit'");
    return Console.ReadLine();
  }
}