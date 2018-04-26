using System.Collections.Generic;
using System;

namespace TheScore.Models
{
  public class ScoreGen
  {
    private string _word;
    private static List<string> _allLettersForOne = new List<string>() {"A", "E", "I", "O", "U", "L", "N", "R", "S", "T", "a", "e", "i", "o", "u", "l", "n", "r", "s", "t"};
    private static List<string> _allLettersForTwo = new List<string>() {"D", "G", "d", "g"};
    private static List<string> _allLettersForThree = new List<string>() {"B", "C", "M", "b", "c", "m"};
    private static List<string> _allLettersForFour = new List<string>() {"F", "H", "V", "W", "Y", "f", "h", "v", "w", "y"};
    private static List<string> _allLettersForFive = new List<string>() {"K", "k"};
    private static List<string> _allLettersForEight = new List<string>() {"J", "X", "j", "x"};
    private static List<string> _allLettersForTen = new List<string>() {"Q", "Z", "q", "z"};

    private Dictionary<int, List<string>> _letters = new Dictionary<int, List<string>>()
                                                                            {
                                                                              {1, _allLettersForOne},
                                                                              {2, _allLettersForTwo},
                                                                              {3, _allLettersForThree},
                                                                              {4, _allLettersForFour},
                                                                              {5, _allLettersForFive},
                                                                              {8, _allLettersForEight},
                                                                              {10, _allLettersForTen}
                                                                            };
    public ScoreGen(string inputWord)
    {
      _word = inputWord;
    }

    public int GetScore()
    {
      int scoreResult = 0;
      for (var i=0; i < _word.Length; i++)
      {
        foreach(KeyValuePair<int, List<string>> item in _letters)
        {
          foreach (string str in item.Value) {
            if (_word[i].ToString() == str)
            {
              scoreResult += item.Key;
            }
          }
        }

      }
      return scoreResult;
    }
  }
}
