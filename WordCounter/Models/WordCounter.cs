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
        }
      }
      return sentenceArr;
    }

    public static bool CompareWord(string input, string compare)
    {
      return input.Equals(compare);
    }

    public static int WordCount(string word, string sentence)
    {
      int count = 0;
      string[] cleanSentence = RemovePunctuation(SentenceNormal(SentenceSplit(sentence)));
      foreach (string compare in cleanSentence)
      {
        if (CompareWord(word, compare))
        {
          count++;
        }
      }
      return count;
    }
  }
}