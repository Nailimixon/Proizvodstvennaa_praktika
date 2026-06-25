namespace databaseApp
{
    partial class Statistic
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(160, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(51, 29);
            this.titleLabel.TabIndex = 104;
            this.titleLabel.Text = "title";
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(117, 87);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(598, 251);
            this.resultRichTextBox.TabIndex = 105;
            this.resultRichTextBox.Text = "";
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(362, 371);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 39);
            this.backButton.TabIndex = 106;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Button backButton;
    }
}