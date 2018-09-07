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

    // [TestMethod]
    // public void TextToSentence_ReturnSentences_StringArray()
    // {
    //   RepeatCounter newWordTextCombination = new RepeatCounter("","");
    //   newWordTextCombination.SetText("I have a dream. That my four little children will one day live in a nation: where they will not be judged by their colors, but by their characters!");
    //   string[] expectedSentences = {"i have a dream"," that my four little children will one day live in a nation"," where they will not be judged by their colors"," but by their characters",""};
    //
    //   string originalText = newWordTextCombination.GetText();
    //   string[] realSentences = RepeatCounter.TextToSentence(originalText);
    //
    //   CollectionAssert.AreEqual(expectedSentences, realSentences);
    // }

    [TestMethod]
    public void TextToSentence_ReturnSentences_StringArray()
    {
      RepeatCounter newWordTextCombination = new RepeatCounter("","");
      newWordTextCombination.SetText("I have a dream. That my four little children will one day live in a nation.");
      string[] expectedWordsArray = {"i", "have", "a", "dream","", "that", "my", "four", "little", "children", "will", "one", "day", "live", "in", "a", "nation",""};

      string originalText = newWordTextCombination.GetText();
      string[] realWordsArray = RepeatCounter.TextToWords(originalText);

      CollectionAssert.AreEqual(expectedWordsArray, realWordsArray);
    }

  }
}
