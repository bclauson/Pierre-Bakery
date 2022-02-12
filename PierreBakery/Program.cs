using BreadSpace.Models;
using PastrySpace.Models;
using System;

namespace Bakery
{

  public class Program
  {
    public static void Main()
    {
    int result = 0;
    Console.WriteLine("Welcome to the Bakery!");
    Console.WriteLine("Our prices on bread are $5 dollars per loaf of bread, and buy two get one free.");
    Console.WriteLine("Our prices on pastries are $2 dollars per pastry or three for $5 dollars.");
    Console.WriteLine("How many loafs of bread would you like?");
    Bread userBread = new Bread(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("How many pastries would you like?");
    Pastry userPastry = new Pastry(Convert.ToInt32(Console.ReadLine()));
    result += userBread.Cost() + userPastry.Cost();
    Console.WriteLine("Your total cost will be: $" + result.ToString());
    }
  }
}
