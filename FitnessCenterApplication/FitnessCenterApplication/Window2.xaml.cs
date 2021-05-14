using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace FitnessCenterApplication
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = $"SELECT TOP (1000) [ID_num], [ID_lesson], [ID_card] FROM [FitnessCenter].[dbo].[AttendanceRegister]";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt_attendance = new DataTable();

                dt_attendance.NewRow();

                adapter.Fill(dt_attendance);

                AttendanceDataGrid.ItemsSource = dt_attendance.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id_num = Convert.ToInt32(Add_ID_num_TextBox.Text);
                int id_lesson = Convert.ToInt32(Add_ID_lesson_TextBox.Text);
                int id_card = Convert.ToInt32(Add_ID_card_TextBox.Text);

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string cmdTxt = $"INSERT INTO AttendanceRegister (ID_num, ID_lesson, ID_card) VALUES ('{id_num}', '{id_lesson}', '{id_card}')";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nВставлено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                Add_ID_num_TextBox.Clear(); Add_ID_lesson_TextBox.Clear(); Add_ID_card_TextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                Add_ID_num_TextBox.Clear(); Add_ID_lesson_TextBox.Clear(); Add_ID_card_TextBox.Clear();
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int old_id_num = Convert.ToInt32(Original_ID_num_TextBox.Text);
                int old_id_lesson = Convert.ToInt32(Original_ID_lesson_TextBox.Text);
                int old_id_card = Convert.ToInt32(Original_ID_card_TextBox.Text);

                int new_id_num = Convert.ToInt32(Changed_ID_num_TextBox.Text);
                int new_id_lesson = Convert.ToInt32(Changed_ID_lesson_TextBox.Text);
                int new_id_card = Convert.ToInt32(Changed_ID_card_TextBox.Text);

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string cmdTxt = $"UPDATE AttendanceRegister SET ID_lesson = '{new_id_lesson}'  WHERE ID_num = '{old_id_num}'";

                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nОбновлено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                Original_ID_num_TextBox.Clear(); Original_ID_lesson_TextBox.Clear(); Original_ID_card_TextBox.Clear();
                Changed_ID_num_TextBox.Clear(); Changed_ID_lesson_TextBox.Clear(); Changed_ID_card_TextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                Original_ID_num_TextBox.Clear(); Original_ID_lesson_TextBox.Clear(); Original_ID_card_TextBox.Clear();
                Changed_ID_num_TextBox.Clear(); Changed_ID_lesson_TextBox.Clear(); Changed_ID_card_TextBox.Clear();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id_num = Convert.ToInt32(Delete_ID_num_TextBox.Text);
                int id_lesson = Convert.ToInt32(Delete_ID_lesson_TextBox.Text);
                int id_card = Convert.ToInt32(Delete_ID_card_TextBox.Text);

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE  FROM AttendanceRegister  WHERE ID_num = '{id_num}'", connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nУдалено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                Delete_ID_num_TextBox.Clear(); Delete_ID_lesson_TextBox.Clear(); Delete_ID_card_TextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                Delete_ID_num_TextBox.Clear(); Delete_ID_lesson_TextBox.Clear(); Delete_ID_card_TextBox.Clear();
            }
        }

        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Параметры 'IDnum' и 'IDcard' недоступны для изменения.", "Справка", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
