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
            string[] Guess = { "", "Paper", "Scissors", "Rock" };
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
            else if (Human == "Paper")
            {
                if (Comp == "Scissors")
                {
                    return "Comp Win";
                }

                else if (Comp == "Rock")
                {
                    return "Human Wins";
                }
            }
            else if (Human == "Scissors")
            {
                if (Comp == "Rock")
                {
                    return "Comp Win";
                }

                else if (Comp == "Paper")
                {
                    return "Human Wins";
                }
            }
            else if (Human == "Rock")
            {
                if (Comp == "Paper")
                {
                    return "Comp Win";
                }

                else if (Comp == "Scissors")
                {
                    return "Human Wins";
                }
            }
            else
            {
                return "";
            }

        }
    }
}