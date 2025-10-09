using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class Form1 : Form
    {
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void picBanana_Click(object sender, EventArgs e)
        {
            total = total + 105;
            tbxTotal.Text = total.ToString();
        }

        private void picApple_Click(object sender, EventArgs e)
        {
            total = total + 80;
            tbxTotal.Text = total.ToString();
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            total = total + 90;
            tbxTotal.Text = total.ToString();
        }

        private void picPear_Click(object sender, EventArgs e)
        {
            total = total + 120;
            tbxTotal.Text = total.ToString();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            total = 0;
            tbxTotal.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
