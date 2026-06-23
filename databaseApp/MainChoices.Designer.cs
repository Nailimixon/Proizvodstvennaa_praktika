namespace databaseApp
{
    partial class MainChoices
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
            this.directorTabControl = new System.Windows.Forms.TabControl();
            this.teachersPage = new System.Windows.Forms.TabPage();
            this.teachearsView = new System.Windows.Forms.DataGridView();
            this.subjectsPage = new System.Windows.Forms.TabPage();
            this.subjectsView = new System.Windows.Forms.DataGridView();
            this.worksPage = new System.Windows.Forms.TabPage();
            this.worksView = new System.Windows.Forms.DataGridView();
            this.achievementsPage = new System.Windows.Forms.TabPage();
            this.achievementsView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.directorTabControl.SuspendLayout();
            this.teachersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachearsView)).BeginInit();
            this.subjectsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsView)).BeginInit();
            this.worksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worksView)).BeginInit();
            this.achievementsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.achievementsView)).BeginInit();
            this.SuspendLayout();
            // 
            // directorTabControl
            // 
            this.directorTabControl.Controls.Add(this.teachersPage);
            this.directorTabControl.Controls.Add(this.subjectsPage);
            this.directorTabControl.Controls.Add(this.worksPage);
            this.directorTabControl.Controls.Add(this.achievementsPage);
            this.directorTabControl.Location = new System.Drawing.Point(0, 0);
            this.directorTabControl.Name = "directorTabControl";
            this.directorTabControl.SelectedIndex = 0;
            this.directorTabControl.Size = new System.Drawing.Size(800, 396);
            this.directorTabControl.TabIndex = 0;
            this.directorTabControl.SelectedIndexChanged += new System.EventHandler(this.directorTabControl_SelectedIndexChanged);
            // 
            // teachersPage
            // 
            this.teachersPage.Controls.Add(this.teachearsView);
            this.teachersPage.Location = new System.Drawing.Point(4, 25);
            this.teachersPage.Name = "teachersPage";
            this.teachersPage.Padding = new System.Windows.Forms.Padding(3);
            this.teachersPage.Size = new System.Drawing.Size(792, 367);
            this.teachersPage.TabIndex = 0;
            this.teachersPage.Text = "Преподаватели";
            this.teachersPage.UseVisualStyleBackColor = true;
            // 
            // teachearsView
            // 
            this.teachearsView.AllowUserToAddRows = false;
            this.teachearsView.AllowUserToDeleteRows = false;
            this.teachearsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachearsView.Location = new System.Drawing.Point(8, 34);
            this.teachearsView.Name = "teachearsView";
            this.teachearsView.ReadOnly = true;
            this.teachearsView.RowHeadersWidth = 51;
            this.teachearsView.RowTemplate.Height = 24;
            this.teachearsView.Size = new System.Drawing.Size(776, 261);
            this.teachearsView.TabIndex = 15;
            // 
            // subjectsPage
            // 
            this.subjectsPage.Controls.Add(this.subjectsView);
            this.subjectsPage.Location = new System.Drawing.Point(4, 25);
            this.subjectsPage.Name = "subjectsPage";
            this.subjectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.subjectsPage.Size = new System.Drawing.Size(792, 367);
            this.subjectsPage.TabIndex = 1;
            this.subjectsPage.Text = "Предметы";
            this.subjectsPage.UseVisualStyleBackColor = true;
            // 
            // subjectsView
            // 
            this.subjectsView.AllowUserToAddRows = false;
            this.subjectsView.AllowUserToDeleteRows = false;
            this.subjectsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsView.Location = new System.Drawing.Point(8, 34);
            this.subjectsView.Name = "subjectsView";
            this.subjectsView.ReadOnly = true;
            this.subjectsView.RowHeadersWidth = 51;
            this.subjectsView.RowTemplate.Height = 24;
            this.subjectsView.Size = new System.Drawing.Size(774, 260);
            this.subjectsView.TabIndex = 16;
            // 
            // worksPage
            // 
            this.worksPage.Controls.Add(this.worksView);
            this.worksPage.Location = new System.Drawing.Point(4, 25);
            this.worksPage.Name = "worksPage";
            this.worksPage.Padding = new System.Windows.Forms.Padding(3);
            this.worksPage.Size = new System.Drawing.Size(792, 367);
            this.worksPage.TabIndex = 2;
            this.worksPage.Text = "Занятия";
            this.worksPage.UseVisualStyleBackColor = true;
            // 
            // worksView
            // 
            this.worksView.AllowUserToAddRows = false;
            this.worksView.AllowUserToDeleteRows = false;
            this.worksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worksView.Location = new System.Drawing.Point(6, 34);
            this.worksView.Name = "worksView";
            this.worksView.ReadOnly = true;
            this.worksView.RowHeadersWidth = 51;
            this.worksView.RowTemplate.Height = 24;
            this.worksView.Size = new System.Drawing.Size(778, 259);
            this.worksView.TabIndex = 17;
            // 
            // achievementsPage
            // 
            this.achievementsPage.Controls.Add(this.achievementsView);
            this.achievementsPage.Location = new System.Drawing.Point(4, 25);
            this.achievementsPage.Name = "achievementsPage";
            this.achievementsPage.Padding = new System.Windows.Forms.Padding(3);
            this.achievementsPage.Size = new System.Drawing.Size(792, 367);
            this.achievementsPage.TabIndex = 3;
            this.achievementsPage.Text = "Достижения";
            this.achievementsPage.UseVisualStyleBackColor = true;
            // 
            // achievementsView
            // 
            this.achievementsView.AllowUserToAddRows = false;
            this.achievementsView.AllowUserToDeleteRows = false;
            this.achievementsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.achievementsView.Location = new System.Drawing.Point(8, 33);
            this.achievementsView.Name = "achievementsView";
            this.achievementsView.ReadOnly = true;
            this.achievementsView.RowHeadersWidth = 51;
            this.achievementsView.RowTemplate.Height = 24;
            this.achievementsView.Size = new System.Drawing.Size(776, 259);
            this.achievementsView.TabIndex = 17;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(505, 402);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 39);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(325, 402);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(138, 39);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(152, 402);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(133, 39);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MainChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.directorTabControl);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Name = "MainChoices";
            this.Text = "MainChoices";
            this.Load += new System.EventHandler(this.MainChoices_Load);
            this.directorTabControl.ResumeLayout(false);
            this.teachersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teachearsView)).EndInit();
            this.subjectsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsView)).EndInit();
            this.worksPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.worksView)).EndInit();
            this.achievementsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.achievementsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl directorTabControl;
        private System.Windows.Forms.TabPage teachersPage;
        private System.Windows.Forms.TabPage subjectsPage;
        private System.Windows.Forms.TabPage worksPage;
        private System.Windows.Forms.TabPage achievementsPage;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView teachearsView;
        private System.Windows.Forms.DataGridView subjectsView;
        private System.Windows.Forms.DataGridView worksView;
        private System.Windows.Forms.DataGridView achievementsView;
    }
}