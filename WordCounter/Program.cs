using System;
using System.Collections.Generic;

namespace WordCounter.Models 
{
  public class Program 
  {
    static void Main() 
    {

       Console.WriteLine("Please Enter a Sentence");
       string userSentence = Console.ReadLine();

       Console.WriteLine("Please Enter a Word");
       string userWord = Console.ReadLine();

       Counter userEntries = new Counter(userSentence, userWord);

       Console.WriteLine(userEntries.CountWords());
     
      
    }
  }
}
