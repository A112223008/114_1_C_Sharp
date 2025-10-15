using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 設定按鈕的 Text 為繁體中文            
        }

        // 當使用者點擊「計算薪資」按鈕時執行
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 定義基本工時與加班倍數
            const decimal BASEHOURS = 40m; // 正常工時上限
            const decimal OT_MULTIPLIER = 1.5m; // 加班時薪倍數

            decimal hoursWorked;     // 儲存輸入的工時
            decimal hourlyPayRate;   // 儲存輸入的時薪
            decimal grossPay;       // 儲存計算後的薪資總額


            try
            {
                // 取得使用者輸入的工時與時薪，並轉換為 decimal 型別
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                // 判斷是否有加班
                if (hoursWorked <= BASEHOURS)
                {
                    // 沒有加班，直接計算薪資
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    // 有加班，先計算基本工時薪資，再加上加班薪資
                    grossPay = (BASEHOURS * hourlyPayRate) +
                               ((hoursWorked - BASEHOURS) * hourlyPayRate * OT_MULTIPLIER);
                }
                // 顯示計算結果於標籤上
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                // 若輸入格式錯誤，顯示錯誤訊息
                MessageBox.Show("請輸入正確的數值格式！\n" + ex.Message, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 當使用者點擊「清除」按鈕時執行
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空所有輸入欄位與結果標籤
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標焦點移回工時輸入欄位
            hoursWorkedTextBox.Focus();
        }

        // 當使用者點擊「離開」按鈕時執行
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }
    }
}
