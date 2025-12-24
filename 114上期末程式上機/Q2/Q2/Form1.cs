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

namespace Q2
{
    public partial class Form1 : Form
    {
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal TAX_RATE = 0.06m;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private decimal OilLubeCharges()
        {
            decimal total = 0;
            if (oilChangeCheckBox.Checked) total += 780m;
            if (lubeJobCheckBox.Checked) total += 540m;
            return total;
        }

        private decimal FlushCharges()
        {
            decimal total = 0;
            if (radiatorFlushCheckBox.Checked) total += 900m;
            if (transmissionFlushCheckBox.Checked) total += 2400m;
            return total;
        }

        private decimal MiscCharges()
        {
            decimal total = 0;
            if (inspectionCheckBox.Checked) total += 450m;
            if (mufflerCheckBox.Checked) total += 3000m;
            if (tireRotationCheckBox.Checked) total += 600m;
            return total;
        }

        private decimal OtherCharges()
        {
            decimal hours;
            // 嘗試解析工時，若無效或空白則視為 0
            if (decimal.TryParse(hoursTextBox.Text, out hours) && hours > 0)
            {
                return hours * LABOR_RATE_PER_HOUR;
            }
            return 0;
        }

        private decimal TaxCharges(decimal partsAmount)
        {
            return partsAmount * TAX_RATE;
        }

        // --- 資料清除方法 ---

        private void ClearOilLube()
        {
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }

        private void ClearFlushes()
        {
            radiatorFlushCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;
        }

        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            mufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
        }

        private void ClearOther()
        {
            partsTextBox.Clear();
            hoursTextBox.Clear();
        }

        private void ClearFees()
        {
            label3.Text = ""; // 服務與工資
            label4.Text = ""; // 零件
            label5.Text = ""; // 稅金
            label6.Text = ""; // 總費用
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal parts;
                if (!decimal.TryParse(partsTextBox.Text, out parts)) parts = 0;

                if (parts < 0) throw new Exception("零件費用不可為負數");

                decimal serviceAndLabor = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges();
                decimal tax = TaxCharges(parts);
                decimal total = serviceAndLabor + parts + tax;

                // 顯示結果
                label3.Text = serviceAndLabor.ToString("C");
                label4.Text = parts.ToString("C");
                label5.Text = tax.ToString("C");
                label6.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("計算發生錯誤: " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

