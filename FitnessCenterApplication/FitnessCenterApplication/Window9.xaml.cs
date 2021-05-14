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
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public Window9()
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

                string query = $"SELECT TOP (1000) [ID_admin], [Login], [Password] FROM [FitnessCenter].[dbo].[Administrators]";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                dt.NewRow();

                adapter.Fill(dt);

                AdministratorsDataGrid.ItemsSource = dt.DefaultView;
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ID_tb.Text);
                string login = Login_tb.Text;
                string pass = Password_tb.Text;

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string cmdTxt = $"INSERT INTO Administrators (ID_admin, Login, Password) VALUES ('{id}', '{login}', '{pass}')";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nВставлено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_tb.Clear(); Login_tb.Clear(); Password_tb.Clear();
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
                string login = Login_tb.Text;
                string pass = Password_tb.Text;

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand($"DELETE  Administrators  WHERE ID_admin = '{id}'", connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nУдалено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_tb.Clear(); Login_tb.Clear(); Password_tb.Clear();
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
                string login = Login_tb.Text;
                string pass = Password_tb.Text;

                int newid = Convert.ToInt32(ID_tb_Copy.Text);
                string newlogin = Login_tb_Copy.Text;
                string newpass = Password_tb_Copy.Text;

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string cmdTxt1 = $"UPDATE Administrators SET Login = '{newlogin}'  WHERE ID_admin = '{id}'";
                SqlCommand command1 = new SqlCommand(cmdTxt1, connection);
                string cmdTxt2 = $"UPDATE Administrators SET Password = '{newpass}'  WHERE ID_admin = '{id}'";
                SqlCommand command2 = new SqlCommand(cmdTxt2, connection);

                command1.ExecuteNonQuery(); command2.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!", "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_tb.Clear(); Login_tb.Clear(); Password_tb.Clear();
                ID_tb_Copy.Clear(); Login_tb_Copy.Clear(); Password_tb_Copy.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
