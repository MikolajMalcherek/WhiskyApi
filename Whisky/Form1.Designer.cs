﻿namespace Whisky
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
            button1 = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(400, 52);
            button1.Name = "button1";
            button1.Size = new Size(237, 91);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(26, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(317, 364);
            listBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(400, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 27);
            textBox2.TabIndex = 4;
            textBox2.Text = "Wpisz nazwę";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(400, 275);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(237, 104);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox textBox2;
        private ListBox listBox2;
    }
}