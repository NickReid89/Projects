using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CoinFlip
{
    public partial class Form1 : Form
    {
        int userDecision;
        int score = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
                btnRockPaperSciccors.BackgroundImage = Image.FromFile("C:\\Users\\McAwesome\\Documents\\GitHub\\Projects\\Rock,Paper,Scissors\\Rock,Paper,Scissors\\Properties\\Rock.jpg");
                btnRockPaperSciccors.BackgroundImageLayout = ImageLayout.Stretch;
                btnRockPaperSciccors.Text = "Rock";
            }
            else if (state == 1)
            {
                btnRockPaperSciccors.BackgroundImage = Image.FromFile("C:\\Users\\McAwesome\\Documents\\GitHub\\Projects\\Rock,Paper,Scissors\\Rock,Paper,Scissors\\Properties\\Paper1.jpg");
                btnRockPaperSciccors.BackgroundImageLayout = ImageLayout.Stretch;
                btnRockPaperSciccors.Text = "Paper";
            }
            else
            {
                btnRockPaperSciccors.BackgroundImage = Image.FromFile("C:\\Users\\McAwesome\\Documents\\GitHub\\Projects\\Rock,Paper,Scissors\\Rock,Paper,Scissors\\Properties\\Scissors.jpg");
                btnRockPaperSciccors.BackgroundImageLayout = ImageLayout.Stretch;
                btnRockPaperSciccors.Text = "Scissors";
            }
        }
        // Modifies Score.
        private void Score()
        {
            lblScore.Text = "Score: " + score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rectForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);  
        }


    }
}
