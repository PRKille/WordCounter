using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counting.Models;
using System;

namespace Counting.Tests
{
  [TestClass]
  public class MakeFilesTests
  {
    [TestMethod]
    public void IsWord_ChecksForSingleWord_False()
    {
      string userInput = "is word";
      Assert.AreEqual(RepeatCounter.IsWord(userInput), false);
    }

    [TestMethod]
    public void SentenceSplit_SepparateInputSentenceIntoArray_Array()
    {
      string userSentence = "This is a word.";
      string[] sentenceArr = {"This","is","a","word."};
      CollectionAssert.AreEqual(RepeatCounter.SentenceSplit(userSentence), sentenceArr);
    }

    [TestMethod]
    public void SentenceNormal_NormalizesAllWordsToLowercase_Array()
    {
      string[] sentenceArr = {"This","is","a","word."};
      string[] smallSentenceArr = {"this","is","a","word."};
      CollectionAssert.AreEqual(RepeatCounter.SentenceNormal(sentenceArr), smallSentenceArr);
    }
    
  }
}