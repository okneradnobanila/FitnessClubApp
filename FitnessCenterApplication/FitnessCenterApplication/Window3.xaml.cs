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
using System.Globalization;

namespace FitnessCenterApplication
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
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

                string query = $"SELECT TOP (1000) [ID_client], [Surname], [Name], [Patronymic], [PhoneNumber], [DateOfBirth], [Address], [Login], [Password] FROM [FitnessCenter].[dbo].[Clients]";
                 
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                dt.NewRow();

                adapter.Fill(dt);

                ClientsDataGrid.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void InfoItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Изменение и удаление данных производится через 'ID' клиента.\nПараметры 'ID', 'Login' и 'Password' для изменения недоступенs.", "Справка", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ID_textbox.Text);
                string surname = Surname_textbox.Text;
                string name = Name_textbox.Text;
                string patronymic = Patronymic_textbox.Text;
                string phone = Phone_textbox.Text;
                string data = DataBirth_textbox.Text;
                string adres = Address_textbox.Text;
                string login = Login_textbox.Text;
                string password = Password_textbox.Text;

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string cmdTxt = $"INSERT INTO Clients (ID_client, Surname, Name, Patronymic, PhoneNumber, DateOfBirth, Address, Login, Password) VALUES ('{id}', '{surname}', '{name}', '{patronymic}', '{phone}', '{data}', '{adres}', '{login}', '{password}')";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nВставлено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_textbox.Clear(); Surname_textbox.Clear(); Name_textbox.Clear(); Patronymic_textbox.Clear();
                Phone_textbox.Clear(); DataBirth_textbox.Clear(); Address_textbox.Clear(); Login_textbox.Clear();
                Password_textbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteClientButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ID_textbox.Text);

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string cmdTxt = $"DELETE FROM Clients WHERE ID_client = '{id}'";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nУдалено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_textbox.Clear(); Surname_textbox.Clear(); Name_textbox.Clear(); Patronymic_textbox.Clear();
                Phone_textbox.Clear(); DataBirth_textbox.Clear(); Address_textbox.Clear(); Login_textbox.Clear();
                Password_textbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void ChangeClientButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int old_id = Convert.ToInt32(ID_textbox.Text);
                string old_surname = Surname_textbox.Text;
                string old_name = Name_textbox.Text;
                string old_patronymic = Patronymic_textbox.Text;
                string old_phone = Phone_textbox.Text;
                string old_data = DataBirth_textbox.Text;
                string old_adres = Address_textbox.Text;
                string old_login = Login_textbox.Text;
                string old_password = Password_textbox.Text;

                int id = Convert.ToInt32(NewID_textbox.Text);
                string surname = NewSurname_textbox.Text;
                string name = NewName_textbox.Text;
                string patronymic = NewPatronymic_textbox.Text;
                string phone = Phone_textbox.Text;
                string data =NewDateBirth_textbox.Text;
                string adres = NewAddress_textbox.Text;
                

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string cmdTxt1 = $"UPDATE Clients SET Surname = '{surname}'  WHERE ID_client = '{old_id}'";
                SqlCommand command1 = new SqlCommand(cmdTxt1, connection);
                string cmdTxt2 = $"UPDATE Clients SET Name = '{name}'  WHERE ID_client = '{old_id}'";
                SqlCommand command2 = new SqlCommand(cmdTxt2, connection);
                string cmdTxt3 = $"UPDATE Clients SET Patronymic = '{patronymic}'  WHERE ID_client = '{old_id}'";
                SqlCommand command3 = new SqlCommand(cmdTxt3, connection);
                string cmdTxt4 = $"UPDATE Clients SET PhoneNumber = '{phone}'  WHERE ID_client = '{old_id}'";
                SqlCommand command4 = new SqlCommand(cmdTxt4, connection);
                string cmdTxt5 = $"UPDATE Clients SET DateOfBirth = '{data}'  WHERE ID_client = '{old_id}'";
                SqlCommand command5 = new SqlCommand(cmdTxt5, connection);
                string cmdTxt6 = $"UPDATE Clients SET Address = '{adres}'  WHERE ID_client = '{old_id}'";
                SqlCommand command6 = new SqlCommand(cmdTxt6, connection);

                command1.ExecuteNonQuery(); command2.ExecuteNonQuery(); command3.ExecuteNonQuery(); command4.ExecuteNonQuery(); command5.ExecuteNonQuery(); command6.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!", "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);


                ID_textbox.Clear(); Surname_textbox.Clear(); Name_textbox.Clear(); Patronymic_textbox.Clear();
                Phone_textbox.Clear(); DataBirth_textbox.Clear(); Address_textbox.Clear(); Login_textbox.Clear();
                Password_textbox.Clear();
                NewID_textbox.Clear(); NewSurname_textbox.Clear(); NewName_textbox.Clear(); NewPatronymic_textbox.Clear();
                NewPhone_textbox.Clear(); NewDateBirth_textbox.Clear(); NewAddress_textbox.Clear(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ReloadIten_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
