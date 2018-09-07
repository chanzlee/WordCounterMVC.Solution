using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    //Test both getters for word/text return lower cased outputs.
    [TestMethod]
    public void GetSpecifiedWord_ReturnLowered_String()
    {
      //arrange
      RepeatCounter newWordTextCombination = new RepeatCounter("","");
      newWordTextCombination.SetSpecifiedWord("Dream");
      //act
      string result = newWordTextCombination.GetSpecifiedWord();
      //assert
      Assert.AreEqual("dream", result);
    }

    [TestMethod]
    public void GetText_ReturnLowered_String()
    {
      //arrange
      RepeatCounter newWordTextCombination = new RepeatCounter("","");
      newWordTextCombination.SetText("I HAVE A DREAM");
      //act
      string result = newWordTextCombination.GetText();
      //assert
      Assert.AreEqual("i have a dream", result);
    }

    //Test text separating function
    [TestMethod]
    public void TextToWords_ReturnWords_StringArray()
    {
      //arrange
      RepeatCounter newWordTextCombination = new RepeatCounter("","");
      newWordTextCombination.SetText("I have a dream. That my four little children will one day live in a nation.");
      string[] expectedWordsArray = {"i", "have", "a", "dream","", "that", "my", "four", "little", "children", "will", "one", "day", "live", "in", "a", "nation",""};

      //act (get the text to separate, and create string array returning separation result)
      string originalText = newWordTextCombination.GetText();
      string[] realWordsArray = RepeatCounter.TextToWords(originalText);

      //assert
      CollectionAssert.AreEqual(expectedWordsArray, realWordsArray);
    }

    //Test match counting function
    [TestMethod]
    public void MatchCount_ReturnCount_Int()
    {
      //arrange
      RepeatCounter newWordTextCombination = new RepeatCounter("","");
      newWordTextCombination.SetSpecifiedWord("dream");
      newWordTextCombination.SetText("I have a dream. That my four little children will one day live in a nation. I have a dream.");
      string originalText = newWordTextCombination.GetText();
      string[] wordsArray = RepeatCounter.TextToWords(originalText);
      string specifiedWord = newWordTextCombination.GetSpecifiedWord();
      int expectedCount = 2;

      //act
      int realCount = RepeatCounter.MatchCount(specifiedWord, wordsArray);

      //assert
      Assert.AreEqual(expectedCount, realCount);
    }
  }
}
