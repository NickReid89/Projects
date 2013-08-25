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
        Button[,] rows = new Button[3, 3];
        int[,] progress = new int[3, 3];
        public GameForm()
        {
            int height = 100, width = 100, horizontal = 0, vertical = 0;
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rows[i, j] = new Button();
                    rows[i, j].Size = new Size(height, width);
                    rows[i, j].Location = new Point(horizontal, vertical);
                    rows[i, j].Click += new EventHandler(Click);
                    horizontal += 100;

                    this.Controls.Add(rows[i, j]);
                    if (horizontal == 300 && vertical == 200)
                    {
                        horizontal = 0; 
                    }
                    else if (horizontal == 300 && vertical == 100)
                    {
                        horizontal = 0;
                        vertical = 200;
                    }
                    else if (horizontal == 300)
                    {
                        horizontal = 0;
                        vertical = 100;
                    }

                }
               
            }

        }

        private void checkSquares()
        {
            for (int i = 0; i < 3; i++)
            {
                int compWin = 0,playerWin = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (progress[i, j] == 1)
                    {
                        compWin++;
                    }
                    else if (progress[i, j] == 2)
                    {
                        playerWin++;
                    }
                    if (compWin == 3)
                    {
                        MessageBox.Show("Computer Wins!");
                     

                    }
                    else if (playerWin == 3)
                    {
                        MessageBox.Show("You win!");
                     
                    }
                }
                
            }
       
        }
        //new
        private void Click(object sender, EventArgs args)
        {
            Button clicked = (Button)sender;
            clicked.BackColor = Color.AliceBlue;
            CheckedIfClicked();
            checkSquares();
            Boolean CompTurn = false;
            Random H = new Random();
            Random V = new Random();
            int Hor = H.Next(3);
            int  Ver = V.Next(3);
            




            while (rows[Hor, Ver].BackColor != Color.AliceBlue && rows[Hor, Ver].BackColor != Color.Beige)
            {
                H.Next(2);
                V.Next(2);
                rows[Hor, Ver].BackColor = Color.Beige;
                progress[Hor, Ver] = 1;
                CompTurn = true;
            }
            //if (rows[Hor, Ver].BackColor != Color.AliceBlue && rows[Hor, Ver].BackColor != Color.Beige)
            //{
            //    rows[Hor, Ver].BackColor = Color.Beige;
            //    progress[Hor, Ver] = 2;
            //    CompTurn = true;
            //}
 
 

            
       }
        private void CheckedIfClicked()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(rows[i,j].BackColor == Color.AliceBlue){
                        progress[i,j] = 2;
                    }
                }
            }
        }

    }
}
