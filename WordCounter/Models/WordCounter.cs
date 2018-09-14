using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _specifiedWord;
    private string _text;

    public RepeatCounter(string specifiedWord, string text)
    {
      _specifiedWord = specifiedWord;
      _text = text;
    }

    public string GetSpecifiedWord()
    {
      return _specifiedWord.ToLower();
    }
    public void SetSpecifiedWord(string specifiedWord)
    {
      _specifiedWord = specifiedWord;
    }

    public string GetText()
    {
      return _text.ToLower();
    }
    public void SetText(string text)
    {
      _text = text;
    }

    public static string[] TextToWords(string originalText)
    {
      //Puntuations and space works as separators
      char[] charDelimiter = new char[] {'.',',',';',':','?','!',' '};
      string[] words = originalText.Split(charDelimiter);
      return words;
    }


    //Loop through words array and find string matching the specified word.
    public static int MatchCount(string specifiedWord, string[] wordsFromText)
    {
      int count = 0;
      foreach(string word in wordsFromText)
      {
        if (word == specifiedWord)
        {
          count++;
        }
      }
      return count;
    }
  }

  // public class Program
  // {
  //   public static void Main()
  //   {
  //     // Initial word / text setup
  //
  //     Console.WriteLine("Welcome to Chan's Word Counter.");
  //     Console.WriteLine("Please enter word you want to count");
  //     string userWord = Console.ReadLine();
  //     Console.WriteLine("Please enter text you want to analyze.");
  //     string userText = Console.ReadLine();
  //
  //     //Instantiate new word/text combination
  //     RepeatCounter newWordTextCombination = new RepeatCounter(userWord, userText);
  //     //split text into words array
  //     string[] userWordsArray = RepeatCounter.TextToWords(newWordTextCombination.GetText());
  //     //Run counting function with given inputs
  //     int userCount = RepeatCounter.MatchCount(newWordTextCombination.GetSpecifiedWord(),userWordsArray);
  //
  //     Console.WriteLine("I found "+userCount+" number of occurence(s) of "+userWord+" inside the given text!");
  //
  //
  //     // Further functionality for changing word or text input.
  //
  //     bool repeat = true;
  //     //repeat will be come false when user type "Quit" in console.
  //     while (repeat == true)
  //     {
  //       //Receive menu Input
  //       Console.WriteLine("Enter 'word' to change word to count, or 'text' to change text to analyze. Enter 'Quit' to exit the program.");
  //       string menuInput = Console.ReadLine().ToLower();
  //
  //       //Control flow for word/text/quit
  //       switch (menuInput)
  //       {
  //         case "word":
  //         Console.WriteLine("Please enter word you want to count.");
  //         userWord = Console.ReadLine();
  //         //Change the value of userWord thorugh setter.
  //         newWordTextCombination.SetSpecifiedWord(userWord);
  //
  //         userCount = RepeatCounter.MatchCount(newWordTextCombination.GetSpecifiedWord(),userWordsArray);
  //         Console.WriteLine("I found "+userCount+" number of occurence(s) of "+userWord+" inside the given text!");
  //         break;
  //
  //         case "text":
  //         Console.WriteLine("Please enter text you want to analyze.");
  //         userText = Console.ReadLine();
  //         //Change the value of userText thorugh setter.
  //         newWordTextCombination.SetText(userText);
  //
  //         //Get a new value of userText through getter and also change user WordsArray accordingly.
  //         userWordsArray = RepeatCounter.TextToWords(newWordTextCombination.GetText());
  //         userCount = RepeatCounter.MatchCount(userWord,userWordsArray);
  //         Console.WriteLine("I found "+userCount+" number of occurence(s) of "+userWord+" inside the given text!");
  //         break;
  //
  //         case "quit":
  //         Console.WriteLine("Thank you for using Word Counter...");
  //         repeat = false;
  //         break;
  //
  //         default:
  //         Console.WriteLine("Please enter valid input");
  //         break;
  //       }
  //     }
  //
  //   }
  // }
}
