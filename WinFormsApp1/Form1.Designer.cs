﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 129);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Pierwsza liczba";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 179);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 1;
            label2.Text = "Druga liczba";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 31);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(265, 236);
            button1.Name = "button1";
            button1.Size = new Size(140, 34);
            button1.TabIndex = 4;
            button1.Text = "Dodawanie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(411, 236);
            button2.Name = "button2";
            button2.Size = new Size(140, 34);
            button2.TabIndex = 5;
            button2.Text = "Odejmowanie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(265, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 31);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 291);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 7;
            label3.Text = "Wynik";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label3;
        public TextBox textBox3;
    }
}
