using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_To_Project.Properties;

namespace Tic_Tac_To_Project
{
    public partial class frmPlayeWithOnotherPerson : Form
    {
        public frmPlayeWithOnotherPerson()
        {
            InitializeComponent();
        }
        enum enWinner { Player1=0 , Player2 = 1,Draw =2 ,InProgress = 3};

        struct stGamerStatus
        {
            public short PlayeCount;
            public bool GameOver;
            public enWinner Winner;
        }

        stGamerStatus GamerStatus = new stGamerStatus ();
        
        private enum enPlayer { Player1 = 0, Player2 = 1};
        enPlayer PlayerTurn = enPlayer.Player1;

        public void EndGame()
        {
            lblTurn.Text = "Game Over";
            if (GamerStatus.GameOver)
            {
                switch (GamerStatus.Winner)
                {
                    case enWinner.Player1:
                        lblWinner.Text = "Player1";
                        
                        MessageBox.Show("Player 2 Defeated ", "GameOver", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        
                        break;
                    case enWinner.Player2:
                        lblWinner.Text = "Player2";
                       
                        MessageBox.Show("Player 1 Defeated", "GameOver", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        
                        break;
                    case enWinner.Draw:
                        lblWinner.Text = "Draw";
                      
                        MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                       
                        break;
                }
            }
        }
        public bool CheckValue(Button btn1, Button btn2, Button btn3)
        {
            
            if (btn1.Tag.ToString() != "?" && btn1.Tag == btn2.Tag && btn1.Tag == btn3.Tag)
            {
                btn1.BackColor = Color.YellowGreen;
                btn2.BackColor = Color.YellowGreen;
                btn3.BackColor = Color.YellowGreen;

                if (btn1.Tag.ToString() == "X")
                {
                    GamerStatus.Winner = enWinner.Player1;
                    GamerStatus.GameOver = true;
                    EndGame();
                }
                else
                {
                    GamerStatus.Winner = enWinner.Player2;
                    GamerStatus.GameOver = true;
                    EndGame();
                }
                return true;    
            }
            

            return false;
        }

        public void CheckWinner()
        {

            if (CheckValue(btn1, btn2, btn3))
                return;

            if (CheckValue(btn4, btn5, btn6))
                return;

            if (CheckValue(btn7, btn8, btn9))
                return;

            if (CheckValue(btn1, btn5, btn9))
                return;

            if (CheckValue(btn3, btn5, btn7))
                return;
            
            if(CheckValue(btn1, btn4, btn7))
                return;
            
            if(CheckValue(btn2, btn5, btn8))
                return;
            
            if(CheckValue(btn3, btn6 , btn9))
                return;
        }

        public void ChangeImage(Button btn)
        {

            if(btn.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player 2";
                        GamerStatus.PlayeCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player 1";
                        GamerStatus.PlayeCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choise", "Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (GamerStatus.PlayeCount == 9)
            {
                if (!GamerStatus.GameOver)
                {
                    GamerStatus.Winner = enWinner.Draw;
                    GamerStatus.GameOver = true;
                    EndGame();
                }
                
            }

        }

        public void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Black;
            btn.Tag = "?";
        }


        public void InitializationValue()
        {
            ResetButton(btn1);
            ResetButton(btn2);
            ResetButton(btn3);
            ResetButton(btn4);
            ResetButton(btn5);
            ResetButton(btn6);
            ResetButton(btn7);
            ResetButton(btn8);
            ResetButton(btn9);
                





            lblTurn.Text = "Player1";
            lblWinner.Text = "In Progress";
                
            PlayerTurn = enPlayer.Player1;
            GamerStatus.PlayeCount = 0;
            GamerStatus.GameOver = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            InitializationValue();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen WhitePen = new Pen(White);

            WhitePen.Width = 10;

            WhitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            WhitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(WhitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(WhitePen, 400, 460, 1050, 460);

            e.Graphics.DrawLine(WhitePen, 610, 148, 610, 628);
            e.Graphics.DrawLine(WhitePen, 840, 148, 840, 628);

        }

        private void btnRestareGame_Click(object sender, EventArgs e)
        {
            InitializationValue();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }
     
    }
}
