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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace databaseApp
{
    public partial class MainChoices : Form
    {
        private MainWindow main;
        public MainChoices(MainWindow main1,  int directorTabIndex = 0)
        {
            InitializeComponent();
            main = main1;
            this.directorTabControl.SelectedIndex = directorTabIndex;
            directorTabControl_SelectedIndexChanged(null, null);
        }

        private void MainChoices_Load(object sender, EventArgs e)
        {
            LoadData(@"SELECT t.id AS [Идентификатор], t.first_name AS [Фимилия], t.last_name AS [Имя], t.patronymic AS [Отчество], 
            t.birth_date AS [Дата рождения], t.hire_date AS [Дата найма], p.namen AS [Должность], q.namen AS [Квалификация], 
            t.email AS [Почта], t.position, t.qualification 
            FROM teachers t 
            LEFT JOIN positions p ON t.position = p.id 
            LEFT JOIN qualifications q ON t.qualification = q.id;", teachearsView);
            teachearsView.Columns["position"].Visible = false;
            teachearsView.Columns["qualification"].Visible = false;
        }

        private void LoadData(string query, DataGridView dataGridView)
        {
            try
            {
                string connectionString = @"Server=.; Database=Teachears; Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    dataGridView.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private void directorTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (directorTabControl.SelectedIndex == 0)
            {
                LoadData(@"SELECT t.id AS [Идентификатор], t.first_name AS [Фимилия], t.last_name AS [Имя], t.patronymic AS [Отчество], 
                t.birth_date AS [Дата рождения], t.hire_date AS [Дата найма], p.namen AS [Должность], q.namen AS [Квалификация], 
                t.email AS [Почта], t.position, t.qualification 
                FROM teachers t 
                LEFT JOIN positions p ON t.position = p.id 
                LEFT JOIN qualifications q ON t.qualification = q.id;", teachearsView);
                teachearsView.Columns["position"].Visible = false;
                teachearsView.Columns["qualification"].Visible = false;
            }
            else if (directorTabControl.SelectedIndex == 1)
            {
                LoadData(@"SELECT id AS [Идентификатор], namen AS [Название], 
                all_hours AS [Количество часов на предмет] 
                FROM subjects;", subjectsView);
            }
            else if (directorTabControl.SelectedIndex == 2)
            {
                LoadData(@"SELECT w.id AS [Идентификатор], 
                CONCAT(t.last_name, ' ', t.first_name, ' ', t.patronymic) AS [Преподаватель], 
                s.namen AS [Предмет], w.academic_year AS [Учебный год], w.count_hours AS [Количество часов в году], 
                w.is_there_an_exam AS [Будет ли экзамен], w.teacher_id, subject_id 
                FROM works w 
                LEFT JOIN teachers t ON w.teacher_id = t.id 
                LEFT JOIN subjects s ON w.subject_id = s.id;", worksView);
                worksView.Columns["teacher_id"].Visible = false;
                worksView.Columns["subject_id"].Visible = false;
            }
            else if (directorTabControl.SelectedIndex == 3)
            {   
                LoadData(@"SELECT achi.id AS [Идентификатор], 
                CONCAT(t.last_name, ' ', t.first_name, ' ', t.patronymic) AS [Преподаватель], 
                achi.namen AS [Название], achi.achi_date AS [Дата проведения], l.namen AS [Вид], 
                achi.reward AS [Результат], achi.teacher_id, achi. level_id 
                FROM achievements achi 
                LEFT JOIN teachers t ON achi.teacher_id = t.id 
                LEFT JOIN level_types l ON achi.level_id = l.id;", achievementsView);
                achievementsView.Columns["teacher_id"].Visible = false;
                achievementsView.Columns["level_id"].Visible = false;
            }
        }
    }
}
