using System;
using CoinCombinations.Models;

namespace CoinCombinations
{
  public class Program
  {
    public static void Main()
    {
      int cents = GetChangeOwedInput();
      CoinSorter.SortCoins(cents);
    }

    public static int GetChangeOwedInput()
    {
      Console.WriteLine("Customer owes: [follow the format '$0.71' or '$12.01' or '$2']");
      Console.Write("$");
      int total = CoinSorter.ParseCents(Console.ReadLine());
      Console.WriteLine("Customer paid:");
      Console.Write("$");
      int paid = CoinSorter.ParseCents(Console.ReadLine());
      Console.WriteLine($"Change due: {CoinSorter.ConvertToDollarString(paid - total)}");
      return paid - total;
    }
  }
}