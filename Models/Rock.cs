using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Rock.Models
{
  public class Game
  {
    private string _player1;
    private string _player2;

    private static List<string> _choices = new List<string>{};

    public Game (string player1Choice, string player2Choice)
    {
      _player1 = player1Choice;
      _choices.Add(_player1);
      _player2 = player2Choice;
      _choices.Add(_player2);
    }

    // public Game (string player1Choice, string player2Choice)
    // {
    //   _player1 = player1Choice;
    //   _player2 = player2Choice;
    // }

    public string GetPlayer1()
    {
      return _player1;
    }

    public string GetPlayer2()
    {
      return _player2;
    }

    public string SelectWinner()
    {
      if (_player1 == _player2)
      {
        return "draw";
      }
      else if(_choices.Contains("rock") && _choices.Contains("scissors"))
      {
        return ("Player " + (_choices.IndexOf("rock") + 1).ToString());
      }
      else if(_choices.Contains("paper") && _choices.Contains("scissors"))
      {
        return ("Player " + (_choices.IndexOf("scissors") + 1).ToString());
      }
      else if(_choices.Contains("rock") && _choices.Contains("paper"))
      {
        return ("Player " + (_choices.IndexOf("paper") + 1).ToString());
      }
      else
      {
        return "";
      }
    }
    public static void ClearAll()
    {
      _choices.Clear();
    }
  }
}
