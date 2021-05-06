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
            Scrabble newScrabble = new Scrabble("COFFEE");
            Assert.AreEqual(typeof(Scrabble), newScrabble.GetType());
        }

        [TestMethod]
        public void GetPlayerWord_ReturnPlayerWord_String()
        {
            //Arrange
            string player1Word = "PLANT";
            Scrabble newScrabble = new Scrabble(player1Word);

            //Act
            string result = newScrabble.PlayerWord;

            //Assert
            Assert.AreEqual(player1Word, result);

        }
    }
}