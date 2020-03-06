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
      return userSentence.Split(" ");
    }

    public static string[] SentenceNormal(string[] sentenceArr)
    {
      for(int i=0; i < sentenceArr.Length; i++)
      {
        sentenceArr[i] = sentenceArr[i].ToLower();
      }
      return sentenceArr;
    }

    public static string[] RemovePunctuation(string[] sentenceArr)
    {
      for(int i=0; i < sentenceArr.Length; i++)
      {
        if (!Char.IsLetter(sentenceArr[i][0]))
        {
          sentenceArr[i] = sentenceArr[i].Substring(1);
        }
        if (!Char.IsLetter(sentenceArr[i][sentenceArr[i].Length-1]))
        {
          sentenceArr[i] = sentenceArr[i].Remove(sentenceArr[i].Length-1);
        Console.WriteLine(sentenceArr[i]);
        }
      }
      return sentenceArr;
    }

    public static bool CompareWord(string input, string compare)
    {
      return false;
    }
  }
}