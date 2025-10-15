namespace CalorieCounter
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picApple = new System.Windows.Forms.PictureBox();
            this.picPear = new System.Windows.Forms.PictureBox();
            this.picOrange = new System.Windows.Forms.PictureBox();
            this.picBanana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.Font = new System.Drawing.Font("新細明體", 20F);
            this.lblTittle.Location = new System.Drawing.Point(45, 45);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(230, 33);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "水果熱量計算表";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("新細明體", 20F);
            this.lblTotal.Location = new System.Drawing.Point(56, 317);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 33);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "總熱量";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Font = new System.Drawing.Font("新細明體", 20F);
            this.tbxTotal.Location = new System.Drawing.Point(61, 367);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(263, 39);
            this.tbxTotal.TabIndex = 6;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnResult.Location = new System.Drawing.Point(61, 471);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(107, 42);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "清除";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnExit.Location = new System.Drawing.Point(242, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 42);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "結束";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picApple
            // 
            this.picApple.Image = global::CalorieCounter.Properties.Resources.app_e1;
            this.picApple.Location = new System.Drawing.Point(314, 105);
            this.picApple.Name = "picApple";
            this.picApple.Size = new System.Drawing.Size(191, 169);
            this.picApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApple.TabIndex = 9;
            this.picApple.TabStop = false;
            this.picApple.Click += new System.EventHandler(this.picApple_Click);
            // 
            // picPear
            // 
            this.picPear.Image = global::CalorieCounter.Properties.Resources.id13871176_shutterstock_1921806794;
            this.picPear.Location = new System.Drawing.Point(815, 105);
            this.picPear.Name = "picPear";
            this.picPear.Size = new System.Drawing.Size(191, 169);
            this.picPear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPear.TabIndex = 4;
            this.picPear.TabStop = false;
            this.picPear.Click += new System.EventHandler(this.picPear_Click);
            // 
            // picOrange
            // 
            this.picOrange.Image = global::CalorieCounter.Properties.Resources.orange;
            this.picOrange.Location = new System.Drawing.Point(565, 105);
            this.picOrange.Name = "picOrange";
            this.picOrange.Size = new System.Drawing.Size(191, 169);
            this.picOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrange.TabIndex = 3;
            this.picOrange.TabStop = false;
            this.picOrange.Click += new System.EventHandler(this.picOrange_Click);
            // 
            // picBanana
            // 
            this.picBanana.Image = global::CalorieCounter.Properties.Resources.banana;
            this.picBanana.Location = new System.Drawing.Point(61, 105);
            this.picBanana.Name = "picBanana";
            this.picBanana.Size = new System.Drawing.Size(191, 169);
            this.picBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanana.TabIndex = 1;
            this.picBanana.TabStop = false;
            this.picBanana.Click += new System.EventHandler(this.picBanana_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 637);
            this.Controls.Add(this.picApple);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.picPear);
            this.Controls.Add(this.picOrange);
            this.Controls.Add(this.picBanana);
            this.Controls.Add(this.lblTittle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.PictureBox picBanana;
        private System.Windows.Forms.PictureBox picOrange;
        private System.Windows.Forms.PictureBox picPear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picApple;
    }
}

