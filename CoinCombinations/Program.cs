using System;
using Project.Models;

namespace Project
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("How many cents change are owed?");
      int cents = int.Parse(Console.ReadLine());
      CoinSorter.HowManyCoins(cents, 0);
    }
  }
}