using System;
using System.Linq;

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
      int playerScore = 0;
      int compScore = 0;
      while (playing)
      {

        System.Console.WriteLine("Make your move: Enter rock, paper, or scissors to play! Enter 'exit' to be a quitter");
        string playerMove = Console.ReadLine().ToLower();
        int compMove = mathRandomTool.Next(1, 4);
        //comp moves == 1: rock 2: scissors 3: paper


        switch (playerMove)
        {
          case "rock":
            System.Console.WriteLine("YOU PICKED ROCK!");
            if (compMove == 1)
            {
              System.Console.WriteLine($"The computer picked Rock, you've tied. SCORE: YOU: {playerScore} COMPUTER: {compScore}");
            }
            else if (compMove == 2)
            {
              playerScore++;
              System.Console.WriteLine($"The computer picked Scissors, you win! SCORE: YOU: {playerScore} COMPUTER: {compScore}");
            }
            else
            {
              compScore++;
              System.Console.WriteLine($"The computer picked Paper, you lose =( SCORE: YOU: {playerScore} COMPUTER: {compScore}");
            }
            break;
          case "scissors":
            System.Console.WriteLine("YOU PICKED SCISSORS!");
            if (compMove == 1)
            {
              compScore++;
              System.Console.WriteLine($"The computer picked Rock, you lose =( SCORE: YOU: {playerScore} COMPUTER: {compScore}");
            }
            else if (compMove == 2)
            {
              System.Console.WriteLine($"The computer picked Scissors, you've tied! SCORE: YOU: {playerScore} COMPUTER: {compScore}");
            }
            else
            {
              playerScore++;
              System.Console.WriteLine($"The computer picked Paper, you win! SCORE: YOU: {playerScore} COMPUTER: {compScore}");
            }
            break;
          case "paper":
            System.Console.WriteLine("YOU PICKED PAPER!");
            if (compMove == 1)
            {
              playerScore++;
              System.Console.WriteLine($"The computer picked Rock, you win! SCORE: YOU: {playerScore} COMPUTER: {compScore}");
            }
            else if (compMove == 2)
            {
              compScore++;
              System.Console.WriteLine($"The computer picked Scissors, you lose =( SCORE: YOU: {playerScore} COMPUTER: {compScore}");
            }
            else
            {
              System.Console.WriteLine($"The computer picked Paper, you've tied SCORE: YOU: {playerScore} COMPUTER: {compScore}");
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
            System.Console.WriteLine("Incorrect input... Please enter 'rock', 'paper', or 'scissors'");
            break;
        }
      }
    }


  }
}
