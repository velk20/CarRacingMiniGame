
namespace CarRacingMiniGame
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbGameOver = new System.Windows.Forms.Label();
            this.lbCoins = new System.Windows.Forms.Label();
            this.pbCoin4 = new System.Windows.Forms.PictureBox();
            this.pbCoin2 = new System.Windows.Forms.PictureBox();
            this.pbCoin3 = new System.Windows.Forms.PictureBox();
            this.pbCoin1 = new System.Windows.Forms.PictureBox();
            this.pbEnemy3 = new System.Windows.Forms.PictureBox();
            this.pbEnemy2 = new System.Windows.Forms.PictureBox();
            this.pbEnemy1 = new System.Windows.Forms.PictureBox();
            this.pbMyCar = new System.Windows.Forms.PictureBox();
            this.pbRightLine = new System.Windows.Forms.PictureBox();
            this.pbLeftLine = new System.Windows.Forms.PictureBox();
            this.pbLine3 = new System.Windows.Forms.PictureBox();
            this.pbLine6 = new System.Windows.Forms.PictureBox();
            this.pbLine5 = new System.Windows.Forms.PictureBox();
            this.pbLine4 = new System.Windows.Forms.PictureBox();
            this.pbLine1 = new System.Windows.Forms.PictureBox();
            this.pbLine2 = new System.Windows.Forms.PictureBox();
            this.lbStartMovement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.BackColor = System.Drawing.Color.DarkOrange;
            this.lbGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameOver.ForeColor = System.Drawing.Color.Red;
            this.lbGameOver.Location = new System.Drawing.Point(93, 42);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(186, 31);
            this.lbGameOver.TabIndex = 7;
            this.lbGameOver.Text = "GAME OVER";
            // 
            // lbCoins
            // 
            this.lbCoins.AutoSize = true;
            this.lbCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCoins.ForeColor = System.Drawing.Color.Gold;
            this.lbCoins.Location = new System.Drawing.Point(14, 9);
            this.lbCoins.Name = "lbCoins";
            this.lbCoins.Size = new System.Drawing.Size(74, 20);
            this.lbCoins.TabIndex = 12;
            this.lbCoins.Text = "Coins=0";
            // 
            // pbCoin4
            // 
            this.pbCoin4.Image = global::CarRacingMiniGame.Properties.Resources.coin;
            this.pbCoin4.Location = new System.Drawing.Point(323, 266);
            this.pbCoin4.Name = "pbCoin4";
            this.pbCoin4.Size = new System.Drawing.Size(30, 30);
            this.pbCoin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin4.TabIndex = 11;
            this.pbCoin4.TabStop = false;
            // 
            // pbCoin2
            // 
            this.pbCoin2.Image = global::CarRacingMiniGame.Properties.Resources.coin;
            this.pbCoin2.Location = new System.Drawing.Point(144, 239);
            this.pbCoin2.Name = "pbCoin2";
            this.pbCoin2.Size = new System.Drawing.Size(30, 30);
            this.pbCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin2.TabIndex = 10;
            this.pbCoin2.TabStop = false;
            // 
            // pbCoin3
            // 
            this.pbCoin3.Image = global::CarRacingMiniGame.Properties.Resources.coin;
            this.pbCoin3.Location = new System.Drawing.Point(272, 22);
            this.pbCoin3.Name = "pbCoin3";
            this.pbCoin3.Size = new System.Drawing.Size(30, 30);
            this.pbCoin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin3.TabIndex = 9;
            this.pbCoin3.TabStop = false;
            // 
            // pbCoin1
            // 
            this.pbCoin1.Image = global::CarRacingMiniGame.Properties.Resources.coin;
            this.pbCoin1.Location = new System.Drawing.Point(99, 79);
            this.pbCoin1.Name = "pbCoin1";
            this.pbCoin1.Size = new System.Drawing.Size(30, 30);
            this.pbCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin1.TabIndex = 8;
            this.pbCoin1.TabStop = false;
            // 
            // pbEnemy3
            // 
            this.pbEnemy3.Image = global::CarRacingMiniGame.Properties.Resources.road_repair_sign;
            this.pbEnemy3.Location = new System.Drawing.Point(298, 127);
            this.pbEnemy3.Name = "pbEnemy3";
            this.pbEnemy3.Size = new System.Drawing.Size(40, 38);
            this.pbEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy3.TabIndex = 6;
            this.pbEnemy3.TabStop = false;
            // 
            // pbEnemy2
            // 
            this.pbEnemy2.Image = global::CarRacingMiniGame.Properties.Resources.road_repair_sign;
            this.pbEnemy2.Location = new System.Drawing.Point(206, 90);
            this.pbEnemy2.Name = "pbEnemy2";
            this.pbEnemy2.Size = new System.Drawing.Size(38, 35);
            this.pbEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy2.TabIndex = 5;
            this.pbEnemy2.TabStop = false;
            // 
            // pbEnemy1
            // 
            this.pbEnemy1.Image = global::CarRacingMiniGame.Properties.Resources.road_repair_sign;
            this.pbEnemy1.Location = new System.Drawing.Point(33, 127);
            this.pbEnemy1.Name = "pbEnemy1";
            this.pbEnemy1.Size = new System.Drawing.Size(37, 38);
            this.pbEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy1.TabIndex = 4;
            this.pbEnemy1.TabStop = false;
            // 
            // pbMyCar
            // 
            this.pbMyCar.Image = global::CarRacingMiniGame.Properties.Resources.MySecondCar;
            this.pbMyCar.Location = new System.Drawing.Point(112, 331);
            this.pbMyCar.Name = "pbMyCar";
            this.pbMyCar.Size = new System.Drawing.Size(46, 75);
            this.pbMyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyCar.TabIndex = 3;
            this.pbMyCar.TabStop = false;
            // 
            // pbRightLine
            // 
            this.pbRightLine.BackColor = System.Drawing.Color.White;
            this.pbRightLine.Location = new System.Drawing.Point(373, -1);
            this.pbRightLine.Name = "pbRightLine";
            this.pbRightLine.Size = new System.Drawing.Size(10, 464);
            this.pbRightLine.TabIndex = 2;
            this.pbRightLine.TabStop = false;
            // 
            // pbLeftLine
            // 
            this.pbLeftLine.BackColor = System.Drawing.Color.White;
            this.pbLeftLine.Location = new System.Drawing.Point(-2, -1);
            this.pbLeftLine.Name = "pbLeftLine";
            this.pbLeftLine.Size = new System.Drawing.Size(10, 464);
            this.pbLeftLine.TabIndex = 1;
            this.pbLeftLine.TabStop = false;
            // 
            // pbLine3
            // 
            this.pbLine3.BackColor = System.Drawing.Color.White;
            this.pbLine3.Location = new System.Drawing.Point(180, 159);
            this.pbLine3.Name = "pbLine3";
            this.pbLine3.Size = new System.Drawing.Size(10, 74);
            this.pbLine3.TabIndex = 0;
            this.pbLine3.TabStop = false;
            // 
            // pbLine6
            // 
            this.pbLine6.BackColor = System.Drawing.Color.White;
            this.pbLine6.Location = new System.Drawing.Point(180, 399);
            this.pbLine6.Name = "pbLine6";
            this.pbLine6.Size = new System.Drawing.Size(10, 82);
            this.pbLine6.TabIndex = 0;
            this.pbLine6.TabStop = false;
            // 
            // pbLine5
            // 
            this.pbLine5.BackColor = System.Drawing.Color.White;
            this.pbLine5.Location = new System.Drawing.Point(180, 319);
            this.pbLine5.Name = "pbLine5";
            this.pbLine5.Size = new System.Drawing.Size(10, 74);
            this.pbLine5.TabIndex = 0;
            this.pbLine5.TabStop = false;
            // 
            // pbLine4
            // 
            this.pbLine4.BackColor = System.Drawing.Color.White;
            this.pbLine4.Location = new System.Drawing.Point(180, 239);
            this.pbLine4.Name = "pbLine4";
            this.pbLine4.Size = new System.Drawing.Size(10, 74);
            this.pbLine4.TabIndex = 0;
            this.pbLine4.TabStop = false;
            // 
            // pbLine1
            // 
            this.pbLine1.BackColor = System.Drawing.Color.White;
            this.pbLine1.Location = new System.Drawing.Point(180, -18);
            this.pbLine1.Name = "pbLine1";
            this.pbLine1.Size = new System.Drawing.Size(10, 91);
            this.pbLine1.TabIndex = 0;
            this.pbLine1.TabStop = false;
            // 
            // pbLine2
            // 
            this.pbLine2.BackColor = System.Drawing.Color.White;
            this.pbLine2.Location = new System.Drawing.Point(180, 79);
            this.pbLine2.Name = "pbLine2";
            this.pbLine2.Size = new System.Drawing.Size(10, 74);
            this.pbLine2.TabIndex = 0;
            this.pbLine2.TabStop = false;
            // 
            // lbStartMovement
            // 
            this.lbStartMovement.AutoSize = true;
            this.lbStartMovement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStartMovement.Location = new System.Drawing.Point(65, 297);
            this.lbStartMovement.Name = "lbStartMovement";
            this.lbStartMovement.Size = new System.Drawing.Size(245, 19);
            this.lbStartMovement.TabIndex = 13;
            this.lbStartMovement.Text = "To start the game press UP key";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lbStartMovement);
            this.Controls.Add(this.lbCoins);
            this.Controls.Add(this.pbCoin4);
            this.Controls.Add(this.pbCoin2);
            this.Controls.Add(this.pbCoin3);
            this.Controls.Add(this.pbCoin1);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.pbEnemy3);
            this.Controls.Add(this.pbEnemy2);
            this.Controls.Add(this.pbEnemy1);
            this.Controls.Add(this.pbMyCar);
            this.Controls.Add(this.pbRightLine);
            this.Controls.Add(this.pbLeftLine);
            this.Controls.Add(this.pbLine3);
            this.Controls.Add(this.pbLine6);
            this.Controls.Add(this.pbLine5);
            this.Controls.Add(this.pbLine4);
            this.Controls.Add(this.pbLine1);
            this.Controls.Add(this.pbLine2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Race Mini Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLine2;
        private System.Windows.Forms.PictureBox pbLine1;
        private System.Windows.Forms.PictureBox pbLine4;
        private System.Windows.Forms.PictureBox pbLine3;
        private System.Windows.Forms.PictureBox pbLine5;
        private System.Windows.Forms.PictureBox pbLine6;
        private System.Windows.Forms.PictureBox pbLeftLine;
        private System.Windows.Forms.PictureBox pbRightLine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbMyCar;
        private System.Windows.Forms.PictureBox pbEnemy1;
        private System.Windows.Forms.PictureBox pbEnemy2;
        private System.Windows.Forms.PictureBox pbEnemy3;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.PictureBox pbCoin1;
        private System.Windows.Forms.PictureBox pbCoin3;
        private System.Windows.Forms.PictureBox pbCoin2;
        private System.Windows.Forms.PictureBox pbCoin4;
        private System.Windows.Forms.Label lbCoins;
        private System.Windows.Forms.Label lbStartMovement;
    }
}

