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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
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

                string query = $"SELECT TOP (1000) [ID_lesson], [Date], [StartTime], [EndTime], [ID_class], [ID_room], [ID_trainer], [Information] FROM [FitnessCenter].[dbo].[Schedule]";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                dt.NewRow();

                adapter.Fill(dt);

                ScheduleDataGrid.ItemsSource = dt.DefaultView;
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
                int id = Convert.ToInt32(ID_tb.Text);
                string date = Date_tb.Text;
                string start = Start_tb.Text;
                string end = End_tb.Text;
                int clas = Convert.ToInt32(Class_tb.Text);
                int room = Convert.ToInt32(Room_tb.Text);               
                int trainer = Convert.ToInt32(Trainer_tb.Text);
                string info = Info_tb.Text;

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string cmdTxt = $"INSERT INTO Schedule (ID_lesson, Date, StartTime, EndTime, ID_class, ID_room, ID_trainer, Information) VALUES ('{id}', '{date}', '{start}',  '{end}',  '{clas}',  '{room}',  '{trainer}',  '{info}')";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nВставлено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_tb.Clear(); Date_tb.Clear(); Start_tb.Clear(); End_tb.Clear(); Class_tb.Clear(); Room_tb.Clear(); Trainer_tb.Clear(); Info_tb.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ID_tb.Text);
                string date = Date_tb.Text;
                string start = Start_tb.Text;
                string end = End_tb.Text;
                int clas = Convert.ToInt32(Class_tb.Text);
                int room = Convert.ToInt32(Room_tb.Text);
                int trainer = Convert.ToInt32(Trainer_tb.Text);
                string info = Info_tb.Text;

                int newid = Convert.ToInt32(NewID_tb.Text);
                string newdate = NewDate_tb.Text;
                string newstart = NewStart_tb.Text;
                string newend = NewEnd_tb.Text;
                int newclas = Convert.ToInt32(NewClass_tb.Text);
                int newroom = Convert.ToInt32(NewRoom_tb.Text);
                int newtrainer = Convert.ToInt32(NewTrainer_tb.Text);
                string newinfo = NewInfo_tb.Text;


                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string cmdTxt1 = $"UPDATE Schedule SET Date = '{newdate}'  WHERE ID_lesson = '{id}'";
                SqlCommand command1 = new SqlCommand(cmdTxt1, connection);
                string cmdTxt2 = $"UPDATE Schedule SET StartTime = '{newstart}'  WHERE ID_lesson = '{id}'";
                SqlCommand command2 = new SqlCommand(cmdTxt2, connection);
                string cmdTxt3 = $"UPDATE Schedule SET EndTime = '{newend}'  WHERE ID_lesson = '{id}'";
                SqlCommand command3 = new SqlCommand(cmdTxt3, connection);
                string cmdTxt4 = $"UPDATE Schedule SET ID_class = '{newclas}'  WHERE ID_lesson = '{id}'";
                SqlCommand command4 = new SqlCommand(cmdTxt4, connection);
                string cmdTxt5 = $"UPDATE Schedule SET ID_class = '{newclas}'  WHERE ID_lesson = '{id}'";
                SqlCommand command5 = new SqlCommand(cmdTxt5, connection);
                string cmdTxt6 = $"UPDATE Schedule SET ID_class = '{newclas}'  WHERE ID_lesson = '{id}'";
                SqlCommand command6 = new SqlCommand(cmdTxt6, connection);
                string cmdTxt7 = $"UPDATE Schedule SET ID_class = '{newclas}'  WHERE ID_lesson = '{id}'";
                SqlCommand command7 = new SqlCommand(cmdTxt7, connection);


                command1.ExecuteNonQuery(); command2.ExecuteNonQuery(); command3.ExecuteNonQuery(); command4.ExecuteNonQuery();
                command5.ExecuteNonQuery(); command6.ExecuteNonQuery(); command7.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!", "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);


                ID_tb.Clear(); Date_tb.Clear(); Start_tb.Clear(); End_tb.Clear(); Class_tb.Clear(); Room_tb.Clear(); Trainer_tb.Clear(); Info_tb.Clear();
                NewID_tb.Clear(); NewDate_tb.Clear(); NewStart_tb.Clear(); NewEnd_tb.Clear(); NewClass_tb.Clear(); NewRoom_tb.Clear(); NewTrainer_tb.Clear(); NewInfo_tb.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ID_tb.Text);

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string cmdTxt = $"DELETE FROM Schedule WHERE ID_lesson = '{id}'";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nУдалено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_tb.Clear(); Date_tb.Clear(); Start_tb.Clear(); End_tb.Clear(); Class_tb.Clear(); Room_tb.Clear(); Trainer_tb.Clear(); Info_tb.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
