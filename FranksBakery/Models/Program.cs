using System;
using System.Collections.Generic;
using Bread;

namespace MainProgram
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Frank's Bakery!");
      //Here is the price for bread and pastry
      Console.Write("How many loaves of bread would you like?: ");
      string loavesOfBread = Console.ReadLine();

      BreadStuff breadOrder = new BreadStuff(loavesOfBread);
      Console.WriteLine(breadOrder.breadQuantity);

    }
  }
}