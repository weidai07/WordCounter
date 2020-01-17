using System;
using System.Collections.Generic;

namespace WordCounterCheck.Models {
  public class Program {
    static void Main()
    {
    
      Console.WriteLine("Please Enter a Sentence");
      string UserInput = Console.ReadLine().ToLower();
      WordCounter MyWord = new WordCounter(UserInput);
      while(UserInput != "1")
      { 
        Console.WriteLine("Please Enter the Word You Would Like to Search");
        UserInput = Console.ReadLine().ToLower();
        if (UserInput == "1")
        {
          break;
        }
        else
        {
          MyWord.AddWord(UserInput);
        }
      }
      List<string> results = MyWord.Check();
      Console.WriteLine("Matches: ");
      foreach(string checker in results)
      {
        Console.WriteLine(checker);
      }
    }
  }
}