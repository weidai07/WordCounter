using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    public string UserSentence { get; set; }
    public string UserWord { get; set; }

    public Counter(string userSentence, string userWord)
    {
      UserSentence = userSentence.ToLower();
      UserWord = userWord.ToLower();
    }

    public int CountWords()
    { 
      int counter = 0;
      string[] sentence = UserSentence.Split(" ");

      foreach(var word in sentence)
      {
        if (word == UserWord)
        {
          counter++;
        }
      }
      return counter;
    }

  } 
}
