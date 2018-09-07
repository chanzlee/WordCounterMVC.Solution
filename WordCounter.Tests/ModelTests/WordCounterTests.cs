using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetSpecifiedWord_ReturnLowered_String()
    {
      RepeatCounter newWordTextCombination = new RepeatCounter("","");
      newWordTextCombination.SetSpecifiedWord("Dream");
      string result = newWordTextCombination.GetSpecifiedWord();
      Assert.AreEqual("dream", result);
    }

    [TestMethod]
    public void GetText_ReturnLowered_String()
    {
      RepeatCounter newWordTextCombination = new RepeatCounter("","");
      newWordTextCombination.SetText("I HAVE A DREAM");
      string result = newWordTextCombination.GetText();
      Assert.AreEqual("i have a dream", result);
    }

  }
}
