using System;
using Counting.Models;

namespace Counting
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Do you need to know how many times you wrote a single word?\nIt's your lucky day!\nIf you enter a sentence I will happily count the number of times a word is in it.");
      Console.WriteLine("Please enter a sentence:");
      string sentence = Console.ReadLine();
      Console.WriteLine("Which word would you like me to count?:");
      string word = Console.ReadLine();
      try
      {
        if (RepeatCounter.IsWord(word))
        {
          int count = RepeatCounter.WordCount(word, sentence);
          Console.WriteLine($"That word appears {count} times.\n\nWould you like to search again y/n?");
          string again = Console.ReadLine().ToLower();
          try
          {
            switch (again)
            {
              case "y":
                Main();
                break;
              case "n":
                Console.Clear();
                Console.WriteLine(@"
               ______  _____   _____  ______  ______  __   __ _______
              |  ____ |     | |     | |     \ |_____]   \_/   |______
              |_____| |_____| |_____| |_____/ |_____]    |    |______
                                                                      
          ");
                break;
              default:
                throw new System.InvalidOperationException("ERROR 4389 : No Banana Stickers were found. y = yes, n for no ya silly monkey!");
            }
          }
          catch (Exception ex)
          {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Message = {0}", ex.Message);
          Console.WriteLine("Source = {0}", ex.Source);
          Console.WriteLine("StackTrace = {0}", ex.StackTrace);
          Console.WriteLine("TargetSite = {0}", ex.TargetSite);
          Console.ResetColor();
          Console.WriteLine("\nPress Enter to start over.");
          Console.ReadLine();
          Main();
          }         
        }
        else
        {
          throw new System.InvalidOperationException("SassybotERROR 999 : Do you not know what a single word looks like?");
        }
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
        Console.ResetColor();
        Console.WriteLine("\nPress Enter to start over.");
        Console.ReadLine();
        Main();
      }
    }
  }
}