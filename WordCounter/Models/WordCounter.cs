using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _specifiedWord;
        private string _text;

        public RepeatCounter(string specifiedWord, string text)
        {
          _specifiedWord = specifiedWord.ToLower();
          _text = text.ToLower();
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
            char[] charDelimiter = new char[] {'.',',',';',':','?','!',' '};
            string[] words = originalText.Split(charDelimiter);
            return words;
        }


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

    public class Program
    {
        public static void Main()
        {
          Console.WriteLine("Welcome to Chan's Word Counter.");
          Console.WriteLine("Please enter word you want to count");
          string userWord = Console.ReadLine();
          Console.WriteLine("Please enter text you want to analyze.");
          string userText = Console.ReadLine();

          RepeatCounter newWordTextCombination = new RepeatCounter(userWord, userText);
          string[] userWordsArray = RepeatCounter.TextToWords(newWordTextCombination.GetText());
          int userCount = RepeatCounter.MatchCount(newWordTextCombination.GetSpecifiedWord(),userWordsArray);
          Console.WriteLine("I found "+userCount+" number of occurence(s) inside the given text!");





          // Console.WriteLine("Enter 'word' to change word to count, or 'text' to change text to analyze.");
          // string menuInput = Console.ReadLine().ToLower();
          //
          //
          // switch (menuInput)
          // {
          //   case "word":
          //     Console.WriteLine("Please enter word you want to count.");
          //     string userWord = Console.ReadLine();
          //
          //     break;
          //
          //   case "text":
          //     Console.WriteLine("Please enter text you want to analyze.");
          //     string userText = Console.ReadLine();
          //     break;
          // }

        }
    }
}
