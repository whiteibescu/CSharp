namespace _2020_08_Assignment
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
            this.btnFrozenRice = new System.Windows.Forms.Button();
            this.btnTofu = new System.Windows.Forms.Button();
            this.btnKimchi = new System.Windows.Forms.Button();
            this.btnTuna = new System.Windows.Forms.Button();
            this.btnEgg = new System.Windows.Forms.Button();
            this.btnChoiceList = new System.Windows.Forms.Button();
            this.btnCombine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOnion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CombinedList = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFrozenRice
            // 
            this.btnFrozenRice.Location = new System.Drawing.Point(101, 121);
            this.btnFrozenRice.Name = "btnFrozenRice";
            this.btnFrozenRice.Size = new System.Drawing.Size(114, 58);
            this.btnFrozenRice.TabIndex = 0;
            this.btnFrozenRice.Text = "냉동밥";
            this.btnFrozenRice.UseVisualStyleBackColor = true;
            // 
            // btnTofu
            // 
            this.btnTofu.Location = new System.Drawing.Point(172, 321);
            this.btnTofu.Name = "btnTofu";
            this.btnTofu.Size = new System.Drawing.Size(112, 52);
            this.btnTofu.TabIndex = 1;
            this.btnTofu.Text = "두부";
            this.btnTofu.UseVisualStyleBackColor = true;
            // 
            // btnKimchi
            // 
            this.btnKimchi.Location = new System.Drawing.Point(172, 219);
            this.btnKimchi.Name = "btnKimchi";
            this.btnKimchi.Size = new System.Drawing.Size(112, 65);
            this.btnKimchi.TabIndex = 2;
            this.btnKimchi.Text = "김치";
            this.btnKimchi.UseVisualStyleBackColor = true;
            // 
            // btnTuna
            // 
            this.btnTuna.Location = new System.Drawing.Point(17, 219);
            this.btnTuna.Name = "btnTuna";
            this.btnTuna.Size = new System.Drawing.Size(117, 65);
            this.btnTuna.TabIndex = 3;
            this.btnTuna.Text = "참치";
            this.btnTuna.UseVisualStyleBackColor = true;
            // 
            // btnEgg
            // 
            this.btnEgg.Location = new System.Drawing.Point(17, 321);
            this.btnEgg.Name = "btnEgg";
            this.btnEgg.Size = new System.Drawing.Size(113, 52);
            this.btnEgg.TabIndex = 4;
            this.btnEgg.Text = "계란";
            this.btnEgg.UseVisualStyleBackColor = true;
            // 
            // btnChoiceList
            // 
            this.btnChoiceList.Location = new System.Drawing.Point(29, 37);
            this.btnChoiceList.Name = "btnChoiceList";
            this.btnChoiceList.Size = new System.Drawing.Size(251, 53);
            this.btnChoiceList.TabIndex = 5;
            this.btnChoiceList.Text = "선택목록";
            this.btnChoiceList.UseVisualStyleBackColor = true;
            // 
            // btnCombine
            // 
            this.btnCombine.Location = new System.Drawing.Point(0, 623);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(300, 79);
            this.btnCombine.TabIndex = 6;
            this.btnCombine.Text = "조합";
            this.btnCombine.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOnion);
            this.groupBox1.Controls.Add(this.btnEgg);
            this.groupBox1.Controls.Add(this.btnTuna);
            this.groupBox1.Controls.Add(this.btnKimchi);
            this.groupBox1.Controls.Add(this.btnTofu);
            this.groupBox1.Controls.Add(this.btnFrozenRice);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 713);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnOnion
            // 
            this.btnOnion.Location = new System.Drawing.Point(128, 409);
            this.btnOnion.Name = "btnOnion";
            this.btnOnion.Size = new System.Drawing.Size(109, 48);
            this.btnOnion.TabIndex = 7;
            this.btnOnion.Text = "양파";
            this.btnOnion.UseVisualStyleBackColor = true;
            this.btnOnion.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(7, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 666);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CombinedList);
            this.groupBox2.Controls.Add(this.btnCombine);
            this.groupBox2.Controls.Add(this.btnChoiceList);
            this.groupBox2.Location = new System.Drawing.Point(329, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 708);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // CombinedList
            // 
            this.CombinedList.Location = new System.Drawing.Point(3, 98);
            this.CombinedList.Multiline = true;
            this.CombinedList.Name = "CombinedList";
            this.CombinedList.Size = new System.Drawing.Size(296, 525);
            this.CombinedList.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 725);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrozenRice;
        private System.Windows.Forms.Button btnTofu;
        private System.Windows.Forms.Button btnKimchi;
        private System.Windows.Forms.Button btnTuna;
        private System.Windows.Forms.Button btnEgg;
        private System.Windows.Forms.Button btnChoiceList;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOnion;
        private System.Windows.Forms.TextBox CombinedList;
    }
}

