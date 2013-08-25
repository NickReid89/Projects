using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class GameForm : Form
    {
        // Each tic tac toe button.
        Button[,] rows = new Button[3, 3];
        // an array to show who is at which square/
        int[,] progress = new int[,] {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };

        public GameForm()
        {
            int height = 100, width = 100, horizontal = 0, vertical = 0;

            InitializeComponent();
            // Creating the buttons for the game.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rows[i, j] = new Button();
                    rows[i, j].Size = new Size(height, width);
                    rows[i, j].Location = new Point(horizontal, vertical);
                    rows[i, j].Text = "";
                    
                    // Action to happen when a player clicks.
                    rows[i, j].Click += new EventHandler(Clicked);
                    horizontal += 100;
                    //Third line of buttons.
                    this.Controls.Add(rows[i, j]);
                    if (horizontal == 300 && vertical == 200)
                    {
                        horizontal = 0;
                    }
                    //Second line of buttons.
                    else if (horizontal == 300 && vertical == 100)
                    {
                        horizontal = 0;
                        vertical = 200;
                    }
                    // first line of buttons.
                    else if (horizontal == 300)
                    {
                        horizontal = 0;
                        vertical = 100;
                    }

                }

            }

        }
        // method for checking for a win.
        //private void checkSquares()
        //{
        //    // check which player has won.

        //    int compWin = 0, playerWin = 0;


        //    // check for diagnols
        //    if (progress[0, 0] == 1 && progress[1, 1] == 1 && progress[2, 2] == 1)
        //    {
        //        MessageBox.Show("Computer Wins!");
        //        BoardFreeze();
        //    }
        //    else if (progress[0, 2] == 1 && progress[1, 1] == 1 && progress[2, 0] == 1)
        //    {
        //        MessageBox.Show("Computer Wins!");
        //        BoardFreeze();
        //    }
        //    else if (progress[0, 0] == 2 && progress[1, 1] == 2 && progress[2, 2] == 2)
        //    {
        //        MessageBox.Show("Player Wins!");
        //        BoardFreeze();
        //    }
        //    else if (progress[0, 2] == 2 && progress[1, 1] == 2 && progress[2, 0] == 2)
        //    {
        //        MessageBox.Show("Player Wins!");
        //        BoardFreeze();
        //    }

        //    //Check for lines
        //    for (int i = 0; i < 3; i++)
        //    {

        //        for (int j = 0; j < 3; j++)
        //        {
        //            if (progress[i, j] == 1)
        //            {
        //                compWin++;
        //            }
        //            else if (progress[i, j] == 2)
        //            {
        //                playerWin++;
        //            }
        //            if (compWin == 3)
        //            {
        //                MessageBox.Show("Computer Wins!");
        //                BoardFreeze();
        //                compWin = 0;

        //            }
        //            else if (playerWin == 3)
        //            {
        //                MessageBox.Show("You win!");
        //                BoardFreeze();
        //                playerWin = 0;
        //            }
        //            compWin = 0;
        //            playerWin = 0;
        //        }

        //    }

        //}
        // Places player piece on board.
        private void Clicked(object sender, EventArgs args)
        {
            Button clicked = (Button)sender;
            

            if (clicked.BackColor == SystemColors.Control)
            {
                clicked.BackColor = Color.AliceBlue;
                clicked.Enabled = false;
                CheckedIfClicked();
               // checkSquares();
                
            }
            ComputerTurn();


        }
        // Method to put the players piece in an array
        private void CheckedIfClicked()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (rows[i, j].BackColor == Color.AliceBlue)
                    {
                        progress[i, j] = 2;
                    }
                }
            }
        }
        // Freezes the board at game over.
        private void BoardFreeze()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rows[i, j].Enabled = false;
                }
            }
        }
        // Let's the computer make a move.
        private void ComputerTurn()
        {         
            Random R = new Random();
            int Hor = R.Next(3);
            int Ver = R.Next(3);
          
            
                if (rows[Hor, Ver].BackColor == SystemColors.Control)
                {

                    rows[Hor, Ver].BackColor = Color.Beige;
                    progress[Hor, Ver] = 1;
                    rows[Hor, Ver].Enabled = false;
        
                }
                else
                {
                        ComputerTurn();
                }
        }
    }
}
