using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Zachary Gardner
CST-117
September 12, 2020
This is my own work.

 */
namespace Project4
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        string[,] gameBoard = new string[3, 3];

        Random rand1 = new Random();
        string player1 = "X";
        string player2 = "O";
        int randNum1 = 0;
        int randNum2 = 0;
        int randNum3 = 0;
        int randNum4 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            PlayerOneMove();
            DisplayGameBoard();
            Task.Delay(3000);
            PlayerTwoMove();
            DisplayGameBoard();
            Task.Delay(3000);
            PlayerOneMove();
            DisplayGameBoard();
            PlayerTwoMove();
            DisplayGameBoard();
            PlayerOneMove();
            DisplayGameBoard();
            PlayerTwoMove();
            DisplayGameBoard();
            PlayerOneMove();
            DisplayGameBoard();
            PlayerTwoMove();
            DisplayGameBoard();
            PlayerOneMove();
            DisplayGameBoard();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //exit the game
            this.Close();
        }
        //Display victor method checks the board for who the winner is, and prints out the winning team
        public void PlayerOneMove()
        {
            randNum1 = rand1.Next(0, 3);
            randNum2 = rand1.Next(0, 3);
            if (gameBoard[randNum1, randNum2] == null)
            {
                gameBoard[randNum1, randNum2] = player1;
                Console.WriteLine("player two turn " + randNum1 + randNum2);
                return;
            }
            else
            {
                PlayerOneMove();
            }
        }
        public void PlayerTwoMove()
        {
            
            randNum3 = rand1.Next(0, 3);
            randNum4 = rand1.Next(0, 3);
            if (gameBoard[randNum3, randNum4] == null)
            {
                gameBoard[randNum3, randNum4] = player2;
                Console.WriteLine("player two turn " + randNum3 + randNum4);
                return;
            } else
            {
                PlayerTwoMove();
            }
        }
        public void DisplayGameBoard()
        {
            label1.Text = gameBoard[0, 0];
            label2.Text = gameBoard[0, 1];
            label3.Text = gameBoard[0, 2];
            label4.Text = gameBoard[1, 0];
            label5.Text = gameBoard[1, 1];
            label6.Text = gameBoard[1, 2];
            label7.Text = gameBoard[2, 0];
            label8.Text = gameBoard[2, 1];
            label9.Text = gameBoard[2, 2];

        } 
        public void CheckForWinner()
        {

        }
    }
}
