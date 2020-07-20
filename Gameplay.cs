using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamPaperScissorsRock2020
{
    static class Gameplay
    {
        public static string ComputerChoice()
        {
            // Returns either Paper, Scissors or Rock (Random)
            Random myRandom = new Random();
            string[] Guess = { "", "PAPER", "SCISSORS", "ROCK" };
            return Guess[myRandom.Next(1, 4)];
        }

        public static string Play(string Human, string Comp)
        {
            // Draw Logic
            if (Human == Comp)
            {
                return "Draw";
            }
            // Winning Logic
            else if (Human == "PAPER")
            {
                if (Comp == "SCISSORS")
                {
                    return "Lose";
                }

                else if (Comp == "ROCK")
                {
                    return "Win";
                }
            }
            else if (Human == "SCISSORS")
            {
                if (Comp == "ROCK")
                {
                    return "Lose";
                }

                else if (Comp == "PAPER")
                {
                    return "Wins";
                }
            }
            else if (Human == "ROCK")
            {
                if (Comp == "PAPER")
                {
                    return "Lose";
                }

                else if (Comp == "SCISSORS")
                {
                    return "Win";
                }
            }

            return "";
        }
    }
}