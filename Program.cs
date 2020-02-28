using System;
using Models;

public class Program
{
  public static void Main()
  {
    Bread.Cost = 5;
    Console.WriteLine($"Bread Cost: {Bread.Cost}, Quantity: {Bread.Quantity}, Total Cost: {Bread.TotalCost}");
  }
}