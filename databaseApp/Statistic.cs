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
    public partial class Statistic : Form
    {
        private MainWindow main;
        private int currentTab;
        private string connectionstring = @"Server=.; Database=Teachears; Integrated Security=True;";
        public Statistic(MainWindow mainForm, int tabIndex)
        {
            InitializeComponent();
            this.main = mainForm;
            this.currentTab = tabIndex;
        }
        private void Statistic_Load(object sender, EventArgs e)
        {
            if (currentTab == 0)
            {
                LoadTeachersRating();
            }
            else if (currentTab == 2)
            {
                LoadWorksStats();
            }
            else if (currentTab == 3)
            {
                LoadAchievementsStats();
            }
        }
        private void LoadTeachersRating()
        {
            titleLabel.Text = "Рейтинг преподавателей по \nколичеству их достижений и наград";
            StringBuilder sb = new StringBuilder();

            string query = @"SELECT 
                                CONCAT(t.last_name, ' ', t.first_name, ' ', t.patronymic) AS FIO,
                                COUNT(a.id) AS CountAchi
                             FROM teachers t
                             LEFT JOIN achievements a ON t.id = a.teacher_id
                             GROUP BY t.id, t.last_name, t.first_name, t.patronymic
                             ORDER BY CountAchi DESC;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int place = 1;
                        while (reader.Read())
                        {
                            string fio = reader["FIO"].ToString();
                            int count = Convert.ToInt32(reader["CountAchi"]);
                            sb.AppendLine($"{place}. {fio} — Достижений: {count}");
                            place++;
                        }
                    }
                }
            }
            catch (Exception ex) { sb.AppendLine("Ошибка расчета: " + ex.Message); }

            resultRichTextBox.Text = sb.ToString();
        }

        private void LoadWorksStats()
        {
            titleLabel.Text = "Сводные данные по учебной нагрузке\n и экзаменам.";
            StringBuilder sb = new StringBuilder();

            string queryTotalHours = "SELECT SUM(count_hours) FROM works;";
            string queryExamsCount = "SELECT COUNT(*) FROM works WHERE is_there_an_exam = 1;";
            string queryTeacherHours = @"SELECT w.academic_year AS [Год], 
            CONCAT(t.last_name, ' ', t.first_name, ' ', t.patronymic) AS [ФИО], 
            s.namen AS [Предметы], w.count_hours AS [Часы] 
            FROM works w 
            LEFT JOIN teachers t ON w.teacher_id = t.id 
            LEFT JOIN subjects s ON w.subject_id = s.id 
            ORDER BY t.last_name;";
            string queryExamTeachers = @"SELECT SELECT w.academic_year AS [Год], 
            CONCAT(t.last_name, ' ', t.first_name, ' ', t.patronymic) AS [ФИО], 
            s.namen AS [Предметы] 
            FROM works w 
            LEFT JOIN teachers t ON w.teacher_id = t.id 
            LEFT JOIN subjects s ON w.subject_id = s.id 
            WHERE w.is_there_an_exam = 1 
            ORDER BY t.last_name;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand(queryTotalHours, conn);
                    object totalHours = cmd1.ExecuteScalar();

                    SqlCommand cmd2 = new SqlCommand(queryExamsCount, conn);
                    object totalExams = cmd2.ExecuteScalar();

                    sb.AppendLine($"Общий объем выданных часов по колледжу: {totalHours ?? 0} ч.");
                    sb.AppendLine($"Всего запланировано экзаменов: {totalExams ?? 0}");

                    sb.AppendLine("Нагрузка по преподавателям:");
                    SqlCommand cmd3 = new SqlCommand( queryTeacherHours, conn);
                    using (SqlDataReader reader = cmd3.ExecuteReader())
                    {
                        string currentYear = "";
                        while (reader.Read())
                        { 
                            string year = reader["Год"].ToString();
                            if ( year != currentYear)
                            {
                                currentYear = year;
                                sb.AppendLine();
                                sb.AppendLine($"{year}:");
                            }
                            string fio = reader["ФИО"].ToString();
                            string sub = reader["Предметы"].ToString();
                            int hours = Convert.ToInt32(reader["Часы"]);
                            sb.AppendLine($"{fio} - {sub}: {hours} ч.");
                        }
                    }
                    sb.AppendLine("Преподаватели с экзаменнами:");
                    SqlCommand cmd4 = new SqlCommand(queryExamTeachers, conn);
                    using (SqlDataReader reader = cmd4.ExecuteReader())
                    {
                        string currentYear2 = "";
                        while (reader.Read())
                        {
                            string year = reader["Год"].ToString();
                            if (year != currentYear2)
                            {
                                currentYear2 = year;
                                sb.AppendLine();
                                sb.AppendLine($"{year}:");
                            }
                            string fio = reader["ФИО"].ToString();
                            string sub = reader["Предметы"].ToString();
                            sb.AppendLine($"{fio} - {sub}");
                        }
                    }
                }
            }
            catch (Exception ex) { sb.AppendLine("Ошибка расчета: " + ex.Message); }

            resultRichTextBox.Text = sb.ToString();
        }

        private void LoadAchievementsStats()
        {
            titleLabel.Text = "Распределение зарегистрированных достижений \nпо их уровням статуса.";
            StringBuilder sb = new StringBuilder();

            string query = @"SELECT lt.namen AS LevelName, COUNT(a.id) AS CountAchi
                             FROM level_types lt
                             LEFT JOIN achievements a ON lt.id = a.level_id
                             GROUP BY lt.id, lt.namen;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string lvl = reader["LevelName"].ToString();
                            int count = Convert.ToInt32(reader["CountAchi"]);
                            sb.AppendLine($"▪️ {lvl} уровень: {count} шт.");
                        }
                    }
                }
            }
            catch (Exception ex) { sb.AppendLine("Ошибка расчета: " + ex.Message); }

            resultRichTextBox.Text = sb.ToString();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            main.loadpanel(new MainChoices(main, currentTab));
        }
    }
}
