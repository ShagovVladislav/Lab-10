using System;

namespace Lab10 {

  class Program {

    public static void Main() {
      string[,] dict = {
        {"Russia", "Moscow"},
        {"Canada", "Ottava"},
        {"France", "Paris"},
        {"Itali", "Rome"},
        {"German", "Berlin"},
        {"England", "London"},
        {"Greece", "Athens"},
        {"Japan", "Tokyo"}, 
        {"Scotland", "Edinburgh"},
        {"Sweden", "Stockholm"}
      };
      System.Console.WriteLine("Enter a name of a Country or it's capital");
      string? n = Console.ReadLine();
      for(int i = 0; i < dict.GetLength(0); i++) {
        if(n?.ToLower() == dict[i, 0].ToLower()) {
          System.Console.WriteLine($"{dict[i, 0]}'s capital is {dict[i, 1]}");
          break;
        }
        else if(n?.ToLower() == dict[i, 1].ToLower()) {
          System.Console.WriteLine($"{dict[i, 1]} is the capital of {dict[i, 0]}");
          break;
        }
      }
      System.Console.WriteLine("This country or capital is not in the dictionary");
    }
  }
}
