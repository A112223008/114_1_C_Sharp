using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprehensive_Practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMax_Click(object sender, EventArgs e)
        {
            string surname = txtLastName.Text;
            string givenName = txtFirstName.Text;
            int quzi1, quiz2, quiz3;
            if(int.TryParse(txtQuiz1.Text, out quzi1) &&
                int.TryParse(txtQuiz2.Text, out quiz2) &&
                int.TryParse(txtQuiz3.Text, out quiz3))
            {
                showResult(surname, givenName, quzi1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("成績一律輸入整數", "資料錯誤");
                clearTextBoxes();
            }
        }
        private void showResult(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int highestScore;
            if(quiz1 >= quiz2 && quiz1 >= quiz3)
            {
                highestScore = quiz1;
            }
            else if (quiz2 >= quiz1 && quiz2 >= quiz3)
            {
                highestScore = quiz2;
            }
            else
            {
                highestScore = quiz3;
            }
            lblResult.Text = string.Format("{0}{1}的最高成績是{2}分", surname, givenName, highestScore);
        }

        private void clearTextBoxes()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtQuiz1.Clear();
            txtQuiz2.Clear();
            txtQuiz3.Clear();
            txtLastName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
