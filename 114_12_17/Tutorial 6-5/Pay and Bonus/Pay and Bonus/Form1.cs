using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // 提撥比率的常數欄位（5%）
        private const decimal CONTRIB_RATE = 0.05m;

        // 建構子：初始化元件
        public Form1()
        {
            InitializeComponent();
        }

        // InputIsValid 方法會將使用者輸入轉換並儲存在參數（以參考傳遞）中。
        // 如果轉換成功，方法回傳 true；否則回傳 false。

        // 計算按鈕的事件處理函式：取得輸入、驗證後計算退休提撥並顯示結果
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告變數用來儲存輸入與計算結果
            decimal grossPay = 0.0m;
            decimal bonus = 0.0m;
            decimal contribution;

            // 驗證輸入是否正確，若正確則計算並顯示提撥金額
            if(InputIsValid(ref grossPay, ref bonus))
            {
                // 計算提撥金額（總薪資 * 提撥比率）
                contribution = CONTRIB_RATE * (grossPay + bonus);
                // 將結果格式化為貨幣並顯示在 contributionLabel 上
                contributionLabel.Text = contribution.ToString("C");

            }
            else
            {
                // 驗證失敗：顯示錯誤訊息提醒使用者輸入數字
                MessageBox.Show("請輸入有效的數值。", "輸入錯誤");
            }
        }

        // 驗證使用者輸入方法：嘗試將文字框內容轉為 decimal
        // out 參數會回報轉換後的值
        private bool InputIsValid(ref decimal grossPay, ref decimal bonus)
        {
            bool inputIsValid = false;
            // 嘗試將使用者輸入轉換為 decimal。
            // 注意：這裡使用 TryParse 來避免拋出例外
            if (!decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {
                if (!decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    // 兩個欄位都成功轉換才視為有效
                    inputIsValid = true;
                }
                else
                {
                    // 任何一個欄位轉換失敗，顯示錯誤通知
                    MessageBox.Show("請輸入有效的數值。", "輸入錯誤");
                    // inputIsValid 保持為 false
                }
            }
            else
            {
                // 若毛薪資欄位轉換失敗，也顯示錯誤並將 bonus 設為 0（保險措施）
                MessageBox.Show("請輸入有效的數值。", "輸入錯誤");
                bonus = 0;
                // inputIsValid 保持為 false
            }
            return inputIsValid;
        }

        // 離開按鈕的事件處理：關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
