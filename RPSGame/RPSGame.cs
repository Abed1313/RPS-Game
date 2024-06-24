using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    public class RPSGame
    {
        private Player player;
        private Player ai;
        private Random random;

        public RPSGame(Player player, Player ai)
        {
            this.player = player;
            this.ai = ai;
            random = new Random();
        }

        public void PlayGAme()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            for (int i = 0; i < 3; i++)
            {
                PlayRound();
            }
            DisplayFinalScores();
            DeclareWinner();
        }

        private void PlayRound()
        {
            string playerMove = player.ChooseMove();
            string aiMove = AiChooseMove();

            Console.WriteLine($"{ai.Name} chose {aiMove}");

            int result = CompareMoves( playerMove, aiMove );

            if ( result == 1 )
            {
                Console.WriteLine($"{player.Name } wins this round!");
                player.Score++;
            }
            else if ( result == -1)
            {
                Console.WriteLine($"{player.Name } loss this round!");
                ai.Score++;
            }
            else
            {
                Console.WriteLine("This round is a draw!");
            }
            Console.WriteLine($"{player.Name} : {player.Score} - {ai.Name} : {ai.Score}");
        }

        private string AiChooseMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            int index = random.Next(moves.Length);
            return moves[index];
        }

        private int CompareMoves(string playerMove , string aiMove)
        {
            if (playerMove == aiMove)
            {
                return 0;
            }
            if((playerMove == "rock" &&  aiMove == "scissors") ||
                    (playerMove == "scissors" && aiMove == "paper") ||
                    (playerMove == "paper" && aiMove == "rock"))
            {

            return 1; 

            }
            return -1;
        }
        private void DisplayFinalScores()
        {
            Console.WriteLine("Final Score");
            Console.WriteLine($"{player.Name} : {player.Score}");
            Console.WriteLine($"{ai.Name} : {ai.Score}");
        }

        private void DeclareWinner()
        {
            if (player.Score > ai.Score)
            {
                Console.WriteLine($"{player.Name} wins the game!");
            }
            else if (player.Score < ai.Score)
            {
                Console.WriteLine($"{ai.Name} wins the game!");
            }
            else
            {
                Console.WriteLine(" The game is a draw!");
            }
        }

    }
}
