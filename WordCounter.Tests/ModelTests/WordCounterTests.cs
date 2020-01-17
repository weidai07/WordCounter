using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterCheck.Models;
using System.Collections.Generic;

namespace WordCounterCheck.Tests
{
    [TestClass]
    public class WordCounterTester
    {
        [TestMethod]
        public void Word_CheckWord_Conversation()
        {
            WordCounter newWord = new WordCounter("dave");
            newWord.AddWord("vade");
            newWord.AddWord("deva");
            List<string> results = newWord.Check();
            Assert.AreEqual("deva",results[1]);
        } 
 
    }
}