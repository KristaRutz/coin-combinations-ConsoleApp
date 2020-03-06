using System;

namespace CoinCombinations.Models
{
  public class Coin
  {
    public string Name { get; }
    public int Value { get; }

    public Coin(string name, int value)
    {
      Name = name;
      Value = value;
    }
  }
}