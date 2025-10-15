using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowMuchInsurance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Cost;
            double insurance;

            if (double.TryParse(tbxCost.Text, out Cost))
            {
                insurance = Cost * 0.8;

                lblResult.Text = "最低應投保金額為:" + insurance.ToString("N2") + "元";

            }
            else
            {
                lblResult.Text = "請輸入正確的金額";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
