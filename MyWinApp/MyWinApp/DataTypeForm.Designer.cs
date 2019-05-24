namespace MyWinApp
{
    partial class DataTypeForm
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
            this.DataTypeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataTypeButton
            // 
            this.DataTypeButton.Location = new System.Drawing.Point(342, 124);
            this.DataTypeButton.Name = "DataTypeButton";
            this.DataTypeButton.Size = new System.Drawing.Size(90, 35);
            this.DataTypeButton.TabIndex = 0;
            this.DataTypeButton.Text = "Data Type";
            this.DataTypeButton.UseVisualStyleBackColor = true;
            this.DataTypeButton.Click += new System.EventHandler(this.DataTypeButton_Click);
            // 
            // DataTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataTypeButton);
            this.Name = "DataTypeForm";
            this.Text = "Data Type";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DataTypeButton;
    }
}