using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Tests
{
    [TestClass]
    public class CounterTester
    {
        [TestMethod]
        public void CheckObjects_CheckType_True()
        {
            string sentence = "There are many cars on the street.";
            string word = "cars";
            Counter test1 = new Counter(sentence, word);
            Assert.AreEqual(typeof(Counter), test1.GetType());
        } 

        [TestMethod]

        public void CountWords_NumberOfWords_2()
        {
            string sentence = "Water is great, water is my favorite drink.";
            string word = "water";
            Counter test2 = new Counter(sentence, word);
            Assert.AreEqual(2, test2.CountWords());
        }
  
    }
}
