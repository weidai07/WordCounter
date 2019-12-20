using System;
using System.Collections.Generic;

namespace WordCounter.Models 
{
  public class Program 
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Word Counter Program!"); 
      Console.WriteLine("Please Enter a Sentence!");
      string UserSentence = Console.ReadLine();
      Console.WriteLine("Now Enter a Word!");
      string UserWord = Console.ReadLine();
      Console.WriteLine("No, the word you entered does not match any words from your sentence.");
      Console.WriteLine("Yes, the word you entered does match a word or words from your sentence.");
    } 
  }
}