using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            decimal totalSales = 0.0m;
            decimal currentSales = 0.0m;
            string line;


            try
            {
                // 開啟檔案
                inputFile = File.OpenText("Sales.txt");
                //salesListBox.Items.Clear();

                // 讀取並累加銷售數據
                while (!inputFile.EndOfStream)
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                    {
                        //salesListBox.Items.Add(line);
                        totalSales += currentSales;
                    }
                    else
                    {
                        MessageBox.Show("檔案中有無效的銷售數據。" + line);
                        break;
                    }
                }
                inputFile.Close();
                totalLabel.Text = totalSales.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile;
            string line;
            try
            {
                // 開啟檔案
                inputFile = File.OpenText("Sales.txt");
                salesListBox.Items.Clear();
                // 讀取並顯示銷售數據
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    salesListBox.Items.Add(line);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }
    }
}
