namespace _33_ModelessForm
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
            this.btnModelessForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModelessForm
            // 
            this.btnModelessForm.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.btnModelessForm.Location = new System.Drawing.Point(73, 87);
            this.btnModelessForm.Name = "btnModelessForm";
            this.btnModelessForm.Size = new System.Drawing.Size(445, 151);
            this.btnModelessForm.TabIndex = 0;
            this.btnModelessForm.Text = "모델리스 폼 띄우기";
            this.btnModelessForm.UseVisualStyleBackColor = true;
            this.btnModelessForm.Click += new System.EventHandler(this.btnModelessForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModelessForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModelessForm;
    }
}

