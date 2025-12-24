using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        private const int SIZE = 5;
        private int[] playerNumbers = new int[SIZE];
        private int[] winningNumbers = new int[SIZE];
        private bool isFileLoaded = false; // 紀錄開獎檔案是否已讀取

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;

            // 2. 初始狀態：隱藏右下角所有結果文字
            lblTitle.Text = ""; // 標題 Label
            lblCount.Text = "";  // 中獎數量 Label
            lblPrize.Text = ""; // 獎項結果 Label
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int count = 0;

            // 產生不重複亂數
            while (count < SIZE)
            {
                int nextNum = rand.Next(1, 50);
                bool duplicate = false;
                for (int i = 0; i < count; i++)
                {
                    if (playerNumbers[i] == nextNum) { duplicate = true; break; }
                }
                if (!duplicate)
                {
                    playerNumbers[count] = nextNum;
                    count++;
                }
            }
            label1.Text = playerNumbers[0].ToString();
            label2.Text = playerNumbers[1].ToString();
            label3.Text = playerNumbers[2].ToString();
            label4.Text = playerNumbers[3].ToString();
            label5.Text = playerNumbers[4].ToString();

            // 執行比對並顯示結果
            PerformComparison();
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader inputFile;
                int index = 0;
                lbxResults.Items.Clear();
                lbxResults.Items.Add("本期開獎號碼：");

                try
                {
                    inputFile = File.OpenText(openFileDialog1.FileName); //
                    while (!inputFile.EndOfStream && index < SIZE)
                    {
                        string rawLine = inputFile.ReadLine();

                        
                        string numericPart = "";
                        if (rawLine.Contains(":"))
                        {
                            int colonIndex = rawLine.IndexOf(":");
                            numericPart = rawLine.Substring(colonIndex + 1).Trim();
                        }
                        else
                        {
                            numericPart = rawLine.Trim();
                        }

                        int num;
                        if (int.TryParse(numericPart, out num) && num >= 1 && num <= 49)
                        {
                            winningNumbers[index] = num;
                            lbxResults.Items.Add(rawLine); // 顯示原始中文字內容
                            index++;
                        }
                    }
                    inputFile.Close();

                    if (index == SIZE)
                    {
                        // 讀取成功後，才啟用產生號碼按鈕
                        btnGenerate.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取失敗: " + ex.Message);
                }
            }
        }
        private void PerformComparison()
        {
            int matchCount = 0;
            // 雙層迴圈比對
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (playerNumbers[i] == winningNumbers[j]) { matchCount++; }
                }
            }

            // --- 設定文字內容並強制指定顏色為紅色 ---
            lblTitle.ForeColor = Color.Red; // 標題設為紅色
            lblTitle.Text = "比對結果：";

            lblCount.ForeColor = Color.Red;  // 命中數設為紅色
            lblCount.Text = "中" + matchCount + "個號碼";

            lblPrize.ForeColor = Color.Red; // 獎項結果設為紅色

            string prizeText = "";
            switch (matchCount)
            {
                case 5: prizeText = "🥳 五個獎 "; break;
                case 4: prizeText = "😃 四個獎 "; break;
                case 3: prizeText = "😊 三個獎 "; break;
                case 2: prizeText = "😐 兩個獎 "; break;
                case 1: prizeText = "🙂 一個獎 "; break;
                default: prizeText = "😭 沒中獎"; break;
            }
            lblPrize.Text = prizeText;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //
        }
    }
}
