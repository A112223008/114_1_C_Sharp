using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           const decimal INTEREST_RATE = 0.005m; // 每月利率（0.5%）

            decimal startingBalance;          // 起始餘額（使用 decimal 儲存金錢值以避免浮點誤差）
            int months;                       // 月數（要計算的月份總數）
            int count = 1 ;                      // 迴圈計數器，從第 1 個月開始


            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months > 0)
                {
                    while (count <= months)
                    {
                        // 計算每個月的結餘，將利息加入起始餘額
                        startingBalance  *= (1 + INTEREST_RATE);

                        // 將每個月的結餘加入 detailListBox
                        detailListBox.Items.Add($"第 " + count + "個月結餘:" + startingBalance.ToString("c2"));
                        count++;
                    }
                    // 顯示最終的結餘，格式化為貨幣形式
                    endingBalanceLabel.Text = startingBalance.ToString("C2");
                }
                else
                {
                    // 提示使用者輸入有效的月數
                    MessageBox.Show("請輸入正確有效的月份(正整數)", "輸入錯誤");
                }
            }
            else
            {
                // 提示使用者輸入有效的起始餘額
                MessageBox.Show("請輸入有效的起始餘額", "輸入錯誤");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBox、顯示結餘的 Label，以及 ListBox 的項目
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 重設輸入焦點至起始餘額的輸入欄位
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單並結束應用程式
            this.Close();
        }

        private void detailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // detailListBox 的選取變更事件暫時不需處理
        }
    }
}
