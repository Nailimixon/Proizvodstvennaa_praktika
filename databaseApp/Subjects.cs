using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseApp
{
    public partial class Subjects : Form
    {
        private MainWindow main;
        private int backTab;
        private string connectionstring = @"Server=.; Database=Teachears; Integrated Security=True;";
        private bool isEdit = false;
        private string subjectId = "";
        public Subjects(MainWindow main1, int currentTab)
        {
            InitializeComponent();
            this.main = main1;
            this.backTab = currentTab;
            this.isEdit = false;
        }
        public Subjects(MainWindow main1, int currentTab, string id, string namen, string countHour)
        {
            InitializeComponent();
            this.main = main1;
            this.backTab = currentTab;
            this.subjectId = id;
            this.isEdit = true;

            namenTextBox.Text = namen;
            countHourTextBox.Text = countHour;
        }
        private void Subjects_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                saveButton.Text = "Изменить";
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namenTextBox.Text) || string.IsNullOrWhiteSpace(countHourTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните Название и Количество часов!");
                return;
            }
            if (!int.TryParse(countHourTextBox.Text, out int hours) || hours <= 0)
            {
                MessageBox.Show("Ты не то ввел, нужно вводить правильное число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query;
            if (isEdit)
            {
                query = @"UPDATE subjects SET 
                          namen = @namen, all_hours = @all_hours 
                          WHERE id = @id";
            }
            else
            {
                query = @"INSERT INTO subjects (namen, all_hours) 
                          VALUES (@namen, @all_hours)";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@namen", namenTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@all_hours", countHourTextBox.Text.Trim());

                    if (isEdit)
                    {
                        cmd.Parameters.AddWithValue("@id", subjectId);
                    }

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    if (isEdit)
                    {
                        MessageBox.Show("Данные предмета успешно обновлены!");
                    }
                    else
                    {
                        MessageBox.Show("Предмет успешно добавлен!");
                    }

                    main.loadpanel(new MainChoices(main, backTab));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            main.loadpanel(new MainChoices(main, backTab));
        }
    }
}
