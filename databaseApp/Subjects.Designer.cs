namespace databaseApp
{
    partial class Subjects
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
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.countHourLabel = new System.Windows.Forms.Label();
            this.countHourTextBox = new System.Windows.Forms.TextBox();
            this.namenLabel = new System.Windows.Forms.Label();
            this.namenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(669, 404);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 39);
            this.backButton.TabIndex = 86;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(655, 359);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 39);
            this.saveButton.TabIndex = 85;
            this.saveButton.Text = "Добавить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // countHourLabel
            // 
            this.countHourLabel.AutoSize = true;
            this.countHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countHourLabel.Location = new System.Drawing.Point(360, 112);
            this.countHourLabel.Name = "countHourLabel";
            this.countHourLabel.Size = new System.Drawing.Size(224, 29);
            this.countHourLabel.TabIndex = 90;
            this.countHourLabel.Text = "Количество часов";
            // 
            // countHourTextBox
            // 
            this.countHourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countHourTextBox.Location = new System.Drawing.Point(380, 152);
            this.countHourTextBox.Name = "countHourTextBox";
            this.countHourTextBox.Size = new System.Drawing.Size(176, 34);
            this.countHourTextBox.TabIndex = 89;
            // 
            // namenLabel
            // 
            this.namenLabel.AutoSize = true;
            this.namenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namenLabel.Location = new System.Drawing.Point(197, 112);
            this.namenLabel.Name = "namenLabel";
            this.namenLabel.Size = new System.Drawing.Size(126, 29);
            this.namenLabel.TabIndex = 88;
            this.namenLabel.Text = "Название";
            // 
            // namenTextBox
            // 
            this.namenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namenTextBox.Location = new System.Drawing.Point(165, 152);
            this.namenTextBox.Name = "namenTextBox";
            this.namenTextBox.Size = new System.Drawing.Size(176, 34);
            this.namenTextBox.TabIndex = 87;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countHourLabel);
            this.Controls.Add(this.countHourTextBox);
            this.Controls.Add(this.namenLabel);
            this.Controls.Add(this.namenTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label countHourLabel;
        private System.Windows.Forms.TextBox countHourTextBox;
        private System.Windows.Forms.Label namenLabel;
        private System.Windows.Forms.TextBox namenTextBox;
    }
}