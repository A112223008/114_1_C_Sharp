namespace Card
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
            this.lblCardName = new System.Windows.Forms.Label();
            this.picCard5 = new System.Windows.Forms.PictureBox();
            this.picCard4 = new System.Windows.Forms.PictureBox();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.picCard1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("新細明體", 22F);
            this.lblCardName.Location = new System.Drawing.Point(663, 151);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(0, 44);
            this.lblCardName.TabIndex = 5;
            // 
            // picCard5
            // 
            this.picCard5.Image = global::Card.Properties.Resources.A;
            this.picCard5.Location = new System.Drawing.Point(1185, 331);
            this.picCard5.Name = "picCard5";
            this.picCard5.Size = new System.Drawing.Size(247, 344);
            this.picCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard5.TabIndex = 4;
            this.picCard5.TabStop = false;
            this.picCard5.Click += new System.EventHandler(this.Card_Click);
            // 
            // picCard4
            // 
            this.picCard4.Image = global::Card.Properties.Resources.k;
            this.picCard4.Location = new System.Drawing.Point(899, 331);
            this.picCard4.Name = "picCard4";
            this.picCard4.Size = new System.Drawing.Size(247, 344);
            this.picCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard4.TabIndex = 3;
            this.picCard4.TabStop = false;
            this.picCard4.Click += new System.EventHandler(this.Card_Click);
            // 
            // picCard3
            // 
            this.picCard3.Image = global::Card.Properties.Resources._7;
            this.picCard3.Location = new System.Drawing.Point(628, 331);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(247, 344);
            this.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard3.TabIndex = 2;
            this.picCard3.TabStop = false;
            this.picCard3.Click += new System.EventHandler(this.Card_Click);
            // 
            // picCard2
            // 
            this.picCard2.Image = global::Card.Properties.Resources._101;
            this.picCard2.Location = new System.Drawing.Point(347, 331);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(247, 344);
            this.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard2.TabIndex = 1;
            this.picCard2.TabStop = false;
            this.picCard2.Click += new System.EventHandler(this.Card_Click);
            // 
            // picCard1
            // 
            this.picCard1.Image = global::Card.Properties.Resources._21;
            this.picCard1.Location = new System.Drawing.Point(61, 331);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(247, 344);
            this.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard1.TabIndex = 0;
            this.picCard1.TabStop = false;
            this.picCard1.Click += new System.EventHandler(this.Card_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 862);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.picCard5);
            this.Controls.Add(this.picCard4);
            this.Controls.Add(this.picCard3);
            this.Controls.Add(this.picCard2);
            this.Controls.Add(this.picCard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard1;
        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.PictureBox picCard3;
        private System.Windows.Forms.PictureBox picCard4;
        private System.Windows.Forms.PictureBox picCard5;
        private System.Windows.Forms.Label lblCardName;
    }
}

