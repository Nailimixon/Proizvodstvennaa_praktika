using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseApp
{
    public partial class MainWindow : Form
    {
        private Form f1;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void loadpanel(Form form)
        {
            if (f1 != null)
            {
                f1.Close();
            }
            f1 = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            ShowOtherWindowsPanel.Controls.Clear();
            ShowOtherWindowsPanel.Controls.Add(form);
            ShowOtherWindowsPanel.Tag = form;
            form.Show();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            loadpanel(new MainChoices(this));
        }
    }
}
