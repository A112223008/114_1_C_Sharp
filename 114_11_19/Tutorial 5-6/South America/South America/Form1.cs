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

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            string countryName;
            try
            {
                // 開啟包含國家名稱的檔案。
                inputFile = File.OpenText(@"C:\Users\tinaw\OneDrive\桌面\114_1_C_Sharp\114_11_19\Countries_Chinese.txt");
                countriesListBox.Items.Clear();

                // 讀取檔案中的國家名稱，直到檔案結尾。
                while (!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }
                // 關閉檔案。
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。
                MessageBox.Show("發生錯誤:  " + ex.Message);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
