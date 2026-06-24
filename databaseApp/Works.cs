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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace databaseApp
{
    public partial class Works : Form
    {
        private MainWindow main;
        private int backTab;
        private string connectionstring = @"Server=.; Database=Teachears; Integrated Security=True;";
        private bool isEdit = false;
        private string workId = "";
        public Works(MainWindow main1, int currentTab)
        {
            InitializeComponent();
            this.main = main1;
            this.backTab = currentTab;
            this.isEdit = false;
        }
        public Works(MainWindow main1, int currentTab, string id, string teacherId, string subjectId,
            string academicYear, string countHour, string isExam)
        {
            InitializeComponent();
            this.main = main1;
            this.backTab = currentTab;
            this.workId = id;
            this.isEdit = true;

            yearTextBox.Text = academicYear;
            hourTextBox.Text = countHour;

            teacherComboBox.Tag = teacherId;
            subjectComboBox.Tag = subjectId;
            examCheckBox.Checked = Convert.ToBoolean(isExam);
        }

        private void Works_Load(object sender, EventArgs e)
        {
            FillComboBox("SELECT id, CONCAT(last_name, ' ', first_name, ' ', patronymic) AS namen " +
                "FROM teachers", teacherComboBox, "namen", "id");
            FillComboBox("SELECT id, namen FROM subjects", subjectComboBox, "namen", "id");

            if (isEdit)
            {
                if (teacherComboBox.Tag != null) teacherComboBox.SelectedValue = Convert.ToInt32(teacherComboBox.Tag);
                if (subjectComboBox.Tag != null) subjectComboBox.SelectedValue = Convert.ToInt32(subjectComboBox.Tag);

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
            if (string.IsNullOrWhiteSpace(yearTextBox.Text) || string.IsNullOrWhiteSpace(hourTextBox.Text))
            {
                MessageBox.Show("Заполни все", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(hourTextBox.Text, out int hours) || hours <= 0)
            {
                MessageBox.Show("Ты не то ввел, нужно вводить правильное число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string academicYear = yearTextBox.Text;
            if (academicYear.Length != 9 || !academicYear.Contains("/"))
            {
                MessageBox.Show("Не так. Вот так: ГГГГ/ГГГГ", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] years = academicYear.Split('/');
            if (int.TryParse(years[0], out int startYear) && int.TryParse(years[1], out int endYear))
            {
                if (endYear - startYear != 1)
                {
                    MessageBox.Show("Сколько лет у вас длится один год?\nТак должно быть: 2025/2026", "Логическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не так. Вот так: ГГГГ/ГГГГ", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query;
            if (isEdit)
            {
                query = @"UPDATE works SET 
                  teacher_id = @teacher_id, subject_id = @subject_id, 
                  academic_year = @academic_year, count_hours = @count_hours, 
                  is_there_an_exam = @is_there_an_exam 
                  WHERE id = @id";
            }
            else
            {
                query = @"INSERT INTO works (teacher_id, subject_id, academic_year, count_hours, is_there_an_exam) 
                  VALUES (@teacher_id, @subject_id, @academic_year, @count_hours, @is_there_an_exam)";
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@teacher_id", teacherComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@subject_id", subjectComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@academic_year", academicYear);
                    cmd.Parameters.AddWithValue("@count_hours", hours);
                    cmd.Parameters.AddWithValue("@is_there_an_exam", examCheckBox.Checked);

                    if (isEdit)
                    {
                        cmd.Parameters.AddWithValue("@id", workId);
                    }

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    if (isEdit)
                    {
                        MessageBox.Show("Данные о занятии успешно обновлены!");
                    }
                    else
                    {
                        MessageBox.Show("Занятие успешно добавлено!");
                    }
                    main.loadpanel(new MainChoices(main, backTab));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении занятия: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            main.loadpanel(new MainChoices(main, backTab));
        }
    }
}
