using System;

namespace Counting.Models
{
  public class RepeatCounter
  {
    public static bool IsWord(string input)
    {
      if (input == "")
      {
          return false;
      } 
      else if (input.Contains(" "))
      {
        return false;
      } 
      else 
      {
        return true;
      }
    }

    public static string[] SentenceSplit(string userSentence)
    {
      string[] sentenceArr = userSentence.Split(" ");

      return sentenceArr;
    }


  }
}