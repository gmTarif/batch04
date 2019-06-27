﻿namespace MyWinApp
{
    partial class ArrayForm
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
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.UniqeButton = new System.Windows.Forms.Button();
            this.MaxMinButton = new System.Windows.Forms.Button();
            this.OddEvenButton = new System.Windows.Forms.Button();
            this.AscendingButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(12, 67);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(238, 305);
            this.showRichTextBox.TabIndex = 1;
            this.showRichTextBox.Text = "";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(256, 70);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(132, 23);
            this.ShowButton.TabIndex = 1;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(12, 41);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(150, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(175, 38);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(256, 99);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(132, 23);
            this.ReverseButton.TabIndex = 4;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(256, 128);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(132, 23);
            this.SumButton.TabIndex = 5;
            this.SumButton.Text = "Sum";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(256, 157);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(132, 23);
            this.CopyButton.TabIndex = 6;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Location = new System.Drawing.Point(256, 185);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(132, 23);
            this.DuplicateButton.TabIndex = 7;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // UniqeButton
            // 
            this.UniqeButton.Location = new System.Drawing.Point(256, 214);
            this.UniqeButton.Name = "UniqeButton";
            this.UniqeButton.Size = new System.Drawing.Size(132, 23);
            this.UniqeButton.TabIndex = 8;
            this.UniqeButton.Text = "Uniqe";
            this.UniqeButton.UseVisualStyleBackColor = true;
            // 
            // MaxMinButton
            // 
            this.MaxMinButton.Location = new System.Drawing.Point(256, 243);
            this.MaxMinButton.Name = "MaxMinButton";
            this.MaxMinButton.Size = new System.Drawing.Size(132, 23);
            this.MaxMinButton.TabIndex = 9;
            this.MaxMinButton.Text = "Max/Min";
            this.MaxMinButton.UseVisualStyleBackColor = true;
            this.MaxMinButton.Click += new System.EventHandler(this.MaxMinButton_Click);
            // 
            // OddEvenButton
            // 
            this.OddEvenButton.Location = new System.Drawing.Point(256, 272);
            this.OddEvenButton.Name = "OddEvenButton";
            this.OddEvenButton.Size = new System.Drawing.Size(132, 23);
            this.OddEvenButton.TabIndex = 10;
            this.OddEvenButton.Text = "Odd/Even";
            this.OddEvenButton.UseVisualStyleBackColor = true;
            // 
            // AscendingButton
            // 
            this.AscendingButton.Location = new System.Drawing.Point(256, 301);
            this.AscendingButton.Name = "AscendingButton";
            this.AscendingButton.Size = new System.Drawing.Size(132, 23);
            this.AscendingButton.TabIndex = 11;
            this.AscendingButton.Text = "Ascending/Descending";
            this.AscendingButton.UseVisualStyleBackColor = true;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(256, 330);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(132, 23);
            this.InsertButton.TabIndex = 12;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 384);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.AscendingButton);
            this.Controls.Add(this.OddEvenButton);
            this.Controls.Add(this.MaxMinButton);
            this.Controls.Add(this.UniqeButton);
            this.Controls.Add(this.DuplicateButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.showRichTextBox);
            this.Name = "ArrayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DuplicateButton;
        private System.Windows.Forms.Button UniqeButton;
        private System.Windows.Forms.Button MaxMinButton;
        private System.Windows.Forms.Button OddEvenButton;
        private System.Windows.Forms.Button AscendingButton;
        private System.Windows.Forms.Button InsertButton;
    }
}