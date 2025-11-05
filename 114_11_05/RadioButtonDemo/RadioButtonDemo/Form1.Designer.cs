namespace RadioButtonDemo
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
            this.coffeeRadioButton = new System.Windows.Forms.RadioButton();
            this.milkteaRadioButton = new System.Windows.Forms.RadioButton();
            this.blackteaRadioButton = new System.Windows.Forms.RadioButton();
            this.juiceRadioButton = new System.Windows.Forms.RadioButton();
            this.jellysanRadioButton = new System.Windows.Forms.RadioButton();
            this.hamsanRadioButton = new System.Windows.Forms.RadioButton();
            this.tunasanRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // coffeeRadioButton
            // 
            this.coffeeRadioButton.AutoSize = true;
            this.coffeeRadioButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.coffeeRadioButton.Location = new System.Drawing.Point(154, 118);
            this.coffeeRadioButton.Name = "coffeeRadioButton";
            this.coffeeRadioButton.Size = new System.Drawing.Size(122, 44);
            this.coffeeRadioButton.TabIndex = 0;
            this.coffeeRadioButton.Text = "咖啡";
            this.coffeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // milkteaRadioButton
            // 
            this.milkteaRadioButton.AutoSize = true;
            this.milkteaRadioButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.milkteaRadioButton.Location = new System.Drawing.Point(154, 189);
            this.milkteaRadioButton.Name = "milkteaRadioButton";
            this.milkteaRadioButton.Size = new System.Drawing.Size(122, 44);
            this.milkteaRadioButton.TabIndex = 1;
            this.milkteaRadioButton.Text = "奶茶";
            this.milkteaRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackteaRadioButton
            // 
            this.blackteaRadioButton.AutoSize = true;
            this.blackteaRadioButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.blackteaRadioButton.Location = new System.Drawing.Point(154, 276);
            this.blackteaRadioButton.Name = "blackteaRadioButton";
            this.blackteaRadioButton.Size = new System.Drawing.Size(122, 44);
            this.blackteaRadioButton.TabIndex = 2;
            this.blackteaRadioButton.Text = "紅茶";
            this.blackteaRadioButton.UseVisualStyleBackColor = true;
            // 
            // juiceRadioButton
            // 
            this.juiceRadioButton.AutoSize = true;
            this.juiceRadioButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.juiceRadioButton.Location = new System.Drawing.Point(154, 366);
            this.juiceRadioButton.Name = "juiceRadioButton";
            this.juiceRadioButton.Size = new System.Drawing.Size(122, 44);
            this.juiceRadioButton.TabIndex = 3;
            this.juiceRadioButton.Text = "果汁";
            this.juiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // jellysanRadioButton
            // 
            this.jellysanRadioButton.AutoSize = true;
            this.jellysanRadioButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.jellysanRadioButton.Location = new System.Drawing.Point(97, 118);
            this.jellysanRadioButton.Name = "jellysanRadioButton";
            this.jellysanRadioButton.Size = new System.Drawing.Size(242, 44);
            this.jellysanRadioButton.TabIndex = 4;
            this.jellysanRadioButton.Text = "果醬三明治";
            this.jellysanRadioButton.UseVisualStyleBackColor = true;
            // 
            // hamsanRadioButton
            // 
            this.hamsanRadioButton.AutoSize = true;
            this.hamsanRadioButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.hamsanRadioButton.Location = new System.Drawing.Point(97, 205);
            this.hamsanRadioButton.Name = "hamsanRadioButton";
            this.hamsanRadioButton.Size = new System.Drawing.Size(242, 44);
            this.hamsanRadioButton.TabIndex = 5;
            this.hamsanRadioButton.Text = "火腿三明治";
            this.hamsanRadioButton.UseVisualStyleBackColor = true;
            // 
            // tunasanRadioButton
            // 
            this.tunasanRadioButton.AutoSize = true;
            this.tunasanRadioButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.tunasanRadioButton.Location = new System.Drawing.Point(97, 308);
            this.tunasanRadioButton.Name = "tunasanRadioButton";
            this.tunasanRadioButton.Size = new System.Drawing.Size(242, 44);
            this.tunasanRadioButton.TabIndex = 6;
            this.tunasanRadioButton.Text = "鮪魚三明治";
            this.tunasanRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coffeeRadioButton);
            this.groupBox1.Controls.Add(this.milkteaRadioButton);
            this.groupBox1.Controls.Add(this.blackteaRadioButton);
            this.groupBox1.Controls.Add(this.juiceRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 20F);
            this.groupBox1.Location = new System.Drawing.Point(197, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 514);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飲料";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jellysanRadioButton);
            this.groupBox2.Controls.Add(this.hamsanRadioButton);
            this.groupBox2.Controls.Add(this.tunasanRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 20F);
            this.groupBox2.Location = new System.Drawing.Point(726, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 514);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "三明治";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.sendButton.Location = new System.Drawing.Point(286, 671);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(246, 71);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "送出訂單";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.exitButton.Location = new System.Drawing.Point(823, 671);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(246, 71);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 847);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton coffeeRadioButton;
        private System.Windows.Forms.RadioButton milkteaRadioButton;
        private System.Windows.Forms.RadioButton blackteaRadioButton;
        private System.Windows.Forms.RadioButton juiceRadioButton;
        private System.Windows.Forms.RadioButton jellysanRadioButton;
        private System.Windows.Forms.RadioButton hamsanRadioButton;
        private System.Windows.Forms.RadioButton tunasanRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button exitButton;
    }
}

