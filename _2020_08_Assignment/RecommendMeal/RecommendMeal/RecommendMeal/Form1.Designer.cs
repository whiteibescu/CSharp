namespace RecommendMeal
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModalForm = new System.Windows.Forms.Button();
            this.btnLeftMove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRice = new System.Windows.Forms.Button();
            this.btnTofu = new System.Windows.Forms.Button();
            this.btnEggs = new System.Windows.Forms.Button();
            this.btnKimchi = new System.Windows.Forms.Button();
            this.btnOnion = new System.Windows.Forms.Button();
            this.btnTuna = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(578, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 420);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "냉장고";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(651, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "선택 목록";
            // 
            // btnModalForm
            // 
            this.btnModalForm.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModalForm.Location = new System.Drawing.Point(620, 508);
            this.btnModalForm.Name = "btnModalForm";
            this.btnModalForm.Size = new System.Drawing.Size(214, 43);
            this.btnModalForm.TabIndex = 3;
            this.btnModalForm.Text = "요리 시작!";
            this.btnModalForm.UseVisualStyleBackColor = true;
            this.btnModalForm.Click += new System.EventHandler(this.btnModalForm_Click);
            // 
            // btnLeftMove
            // 
            this.btnLeftMove.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLeftMove.Location = new System.Drawing.Point(464, 313);
            this.btnLeftMove.Name = "btnLeftMove";
            this.btnLeftMove.Size = new System.Drawing.Size(94, 35);
            this.btnLeftMove.TabIndex = 5;
            this.btnLeftMove.Tag = "Move";
            this.btnLeftMove.Text = "<<";
            this.btnLeftMove.UseVisualStyleBackColor = true;
            this.btnLeftMove.Click += new System.EventHandler(this.btnLeftMove_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 494);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRice
            // 
            this.btnRice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRice.BackgroundImage")));
            this.btnRice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRice.Location = new System.Drawing.Point(87, 82);
            this.btnRice.Name = "btnRice";
            this.btnRice.Size = new System.Drawing.Size(98, 86);
            this.btnRice.TabIndex = 4;
            this.btnRice.Tag = "food";
            this.btnRice.Text = "밥";
            this.btnRice.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRice.UseVisualStyleBackColor = true;
            this.btnRice.Click += new System.EventHandler(this.btnRice_Click);
            // 
            // btnTofu
            // 
            this.btnTofu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTofu.BackgroundImage")));
            this.btnTofu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTofu.Location = new System.Drawing.Point(83, 197);
            this.btnTofu.Name = "btnTofu";
            this.btnTofu.Size = new System.Drawing.Size(102, 82);
            this.btnTofu.TabIndex = 4;
            this.btnTofu.Tag = "food";
            this.btnTofu.Text = "두부";
            this.btnTofu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTofu.UseVisualStyleBackColor = true;
            this.btnTofu.Click += new System.EventHandler(this.btnTofu_Click);
            // 
            // btnEggs
            // 
            this.btnEggs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEggs.BackgroundImage")));
            this.btnEggs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEggs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEggs.Location = new System.Drawing.Point(225, 83);
            this.btnEggs.Name = "btnEggs";
            this.btnEggs.Size = new System.Drawing.Size(95, 85);
            this.btnEggs.TabIndex = 4;
            this.btnEggs.Tag = "food";
            this.btnEggs.Text = "계란";
            this.btnEggs.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEggs.UseVisualStyleBackColor = true;
            this.btnEggs.Click += new System.EventHandler(this.btnEggs_Click);
            // 
            // btnKimchi
            // 
            this.btnKimchi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKimchi.BackgroundImage")));
            this.btnKimchi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKimchi.Location = new System.Drawing.Point(83, 321);
            this.btnKimchi.Name = "btnKimchi";
            this.btnKimchi.Size = new System.Drawing.Size(110, 93);
            this.btnKimchi.TabIndex = 4;
            this.btnKimchi.Tag = "food";
            this.btnKimchi.Text = "김취";
            this.btnKimchi.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKimchi.UseVisualStyleBackColor = true;
            this.btnKimchi.Click += new System.EventHandler(this.btnKimchi_Click);
            // 
            // btnOnion
            // 
            this.btnOnion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnion.BackgroundImage")));
            this.btnOnion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnion.Location = new System.Drawing.Point(225, 321);
            this.btnOnion.Name = "btnOnion";
            this.btnOnion.Size = new System.Drawing.Size(98, 89);
            this.btnOnion.TabIndex = 4;
            this.btnOnion.Tag = "food";
            this.btnOnion.Text = "양퐈";
            this.btnOnion.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOnion.UseVisualStyleBackColor = true;
            this.btnOnion.Click += new System.EventHandler(this.btnOnion_Click);
            // 
            // btnTuna
            // 
            this.btnTuna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTuna.BackgroundImage")));
            this.btnTuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTuna.Location = new System.Drawing.Point(225, 197);
            this.btnTuna.Name = "btnTuna";
            this.btnTuna.Size = new System.Drawing.Size(98, 92);
            this.btnTuna.TabIndex = 4;
            this.btnTuna.Tag = "food";
            this.btnTuna.Text = "동원참치";
            this.btnTuna.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTuna.UseVisualStyleBackColor = true;
            this.btnTuna.Click += new System.EventHandler(this.btnTuna_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnTuna);
            this.GroupBox1.Controls.Add(this.btnOnion);
            this.GroupBox1.Controls.Add(this.btnKimchi);
            this.GroupBox1.Controls.Add(this.btnEggs);
            this.GroupBox1.Controls.Add(this.btnTofu);
            this.GroupBox1.Controls.Add(this.btnRice);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Location = new System.Drawing.Point(1, 47);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(457, 544);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 603);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnLeftMove);
            this.Controls.Add(this.btnModalForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModalForm;
        private System.Windows.Forms.Button btnLeftMove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRice;
        private System.Windows.Forms.Button btnTofu;
        private System.Windows.Forms.Button btnEggs;
        private System.Windows.Forms.Button btnKimchi;
        private System.Windows.Forms.Button btnOnion;
        private System.Windows.Forms.Button btnTuna;
        private System.Windows.Forms.GroupBox GroupBox1;
        public System.Windows.Forms.ListBox listBox1;
    }
}

