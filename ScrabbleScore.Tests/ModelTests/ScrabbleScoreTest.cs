using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheScore.Models;
using System.Collections.Generic;
using System;

namespace TheScore.Tests
{
  [TestClass]
  public class ScoreGenTest
  {
    [TestMethod]
    public void IsCalculatingScoreForAA()
    {
      ScoreGen inputWord = new ScoreGen("Aa");
      int finalScore = inputWord.GetScore();
      Console.WriteLine(finalScore);

      Assert.AreEqual(2, finalScore);
    }

    [TestMethod]
    public void IsCalculatingScoreForQKJ()
    {
      ScoreGen inputWord = new ScoreGen("kQj");
      int finalScore = inputWord.GetScore();
      Console.WriteLine(finalScore);

      Assert.AreEqual(23, finalScore);
    }


  }
}
