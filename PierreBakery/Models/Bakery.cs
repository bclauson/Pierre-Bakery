using System.Collections.Generic;

namespace BreadSpace.Models
{
  public class Bread
  {
    public int BreadDemand { get;set; }

    public Bread(int breadDemand)
    {
      BreadDemand = breadDemand;
    }

    public int Cost() 
    {
      int finalCost = 0;
      if (BreadDemand >= 3)
      {
        finalCost += (BreadDemand / 3) * 10;
      }
      finalCost += (BreadDemand%3) * 5;

      return finalCost;
    }

  }
}

namespace PastrySpace.Models
{
  public class Pastry
  {
    public int PastryDemand { get;set; }

    public Pastry(int pastryDemand)
    {
      PastryDemand = pastryDemand;
    }

    public int Cost()
    {
      int finalCost = 0;

      finalCost += (PastryDemand / 3) * 5;
      finalCost += (PastryDemand % 3) * 2;

      return finalCost;
      
    }

  }
}