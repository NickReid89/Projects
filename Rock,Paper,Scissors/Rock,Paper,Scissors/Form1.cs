using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {
        int userDecision;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void CompDecision()
        {
            // Let's the computer make a decision
            Random R = new Random();
            // Store decision
            int decision = R.Next(3);
            // Turns decision from number to word.
            State(decision);

            // decisions.
            if (userDecision == decision)
            {
                lblScore.Text = "Tie!";
            }
            else if (userDecision == 0 && decision == 1)
            {
                
                score--;
                Score();
            }
            else if (userDecision == 1 && decision == 0)
            {
                
                score++;
                Score();
            }
            else if (userDecision == 1 && decision == 2)
            {
                
                score--;
                Score();
            }
            else if (userDecision == 2 && decision == 1)
            {
                
                score++;
                Score();
            }
            else if (userDecision == 0 && decision == 2)
            {
                
                score++;
                Score();
            }
            else if (userDecision == 2 && decision == 0)
            {
                
                score--;
                Score();
            }
        }
        // Player Rock
        private void btnRock_Click(object sender, EventArgs e)
        {
            userDecision = 0;
            CompDecision();
        }
        //Player Paper
        private void btnPaper_Click(object sender, EventArgs e)
        {
            userDecision = 1;
            CompDecision();
        }
        //player Scissors
        private void btnSciccors_Click(object sender, EventArgs e)
        {
            userDecision = 2;
            CompDecision();
        }
        // Turns computer number into word.
        private void State(int state)
        {
            if (state == 0)
            {
                btnRockPaperSciccors.Text = "Rock";
            }
            else if (state == 1)
            {
                btnRockPaperSciccors.Text = "Paper";
            }
            else
            {
                btnRockPaperSciccors.Text = "Scissors";
            }
        }
        // Modifies Score.
        private void Score()
        {
            lblScore.Text = "Score: " + score.ToString();
        }
    }
}
