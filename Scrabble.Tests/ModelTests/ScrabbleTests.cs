using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleGame.Models;

namespace ScrabbleGame.Test
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void ScrabbleObject_CreatesInstanceOfScrabble_Scrabble()
        {
            Scrabble newScrabble = new Scrabble();
            Assert.AreEqual(typeof(Scrabble), newScrabble.GetType());
        }
    }
}