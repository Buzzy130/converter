﻿namespace po_lab1
{
    partial class history
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(391, 542);
            label1.TabIndex = 0;
            label1.Text = "";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 554);
            button1.Name = "button1";
            button1.Size = new Size(391, 23);
            button1.TabIndex = 1;
            button1.Text = "Отобразить историю запросов";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 589);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "history";
            Text = "history";
            ResumeLayout(false);
        }

        #endregion

        public Label label1;
        private Button button1;
    }
}