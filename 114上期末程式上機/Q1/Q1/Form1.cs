using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        private int playerWins = 0;
        private int computerWins = 0;

        private int playerChoice;
        private int compChoice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            computerPictureBox.Image = null;
            playerPictureBox.Image = null;
            resultLabel.Text = "請出拳！";
            computerLabel.Text = "電腦勝場: 0";
            playerLabel.Text = "玩家勝場: 0";
        }
        private void getCompChoice()
        {
            Random rand = new Random();
            compChoice = rand.Next(1, 4);
        }
        private void showComputerImage(int choice)
        {
            switch (choice)
            {
                case 1: // 石頭
                    computerPictureBox.Image = Properties.Resources.stone_computer;
                    break;
                case 2: // 布
                    computerPictureBox.Image = Properties.Resources.paper_computer;
                    break;
                case 3: // 剪刀
                    computerPictureBox.Image = Properties.Resources.scissor_computer;
                    break;
            }
        }
        private void showPlayerImage(int choice)
        {
            switch (choice)
            {
                case 1: // 石頭
                    playerPictureBox.Image = Properties.Resources.stone_player;
                    break;
                case 2: // 布
                    playerPictureBox.Image = Properties.Resources.paper_player;
                    break;
                case 3: // 剪刀
                    playerPictureBox.Image = Properties.Resources.scissor_player;
                    break;
            }
        }
        private void showWinner()
        {
            if (playerChoice == compChoice)
            {
                resultLabel.Text = "本回合：平手！";
            }
            else if ((playerChoice == 1 && compChoice == 3) || // 石頭贏剪刀
                     (playerChoice == 2 && compChoice == 1) || // 布贏石頭
                     (playerChoice == 3 && compChoice == 2))   // 剪刀贏布
            {
                resultLabel.Text = "本回合：玩家獲勝！";
                playerWins++; 
            }
            else
            {
                resultLabel.Text = "本回合：電腦獲勝！";
                computerWins++; 
            }

            playerLabel.Text = "玩家勝場: " + playerWins;
            computerLabel.Text = "電腦勝場: " + computerWins;
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = 1;
            executeGame();
        }
        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = 2;
            executeGame();
        }
        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = 3;
            executeGame();
        }
        private void executeGame()
        {
            getCompChoice();
            showPlayerImage(playerChoice);
           
            showComputerImage(compChoice);
            showWinner();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            string stats = string.Format("遊戲結束！\n玩家總勝場：{0}\n電腦總勝場：{1}",
                                          playerWins, computerWins);

            MessageBox.Show(stats, "統計資訊");
            this.Close(); // 關閉程式
        }
    }
}
