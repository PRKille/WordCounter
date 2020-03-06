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
      string[] punctSentenceArr = {"this,","is!","a'","word."};
      return punctSentenceArr;
    }
  }
}