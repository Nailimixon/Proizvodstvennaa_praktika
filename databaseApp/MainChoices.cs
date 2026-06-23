using System;
using System.Collections;
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
        private int startTab;
        private string connectionstring = @"Server=.; Database=Teachears; Integrated Security=True;";
        public MainChoices(MainWindow main1,  int TabIndex = 0)
        {
            InitializeComponent();
            this.main = main1;
            this.startTab = TabIndex;
        }
        private void MainChoices_Load(object sender, EventArgs e)
        {
            directorTabControl.SelectedIndex = startTab;
            UpdateTabContents();
        }
        private void directorTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTabContents();
        }
        private void UpdateTabContents() 
        {
            if (directorTabControl.SelectedIndex == 0)
            {
                string query = @"SELECT t.id AS [Идентификатор], t.first_name AS [Фамилия], t.last_name AS [Имя], 
                t.patronymic AS [Отчество], t.birth_date AS [Дата рождения], t.hire_date AS [Дата найма], 
                p.namen AS [Должность], q.namen AS [Квалификация], t.email AS [Почта], t.position, t.qualification 
                FROM teachers t 
                LEFT JOIN positions p ON t.position = p.id 
                LEFT JOIN qualifications q ON t.qualification = q.id;";
                Loaddata(query, teachearsView);
                teachearsView.Columns["position"].Visible = false;
                teachearsView.Columns["qualification"].Visible = false;
            }
            else if (directorTabControl.SelectedIndex == 1)
            {
                string query = @"SELECT id AS [Идентификатор], namen AS [Название], 
                all_hours AS [Количество часов на предмет] 
                FROM subjects;";
                Loaddata(query, subjectsView);
            }
            else if (directorTabControl.SelectedIndex == 2)
            {
                string query = @"SELECT w.id AS [Идентификатор], 
                CONCAT(t.last_name, ' ', t.first_name, ' ', t.patronymic) AS [Преподаватель], 
                s.namen AS [Предмет], w.academic_year AS [Учебный год], w.count_hours AS [Количество часов в году], 
                w.is_there_an_exam AS [Будет ли экзамен], w.teacher_id, subject_id 
                FROM works w 
                LEFT JOIN teachers t ON w.teacher_id = t.id 
                LEFT JOIN subjects s ON w.subject_id = s.id;";
                Loaddata(query, worksView);
                worksView.Columns["teacher_id"].Visible = false;
                worksView.Columns["subject_id"].Visible = false;
            }
            else if (directorTabControl.SelectedIndex == 3)
            {
                string query = @"SELECT achi.id AS [Идентификатор], 
                CONCAT(t.last_name, ' ', t.first_name, ' ', t.patronymic) AS [Преподаватель], 
                achi.namen AS [Название], achi.achi_date AS [Дата проведения], l.namen AS [Вид], 
                achi.reward AS [Результат], achi.teacher_id, achi. level_id 
                FROM achievements achi 
                LEFT JOIN teachers t ON achi.teacher_id = t.id 
                LEFT JOIN level_types l ON achi.level_id = l.id;";
                Loaddata(query, achievementsView);
                achievementsView.Columns["teacher_id"].Visible = false;
                achievementsView.Columns["level_id"].Visible = false;
            }
        }
        public void Loaddata(string query, DataGridView view)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    view.DataSource = table;
                    if (view.Columns.Contains("Идентификатор")) view.Columns["Идентификатор"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка загрузки" + ex.Message); }
        }
        public void Loadfilter(SqlCommand command, DataGridView view)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    command.Connection = connection;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    view.DataSource = table;
                    if (view.Columns.Contains("Идентификатор")) view.Columns["Идентификатор"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка загрузки" + ex.Message); }
        }
        public void DeleteData(string query, DataGridView view)
        {
            try
            {
                string id = view.CurrentRow.Cells["Идентификатор"].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    main.loadpanel(new MainChoices(main, this.directorTabControl.SelectedIndex));
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка удаления" + ex.Message); }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int currentTab = directorTabControl.SelectedIndex;
            if (currentTab == 0)
            { 
                main.loadpanel(new Teachers(main, currentTab));
            }
            //else if (currentTab == 1)
            //{
            //    main.loadpanel(new Subjects(main, currentTab));
            //}
            //else if (currentTab == 2)
            //{
            //    main.loadpanel(new Works(main, currentTab));
            //}
            //else if (currentTab == 3)
            //{
            //    main.loadpanel(new Achievements(main, currentTab));
            //}
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int currentTab = directorTabControl.SelectedIndex;
            if (currentTab == 0 && teachearsView.CurrentRow.Cells != null)
            {
                var r = teachearsView.CurrentRow.Cells;
                main.loadpanel(new Teachers(main, currentTab, r["Идентификатор"].Value.ToString(), 
                    r["Фамилия"].Value.ToString(), r["Имя"].Value.ToString(), r["Отчество"].Value.ToString(), 
                    r["Почта"].Value.ToString(), r["Дата рождения"].Value.ToString(), r["Дата найма"].Value.ToString(), 
                    r["position"].Value.ToString(), r["qualification"].Value.ToString()));
            }
            //else if (currentTab == 1 && subjectsView.CurrentRow.Cells != null)
            //{
            //    var r = teachearsView.CurrentRow.Cells;
            //    main.loadpanel(new Subjects(main, currentTab, r["Идентификатор"].Value.ToString(), 
            //        r["Название"].Value.ToString(), r["Количество часов на предмет"].Value.ToString()));
            //}
            //else if (currentTab == 2 && worksView.CurrentRow.Cells != null)
            //{
            //    main.loadpanel(new Works(main, currentTab, r["Идентификатор"].Value.ToString(), 
            //        r["teacher_id"].Value.ToString(), r["subject_id"].Value.ToString(), 
            //        r["Учебный год"].Value.ToString(), r["Количество часов в году"].Value.ToString(), 
            //        r["Будет ли экзамен"].Value.ToString()));));
            //}
            //else if (currentTab == 3 && worksView.CurrentRow.Cells != null)
            //{
            //    main.loadpanel(new Achievements(main, currentTab, r["Идентификатор"].Value.ToString(), 
            //        r["teacher_id"].Value.ToString(), r["Название"].Value.ToString(), 
            //        r["Дата проведения"].Value.ToString(), r["level_id"].Value.ToString(), r["Результат"].Value.ToString()));
            //}
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int currentTab = directorTabControl.SelectedIndex;
            DataGridView currentGrid;
            string table;
            if (currentTab == 0)
            {
                currentGrid = teachearsView;
                table = "teachers";
            }
            else if (currentTab == 1) 
            {
                currentGrid = subjectsView;
                table = "subjects";
            }
            else if (currentTab == 2)
            {
                currentGrid = worksView;
                table = "works";
            }
            else 
            {
                currentGrid = achievementsView;
                table = "achievements";
            }
            if (currentGrid.CurrentRow == null) return;
            if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteData($"DELETE FROM {table} WHERE id = @id", currentGrid);
            }
        }
    }
}
