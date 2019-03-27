using System;

namespace c_sharp_rps
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("The Most Dangerous Game!");

      //define global vars and handle player moves and generate random computer moves
      bool playing = true;
      Random mathRandomTool = new Random();
      while (playing)
      {

        System.Console.WriteLine("Make your move: Enter rock, paper, or scissors to play! Enter 'exit' to be a quitter");
        string playerMove = Console.ReadLine().ToLower();
        int compMove = mathRandomTool.Next(1, 4);
        //comp moves == 0: rock 1: scissors 2: paper


        switch (playerMove)
        {
          case "rock":
            System.Console.WriteLine("YOU PICKED ROCK!");
            if (compMove == 1)
            {
              System.Console.WriteLine("The computer picked Rock, you've tied");
            }
            else if (compMove == 2)
            {
              System.Console.WriteLine("The computer picked Scissors, you win!");
            }
            else
            {
              System.Console.WriteLine("The computer picked Paper, you lose =(");
            }
            break;
          case "scissors":
            System.Console.WriteLine("YOU PICKED SCISSORS!");
            if (compMove == 1)
            {
              System.Console.WriteLine("The computer picked Rock, you lose =(");
            }
            else if (compMove == 2)
            {
              System.Console.WriteLine("The computer picked Scissors, you've tied!");
            }
            else
            {
              System.Console.WriteLine("The computer picked Paper, you win!");
            }
            break;
          case "paper":
            System.Console.WriteLine("YOU PICKED PAPER!");
            if (compMove == 1)
            {
              System.Console.WriteLine("The computer picked Rock, you win!");
            }
            else if (compMove == 2)
            {
              System.Console.WriteLine("The computer picked Scissors, you lose =(");
            }
            else
            {
              System.Console.WriteLine("The computer picked Paper, you've tied");
            }
            break;
          case "exit":
            System.Console.WriteLine("Are you sure you want to exit? y/n");
            if (Console.ReadLine() == "y")
            {
              return;
            }
            else
            {
              continue;
            }
          default:
            System.Console.WriteLine("Please enter 'rock', 'paper', or 'scissors'");
            break;
        }
      }
    }


  }
}
