using System.Collections.Generic;
using System;

namespace Bread
{
  public class BreadStuff
  {
    public int breadQuantity {get; set;}
    public double breadCost {get; set;}

    //Constructor
    public BreadStuff(string quantity)
    {
      int quantityToInt;
      Int32.TryParse(quantity, out quantityToInt);
      breadQuantity = quantityToInt;
      breadCost = BreadCost(breadQuantity);
    }

    public double BreadCost(int breadQuantity)
    {
      //int breadCost = 0;
      if (breadQuantity <3)
      {
        breadCost = breadQuantity * 5.00;
        Console.WriteLine("breadcost is: " + breadCost);
      }
      else if (breadQuantity >= 3)
      {
        breadCost = (breadQuantity - (breadQuantity / 3)) * 5.00;
        Console.WriteLine("breadcost is: " + breadCost);
      }
      return breadCost;
    }
  }
}

//Buy 2, get 1 free (every 3rd loaf of bread is free.). 
//A single loaf costs $5, 
//two loaves costs $10, and three loaves cost $10.