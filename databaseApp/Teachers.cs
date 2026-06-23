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
    public partial class Teachers : Form
    {
        private MainWindow main;
        private int backTab;
        private string connectionstring = @"Server=.; Database=Teachears; Integrated Security=True;";
        private bool isEdit = false;
        private string teacherId = "";

        public Teachers(MainWindow main1, int currentTab)
        {
            InitializeComponent();
            this.main = main1;
            this.backTab = currentTab;
            this.isEdit = false;
        }

        public Teachers(MainWindow main1, int currentTab, string id, string lastName, string firstName,
            string patronymic, string email, string birthDate, string hireDate, string positionId, string qualificationId)
        {
            InitializeComponent();
            this.main = main1;
            this.backTab = currentTab;
            this.teacherId = id;
            this.isEdit = true;

            lastNameTextBox.Text = lastName;
            firstNameTextBox.Text = firstName;
            patronymicTextBox.Text = patronymic;
            emailTextBox.Text = email;

            birthDateTimePicker.Value = Convert.ToDateTime(birthDate);
            hireDateTimePicker.Value = Convert.ToDateTime(hireDate);

            positionComboBox.Tag = positionId;
            qualificationComboBox.Tag = qualificationId;
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            FillComboBox("SELECT id, namen FROM positions", positionComboBox, "namen", "id");
            FillComboBox("SELECT id, namen FROM qualifications", qualificationComboBox, "namen", "id");

            if (isEdit)
            {
                if (positionComboBox.Tag != null) positionComboBox.SelectedValue = Convert.ToInt32(positionComboBox.Tag);
                if (qualificationComboBox.Tag != null) qualificationComboBox.SelectedValue = Convert.ToInt32(qualificationComboBox.Tag);

                saveButton.Text = "Изменить";
            }
        }

        private void FillComboBox(string query, ComboBox cbo, string displayField, string valueField)
        {
            string connectionString = @"Server=.; Database=Teachears; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.DisplayMember = displayField;
                cbo.ValueMember = valueField;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните Фамилию и Имя преподавателя!");
                return;
            }

            string query;
            if (isEdit)
            {
                query = @"UPDATE teachers SET 
                          first_name = @first_name, last_name = @last_name, patronymic = @patronymic, 
                          birth_date = @birth_date, hire_date = @hire_date, position = @position, 
                          qualification = @qualification, email = @email 
                          WHERE id = @id";
            }
            else
            {
                query = @"INSERT INTO teachers (first_name, last_name, patronymic, birth_date, hire_date, position, qualification, email) 
                          VALUES (@first_name, @last_name, @patronymic, @birth_date, @hire_date, @position, @qualification, @email)";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@last_name", firstNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@first_name", firstNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@patronymic", string.IsNullOrWhiteSpace(patronymicTextBox.Text) ? (object)DBNull.Value : patronymicTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@birth_date", birthDateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@hire_date", hireDateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@position", positionComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@qualification", qualificationComboBox.SelectedValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrWhiteSpace(emailTextBox.Text) ? (object)DBNull.Value : emailTextBox.Text.Trim());

                    if (isEdit)
                    {
                        cmd.Parameters.AddWithValue("@id", teacherId);
                    }

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(isEdit ? "Данные преподавателя успешно обновлены!" : "Преподаватель успешно добавлен!");

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
