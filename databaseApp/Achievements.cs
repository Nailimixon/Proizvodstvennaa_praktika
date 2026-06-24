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
    public partial class Achievements : Form
    {
        private MainWindow main;
        private int backTab;
        private string connectionstring = @"Server=.; Database=Teachears; Integrated Security=True;";
        private bool isEdit = false;
        private string achiId = "";
        public Achievements(MainWindow main1, int currentTab)
        {
            InitializeComponent();
            this.main = main1;
            this.backTab = currentTab;
            this.isEdit = false;
        }
        public Achievements(MainWindow main1, int currentTab, string id, string teacherId, string namen,
            string achiDate, string levelId, string reward)
        {
            InitializeComponent();
            this.main = main1;
            this.backTab = currentTab;
            this.achiId = id;
            this.isEdit = true;

            nameTextBox.Text = namen;
            rewardTextBox.Text = reward;

            achiDateTimePicker.Value = Convert.ToDateTime(achiDate);

            teacherComboBox.Tag = teacherId;
            levelComboBox.Tag = levelId;
        }
        private void Achievements_Load(object sender, EventArgs e)
        {
            FillComboBox("SELECT id, CONCAT(last_name, ' ', first_name, ' ', patronymic) AS namen " +
                "FROM teachers;", teacherComboBox, "namen", "id");
            FillComboBox("SELECT id, namen FROM level_types", levelComboBox, "namen", "id");

            if (isEdit)
            {
                if (teacherComboBox.Tag != null) teacherComboBox.SelectedValue = Convert.ToInt32(teacherComboBox.Tag);
                if (levelComboBox.Tag != null) levelComboBox.SelectedValue = Convert.ToInt32(levelComboBox.Tag);

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
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(rewardTextBox.Text))
            {
                MessageBox.Show("Заполни название достижения и результат!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (achiDateTimePicker.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Будущее?", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query;
            if (isEdit)
            {
                query = @"UPDATE achievements SET 
                  teacher_id = @teacher_id, namen = @namen, achi_date = @achi_date, 
                  level_id = @level_id, reward = @reward 
                  WHERE id = @id";
            }
            else
            {
                query = @"INSERT INTO achievements (teacher_id, namen, achi_date, level_id, reward) 
                  VALUES (@teacher_id, @namen, @achi_date, @level_id, @reward)";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@teacher_id", teacherComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@namen", nameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@achi_date", achiDateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@level_id", levelComboBox.SelectedValue);
                    if (string.IsNullOrWhiteSpace(rewardTextBox.Text))
                    {
                        cmd.Parameters.AddWithValue("@reward", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@reward", rewardTextBox.Text);
                    }
                    if (isEdit)
                    {
                        cmd.Parameters.AddWithValue("@id", achiId);
                    }

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    if (isEdit)
                    {
                        MessageBox.Show("Достижение успешно обновлено!");
                    }
                    else
                    {
                        MessageBox.Show("Достижение успешно добавлено!");
                    }

                    main.loadpanel(new MainChoices(main, backTab));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении достижения: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            main.loadpanel(new MainChoices(main, backTab));
        }
    }
}
