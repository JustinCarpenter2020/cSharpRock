using System;
using System.Collections.Generic;

namespace cSharpRock.models
{
    public class Game
    {

        //method on the class game called play, takes in a string for the computer choice and a string for the player choice
    public string play(string computer, string user){
        //this is a dictionary of all the win conditions, the key is the choice the value is what beats it
            var wins = new Dictionary<string, string>{
          {"rock", "paper"},
          {"paper", "scissors"},
          {"scissors", "rock"}
      };
      //if the wins dictionary at that choice contains my choice I know I won
      if(wins[computer].Contains(user) ){
          Console.WriteLine("You Win!");
        return "you win";
      } else if(computer == user){
           Console.WriteLine("You tie!");
          return "Tie";
      } else{
           Console.WriteLine("You lose!");
          return "you lose";
      }
    }
    public Game()
    {

    }
    }
}