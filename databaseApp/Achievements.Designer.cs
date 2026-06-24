namespace databaseApp
{
    partial class Achievements
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
            this.achiDateLabel = new System.Windows.Forms.Label();
            this.achiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rewardLabel = new System.Windows.Forms.Label();
            this.rewardTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(669, 396);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 39);
            this.backButton.TabIndex = 102;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(655, 351);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 39);
            this.saveButton.TabIndex = 101;
            this.saveButton.Text = "Добавить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // achiDateLabel
            // 
            this.achiDateLabel.AutoSize = true;
            this.achiDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.achiDateLabel.Location = new System.Drawing.Point(324, 262);
            this.achiDateLabel.Name = "achiDateLabel";
            this.achiDateLabel.Size = new System.Drawing.Size(200, 29);
            this.achiDateLabel.TabIndex = 95;
            this.achiDateLabel.Text = "Дата получения";
            // 
            // achiDateTimePicker
            // 
            this.achiDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.achiDateTimePicker.Location = new System.Drawing.Point(297, 294);
            this.achiDateTimePicker.Name = "achiDateTimePicker";
            this.achiDateTimePicker.Size = new System.Drawing.Size(244, 34);
            this.achiDateTimePicker.TabIndex = 93;
            // 
            // rewardLabel
            // 
            this.rewardLabel.AutoSize = true;
            this.rewardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardLabel.Location = new System.Drawing.Point(253, 157);
            this.rewardLabel.Name = "rewardLabel";
            this.rewardLabel.Size = new System.Drawing.Size(132, 29);
            this.rewardLabel.TabIndex = 88;
            this.rewardLabel.Text = "Результат";
            // 
            // rewardTextBox
            // 
            this.rewardTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardTextBox.Location = new System.Drawing.Point(221, 200);
            this.rewardTextBox.Name = "rewardTextBox";
            this.rewardTextBox.Size = new System.Drawing.Size(176, 34);
            this.rewardTextBox.TabIndex = 87;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(253, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(126, 29);
            this.nameLabel.TabIndex = 86;
            this.nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(221, 108);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 34);
            this.nameTextBox.TabIndex = 85;
            // 
            // levelComboBox
            // 
            this.levelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(446, 199);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(176, 37);
            this.levelComboBox.TabIndex = 106;
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(446, 108);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(176, 37);
            this.teacherComboBox.TabIndex = 105;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelLabel.Location = new System.Drawing.Point(505, 167);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(59, 29);
            this.levelLabel.TabIndex = 104;
            this.levelLabel.Text = "Тип";
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherLabel.Location = new System.Drawing.Point(441, 76);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(194, 29);
            this.teacherLabel.TabIndex = 103;
            this.teacherLabel.Text = "Преподаватель";
            // 
            // Achievements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.teacherComboBox);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.achiDateLabel);
            this.Controls.Add(this.achiDateTimePicker);
            this.Controls.Add(this.rewardLabel);
            this.Controls.Add(this.rewardTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Achievements";
            this.Text = "Achievements";
            this.Load += new System.EventHandler(this.Achievements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label achiDateLabel;
        private System.Windows.Forms.DateTimePicker achiDateTimePicker;
        private System.Windows.Forms.Label rewardLabel;
        private System.Windows.Forms.TextBox rewardTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.ComboBox teacherComboBox;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label teacherLabel;
    }
}