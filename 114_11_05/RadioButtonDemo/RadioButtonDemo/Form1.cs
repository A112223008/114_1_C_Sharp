using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            String message = "點餐內容: ";
            String drink;
            String sandwich;

            if(coffeeRadioButton.Checked )
            {
                drink = "咖啡 ";
            }
            else if( milkteaRadioButton.Checked )
            {
                drink = "奶茶 ";
            }
            else if(blackteaRadioButton.Checked)
            {
                drink = "紅茶 ";
            }
            else if(juiceRadioButton.Checked)
            {
                drink = "果汁 ";
            }
            else
            {
                drink = " ";
            }            

            if (jellysanRadioButton.Checked)
            {
                sandwich = "果醬三明治 ";
            }
            else if (hamsanRadioButton.Checked)
            {
                sandwich = "火腿三明治 ";
            }
            else if (tunasanRadioButton.Checked)
            {
                sandwich = "鮪魚三明治 ";
            }
            else
            {
                sandwich = " ";
            }

            message = drink + sandwich;
            MessageBox.Show(message, "您的點餐內容 ");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
