using System.Collections.Generic;
using System;

namespace Bread
{
  public class BreadStuff
  {
    public int breadQuantity {get; set;}
    public int breadCost {get; set;}

    //Constructor
    public BreadStuff(string quantity)
    {
      int quantityToInt;
      Int32.TryParse(quantity, out quantityToInt);
      breadQuantity = quantityToInt;
      //breadCost will equal a function that calculates the cost
    }
  }
}

//Buy 2, get 1 free (every 3rd loaf of bread is free.). 
//A single loaf costs $5, 
//two loaves costs $10, and three loaves cost $10.