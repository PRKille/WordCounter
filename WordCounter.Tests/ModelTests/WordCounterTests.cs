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

  }
}