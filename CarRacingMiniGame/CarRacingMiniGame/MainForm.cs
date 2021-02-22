using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingMiniGame
{
    public partial class MainForm : Form
    {
        
        int collecedCoins = 0;
        Random enemyLocation = new Random();
        Random coinLocation = new Random();
        int x;
         int  gameSpeed = 0;
        
        public MainForm()
        {
            InitializeComponent();
            lbGameOver.Visible = false;
            pbCoin1.BackColor = Color.Transparent;
            pbCoin2.BackColor = Color.Transparent;
            pbCoin3.BackColor = Color.Transparent;
            pbCoin4.BackColor = Color.Transparent;
            pbEnemy1.BackColor = Color.Transparent;
            pbEnemy2.BackColor = Color.Transparent;
            pbEnemy3.BackColor = Color.Transparent;

        }

        //timer for movements
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            MoveLine(gameSpeed);
            GameOver();
        }

        //move the line
        void MoveLine(int speed)
        {
            pictueBoxLines(pbLine1, speed);
            pictueBoxLines(pbLine2, speed);
            pictueBoxLines(pbLine3, speed);
            pictueBoxLines(pbLine4, speed);
            pictueBoxLines(pbLine5, speed);
            pictueBoxLines(pbLine6, speed);
            Enemy(pbEnemy1, speed);
            Enemy(pbEnemy2, speed);
            Enemy(pbEnemy3, speed);
            Coin(pbCoin1, speed);
            Coin(pbCoin2, speed);
            Coin(pbCoin3, speed);
            Coin(pbCoin4, speed);
            CollecedCoins();
        }

        void Enemy(PictureBox pb,int speed)
        {
            if (pb.Top >= 500)
            {
                x = enemyLocation.Next(15, 350);
                pb.Location = new Point(x, 0);
                pb.BringToFront();
             }
            else { pb.Top += speed; }
        }

       void Coin(PictureBox pb,int speed)
        {
            if (pb.Top >= 500)
            {
                x = enemyLocation.Next(15, 250);
                pb.Location = new Point(x, 0);
                pb.BringToFront();
            }
            else { pb.Top += speed; }
        }


        void GameOver()
        {
            if (pbMyCar.Bounds.IntersectsWith(pbEnemy1.Bounds))
            {
                timer1.Enabled = false;
                lbGameOver.Visible = true;
                lbGameOver.BringToFront();
                DialogResult result = new DialogResult();
               result= MessageBox.Show("Do you want to play again?", "GAME OVER !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                    timer1.Enabled = true;

                }
                else { Application.Exit(); }
            }
            if (pbMyCar.Bounds.IntersectsWith(pbEnemy2.Bounds))
            {
                timer1.Enabled = false;
                lbGameOver.Visible = true;
                lbGameOver.BringToFront();
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Do you want to play again?", "GAME OVER !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                    timer1.Enabled = true;

                }
                else { Application.Exit(); }
            }
            if (pbMyCar.Bounds.IntersectsWith(pbEnemy3.Bounds))
            {
                timer1.Enabled = false;
                lbGameOver.Visible = true;
                lbGameOver.BringToFront();
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Do you want to play again?", "GAME OVER !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                    timer1.Enabled = true;

                }
                else { Application.Exit(); }
            }
        }

        //method for line movement
        void pictueBoxLines(PictureBox pb, int speed)
        {
            if (pb.Top >= 500)
            { pb.Top = 0; }
            else { pb.Top += speed; }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
            {
                if (pbMyCar.Left>15)
                pbMyCar.Left += -20;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(pbMyCar.Right<366)
                pbMyCar.Left += 20;
            }
            if (e.KeyCode == Keys.Up)
            {
                lbStartMovement.Visible = false;
                gameSpeed = 3;
                if (gameSpeed < 10)
                { 
                    gameSpeed++;
                }
                
            }
            if (e.KeyCode==Keys.Down)
            {
                if (gameSpeed>3)
                {
                    gameSpeed--;
                }
            }
        }

        void CollecedCoins()
        {
            if (pbMyCar.Bounds.IntersectsWith(pbCoin1.Bounds))
            {
                collecedCoins++;
                lbCoins.Text = "Coins= " + collecedCoins.ToString();
                x = coinLocation.Next(50,300);
                pbCoin1.Location = new Point(x, 0);
            }
            if (pbMyCar.Bounds.IntersectsWith(pbCoin2.Bounds))
            {
                collecedCoins++;
                lbCoins.Text = "Coins= " + collecedCoins.ToString();
                x = coinLocation.Next(50, 300);

                pbCoin2.Location = new Point(x, 0);

            }
            if (pbMyCar.Bounds.IntersectsWith(pbCoin3.Bounds))
            {
                collecedCoins++;
                lbCoins.Text = "Coins= " + collecedCoins.ToString();
                x = coinLocation.Next(50, 300);

                pbCoin3.Location = new Point(x, 0);

            }
            if (pbMyCar.Bounds.IntersectsWith(pbCoin4.Bounds))
            {
                collecedCoins++;
                lbCoins.Text = "Coins= " + collecedCoins.ToString();
                x = coinLocation.Next(50, 300);

                pbCoin4.Location = new Point(x, 0);

            }
        }
    }
}
