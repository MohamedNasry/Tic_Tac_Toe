namespace Tic_Tac_To_Project
{
    partial class frmPlayeWithComputer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestareGame = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(443, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic_Tac_Toe Game";
            // 
            // btnRestareGame
            // 
            this.btnRestareGame.BackColor = System.Drawing.Color.Black;
            this.btnRestareGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestareGame.ForeColor = System.Drawing.Color.White;
            this.btnRestareGame.Location = new System.Drawing.Point(52, 470);
            this.btnRestareGame.Name = "btnRestareGame";
            this.btnRestareGame.Size = new System.Drawing.Size(276, 52);
            this.btnRestareGame.TabIndex = 10;
            this.btnRestareGame.Text = "Restar Game";
            this.btnRestareGame.UseVisualStyleBackColor = false;
            this.btnRestareGame.Click += new System.EventHandler(this.btnRestareGame_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWinner.Location = new System.Drawing.Point(76, 386);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(219, 47);
            this.lblWinner.TabIndex = 9;
            this.lblWinner.Text = "In Progress";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(114, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Winner";
            // 
            // lblTurn
            // 
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTurn.Location = new System.Drawing.Point(67, 218);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(251, 47);
            this.lblTurn.TabIndex = 7;
            this.lblTurn.Text = "Player 1";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(136, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turn";
            // 
            // PlayeWithComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1082, 654);
            this.Controls.Add(this.btnRestareGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlayeWithComputer";
            this.Text = "PlayeWithComputer";
            this.Load += new System.EventHandler(this.PlayeWithComputer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayeWithComputer_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestareGame;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label2;
    }
}