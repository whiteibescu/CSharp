
namespace CreatingJsonFile2
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
            this.Startbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Endbtn = new System.Windows.Forms.Button();
            this.WatchValue = new System.Windows.Forms.Label();
            this.ProgressList = new System.Windows.Forms.ListBox();
            this.Progress_txt = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Startbtn
            // 
            this.Startbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Startbtn.Font = new System.Drawing.Font("TmonMonsori Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Startbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Startbtn.Location = new System.Drawing.Point(93, 363);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(150, 54);
            this.Startbtn.TabIndex = 0;
            this.Startbtn.Text = "START";
            this.Startbtn.UseVisualStyleBackColor = false;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TmonMonsori Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer";
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetbtn.Font = new System.Drawing.Font("TmonMonsori Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Resetbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Resetbtn.Location = new System.Drawing.Point(567, 363);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(150, 54);
            this.Resetbtn.TabIndex = 4;
            this.Resetbtn.Text = "RESET";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Endbtn
            // 
            this.Endbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Endbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Endbtn.Font = new System.Drawing.Font("TmonMonsori Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Endbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Endbtn.Location = new System.Drawing.Point(335, 363);
            this.Endbtn.Name = "Endbtn";
            this.Endbtn.Size = new System.Drawing.Size(150, 54);
            this.Endbtn.TabIndex = 5;
            this.Endbtn.Text = "END";
            this.Endbtn.UseVisualStyleBackColor = false;
            this.Endbtn.Click += new System.EventHandler(this.Endbtn_Click);
            // 
            // WatchValue
            // 
            this.WatchValue.AutoSize = true;
            this.WatchValue.Font = new System.Drawing.Font("TmonMonsori Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WatchValue.ForeColor = System.Drawing.SystemColors.Control;
            this.WatchValue.Location = new System.Drawing.Point(506, 152);
            this.WatchValue.Name = "WatchValue";
            this.WatchValue.Size = new System.Drawing.Size(243, 46);
            this.WatchValue.TabIndex = 6;
            this.WatchValue.Text = "00:00:00.00";
            // 
            // ProgressList
            // 
            this.ProgressList.FormattingEnabled = true;
            this.ProgressList.ItemHeight = 12;
            this.ProgressList.Location = new System.Drawing.Point(115, 55);
            this.ProgressList.Name = "ProgressList";
            this.ProgressList.Size = new System.Drawing.Size(352, 268);
            this.ProgressList.TabIndex = 7;
            this.ProgressList.SelectedIndexChanged += new System.EventHandler(this.ProgressList_SelectedIndexChanged);
            // 
            // Progress_txt
            // 
            this.Progress_txt.AutoSize = true;
            this.Progress_txt.Font = new System.Drawing.Font("TmonMonsori Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress_txt.Location = new System.Drawing.Point(194, 22);
            this.Progress_txt.Name = "Progress_txt";
            this.Progress_txt.Size = new System.Drawing.Size(173, 30);
            this.Progress_txt.TabIndex = 8;
            this.Progress_txt.Text = "Progress List";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Progress_txt);
            this.Controls.Add(this.ProgressList);
            this.Controls.Add(this.WatchValue);
            this.Controls.Add(this.Endbtn);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Startbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Button Endbtn;
        private System.Windows.Forms.Label WatchValue;
        private System.Windows.Forms.ListBox ProgressList;
        private System.Windows.Forms.Label Progress_txt;
        private System.Windows.Forms.Timer timer2;
    }
}

