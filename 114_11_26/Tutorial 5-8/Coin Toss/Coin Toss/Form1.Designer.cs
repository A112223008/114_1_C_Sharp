namespace Coin_Toss
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tailsTitleLabel = new System.Windows.Forms.Label();
            this.headsTitleLabel = new System.Windows.Forms.Label();
            this.tailsCountLabel = new System.Windows.Forms.Label();
            this.headsCountLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = global::Coin_Toss.Properties.Resources.Tails1;
            this.tailsPictureBox.Location = new System.Drawing.Point(361, 84);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(210, 210);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            this.tailsPictureBox.Visible = false;
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = global::Coin_Toss.Properties.Resources.Heads1;
            this.headsPictureBox.Location = new System.Drawing.Point(361, 84);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(210, 210);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            // 
            // tossButton
            // 
            this.tossButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tossButton.Location = new System.Drawing.Point(148, 565);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(172, 45);
            this.tossButton.TabIndex = 2;
            this.tossButton.Text = "擲硬幣";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(567, 565);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tailsTitleLabel
            // 
            this.tailsTitleLabel.AutoSize = true;
            this.tailsTitleLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tailsTitleLabel.Location = new System.Drawing.Point(156, 394);
            this.tailsTitleLabel.Name = "tailsTitleLabel";
            this.tailsTitleLabel.Size = new System.Drawing.Size(164, 45);
            this.tailsTitleLabel.TabIndex = 4;
            this.tailsTitleLabel.Text = "反面次數";
            // 
            // headsTitleLabel
            // 
            this.headsTitleLabel.AutoSize = true;
            this.headsTitleLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.headsTitleLabel.Location = new System.Drawing.Point(540, 394);
            this.headsTitleLabel.Name = "headsTitleLabel";
            this.headsTitleLabel.Size = new System.Drawing.Size(164, 45);
            this.headsTitleLabel.TabIndex = 6;
            this.headsTitleLabel.Text = "正面次數";
            // 
            // tailsCountLabel
            // 
            this.tailsCountLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tailsCountLabel.Location = new System.Drawing.Point(156, 472);
            this.tailsCountLabel.Name = "tailsCountLabel";
            this.tailsCountLabel.Size = new System.Drawing.Size(192, 48);
            this.tailsCountLabel.TabIndex = 5;
            this.tailsCountLabel.Text = "0";
            this.tailsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headsCountLabel
            // 
            this.headsCountLabel.Location = new System.Drawing.Point(540, 472);
            this.headsCountLabel.Name = "headsCountLabel";
            this.headsCountLabel.Size = new System.Drawing.Size(164, 48);
            this.headsCountLabel.TabIndex = 7;
            this.headsCountLabel.Text = "0";
            this.headsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 732);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.headsCountLabel);
            this.Controls.Add(this.headsTitleLabel);
            this.Controls.Add(this.tailsCountLabel);
            this.Controls.Add(this.tailsTitleLabel);
            this.Controls.Add(this.headsPictureBox);
            this.Controls.Add(this.tailsPictureBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "擲硬幣範例";
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip1;
        // 新增的 Label 欄位，分別為標題與數值顯示
        private System.Windows.Forms.Label tailsTitleLabel;
        private System.Windows.Forms.Label headsTitleLabel;
        private System.Windows.Forms.Label tailsCountLabel;
        private System.Windows.Forms.Label headsCountLabel;
    }
}
