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
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\McAwesome\Documents\CoffeeCup Software\Sounds\cash.wav");
            sp.Play();
        }

        private void CompDecision()
        {
            Random R = new Random();
            int decision = R.Next(3);
            
            State(decision);


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

        private void btnRock_Click(object sender, EventArgs e)
        {
            userDecision = 0;
            CompDecision();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            userDecision = 1;
            CompDecision();
        }

        private void btnSciccors_Click(object sender, EventArgs e)
        {
            userDecision = 2;
            CompDecision();
        }
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
        private void Score()
        {
            lblScore.Text = "Score: " + score.ToString();
        }
    }
}
