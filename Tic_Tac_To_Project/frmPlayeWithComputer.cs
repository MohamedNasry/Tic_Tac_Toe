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

    public partial class frmPlayeWithComputer : Form
    {
        Button[,] buttons = new Button[3, 3];
        enum enPlayer { Player1 = 0, Computer = 1 };
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enWinner { Player1 = 0,Computer = 1, Draw = 2, InProgress = 3 };
        struct stGameStatus
        {
            public short PlayeCount;
            public bool GameOver;
            public enWinner Winner;
        }

        stGameStatus GameStatus = new stGameStatus();
        
        public frmPlayeWithComputer()
        {
            InitializeComponent();
        }
        public void EndGame()
        {
            lblTurn.Text = "Game Over";
            if (GameStatus.GameOver)
            {
                switch (GameStatus.Winner)
                {
                    case enWinner.Player1:
                        lblWinner.Text = "Player1";

                        MessageBox.Show("Computer Defeated ", "GameOver", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        break;
                    case enWinner.Computer:
                        lblWinner.Text = "Computer";

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
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                }
                else
                {
                    GameStatus.Winner = enWinner.Computer;
                    GameStatus.GameOver = true;
                    EndGame();
                }
                return true;
            }
            return false;
        }
        public void CheckWinner()
        {

            for (int i = 0; i < 3; i++)
            {
                if (CheckValue(buttons[0, i], buttons[1, i], buttons[2, i]))
                {
                    return;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (CheckValue(buttons[i, 0], buttons[i, 1], buttons[i, 2]))
                {
                    return;
                }
            }

            if (CheckValue(buttons[0, 0], buttons[1, 1], buttons[2, 2]))
            {
                return;
            }
            if (CheckValue(buttons[0, 2], buttons[1, 1], buttons[2, 0]))
            {
                return;


            }
        }

        private void ComputerChooses()
        {
            int row = 0;
            int col = 0;
            do
            {
                Random random = new Random();

                int randomRow = random.Next(0, 3);
                int randomCol = random.Next(0, 3);
                row = randomRow;
                col = randomCol;
                

            } while (buttons[row, col].Tag.ToString() != "?");
            buttons[row, col].Image = Resources.O;
            buttons[row, col].Tag = "O";
        }
        public void ChangeImage(Button btn)
        {

            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Computer;
                        lblTurn.Text = "Computer";
                        GameStatus.PlayeCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    //case enPlayer.Computer:
                    //    ComputerChooses();
                    //    PlayerTurn = enPlayer.Player1;
                    //    lblTurn.Text = "Player 1";
                    //    GameStatus.PlayeCount++;
                        
                        
                    //    CheckWinner();
                    //    break;
                }
              
                
             }
            else
            {
                MessageBox.Show("Wrong Choise", "Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayeCount == 9)
            {
                if (!GameStatus.GameOver)
                { 
                GameStatus.Winner = enWinner.Draw;
                GameStatus.GameOver = true;
                EndGame();
                }
            }
            if (PlayerTurn == enPlayer.Computer)
            {

                if (GameStatus.GameOver)
                {
                    return;
                }
                ComputerChooses();
                PlayerTurn = enPlayer.Player1;
                lblTurn.Text = "Player 1";
                GameStatus.PlayeCount++;


                CheckWinner();

            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            
                ChangeImage((Button)sender);
            
        }
        private void PlayeWithComputer_Load(object sender, EventArgs e)
        {
            

            int buttonWidth = 97;
            int buttonHeight = 102;
            
            int Y = 166;
            for (int i = 0; i < 3; i++)
            {
                int X = 439;
                for (int j = 0; j < 3; j++)
                {


                    buttons[i, j] = new Button();
                    buttons[i, j].Name = "btn" + (i * 3 + j + 1).ToString();
                    buttons[i, j].Size = new Size(buttonWidth, buttonHeight);
                    buttons[i, j].Location = new Point(X, Y);
                    X += 231;
                    buttons[i, j].Tag = "?";
                    
                    buttons[i, j].Image = Resources.question_mark_96;
                    // buttons[i, j].Click += btn_ClicK;
                   
                        buttons[i, j].Click += new EventHandler(button_Click);
                    

                    this.Controls.Add(buttons[i, j]);
                }
                Y += 169;
            }




        }

        private void PlayeWithComputer_Paint(object sender, PaintEventArgs e)
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

        public void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Black;
            btn.Tag = "?";
        }

        private void btnRestareGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    ResetButton(buttons[i,j]);
                }
            }
            lblTurn.Text = "Player1";
            lblWinner.Text = "In Progress";

            PlayerTurn = enPlayer.Player1;
            GameStatus.PlayeCount = 0;
            GameStatus.GameOver = false;
        }
    }
   
} 

