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
  
        [TestMethod]

        public void CountWords_NoMatch_0()
        {
            string sentence = "There are 4 sides to a square.";
            string word = "circle";
            Counter test3 = new Counter(sentence, word);
            Assert.AreEqual(0, test3.CountWords());
        }

        [TestMethod]

        public void CountWords_PartialWords_1()
        {
            string sentence = "The race is on the racetrack.";
            string word = "race";
            Counter test4 = new Counter(sentence, word);
            Assert.AreEqual(1, test4.CountWords());
        }

        [TestMethod]

        public void CountWords_MultipleWords_3()
        {
            string sentence = "Tsk tsk tsk! I like the word tsk a lot!";
            string word = "tsk";
            Counter test5 = new Counter(sentence, word);
            Assert.AreEqual(3, test5.CountWords());
        }

        [TestMethod]

        public void CountWords_CapialWords_4()
        {
            string sentence = "one One oNe OnE";
            string word = "one";
            Counter test6 = new Counter(sentence, word);
            Assert.AreEqual(4, test6.CountWords());
        }
    }
}
