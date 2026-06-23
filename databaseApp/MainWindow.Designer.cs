namespace databaseApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowOtherWindowsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ShowOtherWindowsPanel
            // 
            this.ShowOtherWindowsPanel.Location = new System.Drawing.Point(-1, 2);
            this.ShowOtherWindowsPanel.Name = "ShowOtherWindowsPanel";
            this.ShowOtherWindowsPanel.Size = new System.Drawing.Size(802, 447);
            this.ShowOtherWindowsPanel.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowOtherWindowsPanel);
            this.Name = "MainWindow";
            this.Text = "База данных учителей";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ShowOtherWindowsPanel;
    }
}

