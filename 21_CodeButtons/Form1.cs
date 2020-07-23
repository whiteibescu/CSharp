﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_CodeButtons
{
    public partial class Form1 : Form
    {
        const int FORM_WIDTH = 1000;
        const int FORM_HEIGHT = 1000;
        const int BUTTON_SIZE = 100;
        int rows, cols;
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = FORM_WIDTH;
            this.Height = FORM_HEIGHT;

            this.rows = this.Width / BUTTON_SIZE;
            this.cols = this.Height / BUTTON_SIZE;
            MakeButtons();
        }

        private void MakeButtons()
        {
            Random random = new Random();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    Button btn = new Button();
                    btn.Left = j * BUTTON_SIZE;
                    btn.Top = i * BUTTON_SIZE;
                    btn.Width = BUTTON_SIZE;
                    btn.Height = BUTTON_SIZE;
                    btn.Margin = new Padding(0);
                    btn.Text = cnt++.ToString(); 
                    btn.BackColor = Color.FromArgb(255, random.Next(255), random.Next(256), random.Next(257));
                    btn.Click += Btn_Click;
                    this.Controls.Add(btn);
                }
            }
        }
        //버튼 클릭시 화면 이미지가 폭탄이미지로 변경
        // 1초후 버튼이 사라지게하세요

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Console.WriteLine(btn.Text);
            }
        }
    }
}
