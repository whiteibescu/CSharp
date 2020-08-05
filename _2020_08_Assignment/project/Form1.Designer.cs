namespace project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFood
            // 
            this.btnFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFood.BackgroundImage")));
            this.btnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFood.Font = new System.Drawing.Font("Gungsuh", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFood.Location = new System.Drawing.Point(47, 37);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(242, 216);
            this.btnFood.TabIndex = 0;
            this.btnFood.Text = "계란말이";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFood;
    }
}

