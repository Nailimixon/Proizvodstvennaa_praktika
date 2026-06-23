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
            this.deleteButtonTeachears = new System.Windows.Forms.Button();
            this.updateButtonTeachears = new System.Windows.Forms.Button();
            this.addButtonTeachears = new System.Windows.Forms.Button();
            this.teachearsView = new System.Windows.Forms.DataGridView();
            this.subjectsPage = new System.Windows.Forms.TabPage();
            this.subjectsView = new System.Windows.Forms.DataGridView();
            this.worksPage = new System.Windows.Forms.TabPage();
            this.worksView = new System.Windows.Forms.DataGridView();
            this.achievementsPage = new System.Windows.Forms.TabPage();
            this.achievementsView = new System.Windows.Forms.DataGridView();
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
            this.directorTabControl.Size = new System.Drawing.Size(800, 452);
            this.directorTabControl.TabIndex = 0;
            this.directorTabControl.SelectedIndexChanged += new System.EventHandler(this.directorTabControl_SelectedIndexChanged);
            // 
            // teachersPage
            // 
            this.teachersPage.Controls.Add(this.deleteButtonTeachears);
            this.teachersPage.Controls.Add(this.updateButtonTeachears);
            this.teachersPage.Controls.Add(this.addButtonTeachears);
            this.teachersPage.Controls.Add(this.teachearsView);
            this.teachersPage.Location = new System.Drawing.Point(4, 25);
            this.teachersPage.Name = "teachersPage";
            this.teachersPage.Padding = new System.Windows.Forms.Padding(3);
            this.teachersPage.Size = new System.Drawing.Size(792, 423);
            this.teachersPage.TabIndex = 0;
            this.teachersPage.Text = "Преподаватели";
            this.teachersPage.UseVisualStyleBackColor = true;
            // 
            // deleteButtonTeachears
            // 
            this.deleteButtonTeachears.AutoSize = true;
            this.deleteButtonTeachears.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButtonTeachears.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButtonTeachears.Location = new System.Drawing.Point(505, 316);
            this.deleteButtonTeachears.Name = "deleteButtonTeachears";
            this.deleteButtonTeachears.Size = new System.Drawing.Size(122, 39);
            this.deleteButtonTeachears.TabIndex = 18;
            this.deleteButtonTeachears.Text = "Удалить";
            this.deleteButtonTeachears.UseVisualStyleBackColor = true;
            // 
            // updateButtonTeachears
            // 
            this.updateButtonTeachears.AutoSize = true;
            this.updateButtonTeachears.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButtonTeachears.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButtonTeachears.Location = new System.Drawing.Point(325, 316);
            this.updateButtonTeachears.Name = "updateButtonTeachears";
            this.updateButtonTeachears.Size = new System.Drawing.Size(138, 39);
            this.updateButtonTeachears.TabIndex = 17;
            this.updateButtonTeachears.Text = "Обновить";
            this.updateButtonTeachears.UseVisualStyleBackColor = true;
            // 
            // addButtonTeachears
            // 
            this.addButtonTeachears.AutoSize = true;
            this.addButtonTeachears.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButtonTeachears.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButtonTeachears.Location = new System.Drawing.Point(152, 316);
            this.addButtonTeachears.Name = "addButtonTeachears";
            this.addButtonTeachears.Size = new System.Drawing.Size(133, 39);
            this.addButtonTeachears.TabIndex = 16;
            this.addButtonTeachears.Text = "Добавить";
            this.addButtonTeachears.UseVisualStyleBackColor = true;
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
            this.subjectsPage.Size = new System.Drawing.Size(792, 423);
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
            this.worksPage.Size = new System.Drawing.Size(792, 423);
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
            this.achievementsPage.Size = new System.Drawing.Size(792, 423);
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
            // MainChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directorTabControl);
            this.Name = "MainChoices";
            this.Text = "MainChoices";
            this.Load += new System.EventHandler(this.MainChoices_Load);
            this.directorTabControl.ResumeLayout(false);
            this.teachersPage.ResumeLayout(false);
            this.teachersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachearsView)).EndInit();
            this.subjectsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsView)).EndInit();
            this.worksPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.worksView)).EndInit();
            this.achievementsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.achievementsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl directorTabControl;
        private System.Windows.Forms.TabPage teachersPage;
        private System.Windows.Forms.TabPage subjectsPage;
        private System.Windows.Forms.TabPage worksPage;
        private System.Windows.Forms.TabPage achievementsPage;
        private System.Windows.Forms.Button deleteButtonTeachears;
        private System.Windows.Forms.Button updateButtonTeachears;
        private System.Windows.Forms.Button addButtonTeachears;
        private System.Windows.Forms.DataGridView teachearsView;
        private System.Windows.Forms.DataGridView subjectsView;
        private System.Windows.Forms.DataGridView worksView;
        private System.Windows.Forms.DataGridView achievementsView;
    }
}