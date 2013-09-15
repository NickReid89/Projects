namespace CoinFlip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRockPaperSciccors = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnSciccors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectForm = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRockPaperSciccors
            // 
            this.btnRockPaperSciccors.Enabled = false;
            this.btnRockPaperSciccors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRockPaperSciccors.Location = new System.Drawing.Point(229, 117);
            this.btnRockPaperSciccors.Name = "btnRockPaperSciccors";
            this.btnRockPaperSciccors.Size = new System.Drawing.Size(75, 86);
            this.btnRockPaperSciccors.TabIndex = 0;
            this.btnRockPaperSciccors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRockPaperSciccors.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.DarkOrange;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(119, 26);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(87, 25);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: ";
            // 
            // btnSciccors
            // 
            this.btnSciccors.BackgroundImage = global::CoinFlip.Properties.Resources.Scissors;
            this.btnSciccors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSciccors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSciccors.Location = new System.Drawing.Point(12, 209);
            this.btnSciccors.Name = "btnSciccors";
            this.btnSciccors.Size = new System.Drawing.Size(75, 86);
            this.btnSciccors.TabIndex = 3;
            this.btnSciccors.Text = "&Scissors";
            this.btnSciccors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSciccors.UseVisualStyleBackColor = true;
            this.btnSciccors.Click += new System.EventHandler(this.btnSciccors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = global::CoinFlip.Properties.Resources.Paper1;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(12, 117);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 86);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "&Paper";
            this.btnPaper.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = global::CoinFlip.Properties.Resources.Rock;
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(12, 26);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 85);
            this.btnRock.TabIndex = 1;
            this.btnRock.Text = "&Rock";
            this.btnRock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Computer";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectForm});
            this.shapeContainer1.Size = new System.Drawing.Size(335, 322);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rectForm
            // 
            this.rectForm.BackColor = System.Drawing.Color.DarkOrange;
            this.rectForm.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectForm.BorderColor = System.Drawing.Color.OrangeRed;
            this.rectForm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectForm.BorderWidth = 5;
            this.rectForm.CornerRadius = 40;
            this.rectForm.Location = new System.Drawing.Point(2, 2);
            this.rectForm.Name = "rectForm";
            this.rectForm.Size = new System.Drawing.Size(327, 316);
            this.rectForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectForm_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(276, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "&X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(335, 322);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSciccors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnRockPaperSciccors);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRockPaperSciccors;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnSciccors;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectForm;
        private System.Windows.Forms.Button button1;
    }
}

