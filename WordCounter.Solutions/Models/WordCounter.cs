using System;
using System.Collections.Generic;

namespace WordCounterCheck.Models
{
  public class WordCounter
  {
      public List<string> Sentence { get; set; }
      public List<string> Words { get; set; }
      public string Input { get; set; }
      public int Search { get; set; }

      public WordCounter(string inputSentence)
      {
        Sentence = new List<string>();
        Words = new List<string>();
        Input = inputSentence;
        Search = 0;
      }

      public void AddWord(string word)
      {
        Sentence.Add(word);
      }

      public List<string> Check()
      {
        while(Sentence.Count >= 1)
        {
          CheckWord(Sentence[0], Sentence[0].Length);
          if(Search == Sentence[0].Length)
          {
            Words.Add(Sentence[0]);
          }
          Sentence.RemoveAt(0);
          Search = 0;
        }
        if(Words.Count > 0)
        {
          return Words;
        }
        Words.Add("No Matching Words");
        return Words;
      }

      private void CheckWord(string word, int size)
      {
        if(size == 0)
        {
          return;
        } else {
          size -= 1;
          for(int i = 0; i < Input.Length; i++)
          {
            if(word[size] == Input[i])
            { 
              Search += 1;
              break;
            }
          }
          CheckWord(word, size);
        }
      }
  }
}