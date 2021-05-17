using System;
using System.Collections.Generic;
using cSharpRock.models;

namespace cSharpRock
{
    class Program
    {
        static void Main(string[] args)
        {
                  Console.Clear();
             bool running = true;
             //an array of options
            List<string> choices = new List<string>(){
                "rock",
                "paper",
                "scissors"
            };

            var game = new Game();
            while(running){
            Random random = new Random();
            var index = random.Next(0, 3);
            var computerChoice = choices[index];
            Console.WriteLine("Rock, Paper, or Scissors?");
            var playerChoice = Console.ReadLine();

            if(playerChoice == "quit"){
                running = false;
            }else if(choices.Contains(playerChoice)) {
            game.play(computerChoice, playerChoice);
            } else{
                Console.WriteLine("That is not a choice");
            }
            }

        }
    }
}
