namespace HowMuchInsurance
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("新細明體", 20F);
            this.lblResult.Location = new System.Drawing.Point(88, 176);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(561, 39);
            this.lblResult.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnCalculate.Location = new System.Drawing.Point(515, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(134, 42);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbxCost
            // 
            this.tbxCost.Font = new System.Drawing.Font("新細明體", 20F);
            this.tbxCost.Location = new System.Drawing.Point(175, 91);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(302, 39);
            this.tbxCost.TabIndex = 5;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("新細明體", 20F);
            this.lblCost.Location = new System.Drawing.Point(83, 94);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(66, 27);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "成本";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnExit.Location = new System.Drawing.Point(515, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 42);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "結束";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.lblCost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnExit;
    }
}

