using System;
using System.Collections.Generic;
using Bread;

namespace MainProgram
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Frank's Bakery! Bread is $5.00 a loaf and pastry is $2.00 each or 3 for $5.00");
      //Here is the price for bread and pastry
      Console.Write("How many loaves of bread would you like?: ");
      string loavesOfBread = Console.ReadLine();
      Console.Write("How many pastries would you like?: ");
      string numberOfPastries = Console.ReadLine();

      BreadStuff breadOrder = new BreadStuff(loavesOfBread);
      Console.WriteLine(breadOrder.breadQuantity);

    }
  }
}