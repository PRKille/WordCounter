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
    
    [TestMethod]
    public void RemovePunctuation_RemovesPuctuationFromAllStrings()
    {
      string[] punctSentenceArr = {"?this,","isn't!","a'","word."};
      string[] noPunctSentenceArr = {"this","isn't","a","word"};
      CollectionAssert.AreEqual(RepeatCounter.RemovePunctuation(punctSentenceArr), noPunctSentenceArr);
    }

    [TestMethod]
    public void CompareWord_ReturnsTrueIfInputWordMatchesArrayWord_True()
    {
      string inputWord = "word";
      string wordFromArray = "word";
      Assert.IsTrue(RepeatCounter.CompareWord(inputWord,wordFromArray));
    }

    [TestMethod]
    public void WordCount_ReturnsNumberOfInstancesofWordinSentence_4()
    {
      string userInput = "is";
      string userSentence = "Is this is a sentence is it is?";
      Assert.AreEqual(RepeatCounter.WordCount(userInput, userSentence), 4);
    }
  }
}