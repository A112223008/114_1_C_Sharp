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
                inputFile = File.OpenText("C:\\Users\\m303\\Desktop\\114_1_C_Sharp\\114_11_26\\Sales_modified.txt");
                salesListBox.Items.Clear();

                // 讀取並累加銷售數據
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                    if (parts.Length >= 2)
                    {
                        string month = parts[0];
                        string salesValue = parts[1];

                        if (decimal.TryParse(salesValue, out currentSales))
                        {
                            salesListBox.Items.Add(month + " " + currentSales.ToString("C"));
                            totalSales += currentSales;
                        }
                    }
                    else
                    {
                        MessageBox.Show("檔案中有無效的銷售數據。" + line);
                        inputFile.Close();
                        return;
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
    }
}
