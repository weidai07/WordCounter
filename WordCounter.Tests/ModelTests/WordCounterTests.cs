using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounterCheck.Tests
{
    [TestClass]
    public class WordCounterTester
    {
        [TestMethod]
        public void Word_CheckWord_Conversation()
        {
            Word newWord = new Word("dave");
            newWord.AddWord("vade");
            newWord.AddWord("deva");
            List<string> results = newWord.Check();
            Assert.AreEqual("deva",results[1]);
        } 
 
    }
}