using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                showSelectedCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("請先選擇一張牌。");
            }
        }

        private void showSelectedCard(string cardName)
        {
            switch (cardName) { 
                case "黑桃 A":
                    //顯示黑桃A邏輯
                    showAceSpades();
                    break;
                case "紅心 10":
                    //顯示紅心 10邏輯
                    showTenHearts();
                    break;
                case "梅花 K":
                    //顯示梅花 K邏輯
                    showKingClubs();
                    break;
                default:
                    MessageBox.Show("未知的牌。");
                    break;
            }
        }

        private void showAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void showTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        private void showKingClubs() 
        { 
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
