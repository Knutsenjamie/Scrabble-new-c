using System;

namespace ScrabbleGame.Models
{
  public class Scrabble
  {
    public string PlayerWord{ get; }
    public Scrabble(string playerWord)
    {
      PlayerWord = playerWord;
    }
    public bool PlayerWordToArray(string playerWord)
    {
      char[] playerWordArray = playerWord.ToCharArray(); 
      Type valueType = playerWordArray.GetType();
      return valueType.IsArray;
    }
  }
}
