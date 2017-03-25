namespace FordHome
{
    partial class MainForm
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
            this.outdoorTempTextBox = new System.Windows.Forms.TextBox();
            this.outdoorTempLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outdoorTempTextBox
            // 
            this.outdoorTempTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outdoorTempTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.outdoorTempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outdoorTempTextBox.Location = new System.Drawing.Point(432, 15);
            this.outdoorTempTextBox.Name = "outdoorTempTextBox";
            this.outdoorTempTextBox.ReadOnly = true;
            this.outdoorTempTextBox.Size = new System.Drawing.Size(174, 40);
            this.outdoorTempTextBox.TabIndex = 0;
            this.outdoorTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outdoorTempLabel
            // 
            this.outdoorTempLabel.AutoSize = true;
            this.outdoorTempLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outdoorTempLabel.Location = new System.Drawing.Point(12, 9);
            this.outdoorTempLabel.Name = "outdoorTempLabel";
            this.outdoorTempLabel.Size = new System.Drawing.Size(414, 47);
            this.outdoorTempLabel.TabIndex = 1;
            this.outdoorTempLabel.Text = "Outdoor Temperature: (F)";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(649, 22);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 33);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 614);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outdoorTempLabel);
            this.Controls.Add(this.outdoorTempTextBox);
            this.Name = "MainForm";
            this.Text = "Home Desktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label outdoorTempLabel;
        protected System.Windows.Forms.TextBox outdoorTempTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}

