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
    // 主表單類別：負責讀取銷售資料並顯示總銷售額
    public partial class Form1 : Form
    {
        // 建構子：初始化元件
        public Form1()
        { 
            InitializeComponent();
        }

        // 按鈕事件：讀取 Sales.txt 檔案，將每行的銷售數值加入清單並計算總額
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 檔案讀取器
            StreamReader inputFile;
            // 累加總銷售額（使用 decimal 避免浮點誤差）
            decimal totalSales = 0.0m;
            // 用來暫存每一行解析出的銷售數值
            decimal currentSales = 0.0m;
            // 存放讀取的原始字串（每一行）
            string line;

            // 預設最大可儲存的筆數（來源教材使用固定大小陣列）
            decimal[] sales = new decimal[8];
            // 用來記錄實際讀入的元素數量
            int index = 0;

            try
            {
                // 開啟檔案（預期檔名為 Sales.txt，會在執行目錄尋找）
                inputFile = File.OpenText("Sales.txt");
                // 清除顯示銷售數據的 ListBox（確保每次計算前為空）
                salesListBox.Items.Clear();

                // 逐行讀取檔案直到結尾
                while (!inputFile.EndOfStream)
                {
                    // 先讀一行字串，嘗試轉成 decimal
                    if(decimal.TryParse( line = inputFile.ReadLine(), out currentSales))
                    {
                        // 若轉換成功，將原始字串加入 ListBox（供使用者檢視）
                        salesListBox.Items.Add(line);
                        // 將解析後的數值存入陣列，並遞增索引
                        sales[index] = currentSales;
                        index++;
                    }
                    else
                    {
                        // 若遇到無效資料，跳出迴圈並顯示錯誤訊息（包含該行內容以利除錯）
                        MessageBox.Show("檔案中有無效的銷售數據。" + line);
                        break;
                    }
                }
                // 關閉檔案讀取器
                inputFile.Close();

                // 將陣列中有效的數值累加成總銷售額（只累加已讀取的項目數）
                for(int i = 0; i < index; i++)
                {
                    totalSales += sales[i];
                }

                // 將總額顯示在表單上的標籤，使用當地貨幣格式
                totalLabel.Text = totalSales.ToString("C");
            }
            catch (Exception ex)
            {
                // 捕捉任何例外並顯示錯誤訊息，避免程式當掉
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }

        // 按鈕事件：關閉表單（結束程式）
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
