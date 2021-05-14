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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
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

                string query = $"SELECT TOP (1000) [ID_trainer], [Surname] ,[Name], [Patronymic], [DateOfBirth], [Address], [PhoneNumber], [Salary], [Specialization] FROM [FitnessCenter].[dbo].[Trainers]";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                dt.NewRow();

                adapter.Fill(dt);

                TrainersDataGrid.ItemsSource = dt.DefaultView;
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
                string surname = Surname_tb.Text;
                string name = Name_tb.Text;
                string patronym = Patronym_tb.Text;
                string date = Date_tb.Text;
                string adres = Adres_tb.Text;
                string phone = Phone_tb.Text;
                string salary = Salary_tb.Text;
                string spec = Spec_tb.Text;

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string cmdTxt = $"INSERT INTO Trainers (ID_trainer, Surname, Name, Patronymic, DateOfBirth, Address, PhoneNumber, Salary, Specialization) VALUES ('{id}', '{surname}', '{name}',  '{patronym}',  '{date}',  '{adres}',  '{phone}',  '{salary}',  '{spec}')";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nВставлено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_tb.Clear(); Date_tb.Clear(); Name_tb.Clear(); Patronym_tb.Clear(); Adres_tb.Clear(); Phone_tb.Clear(); Salary_tb.Clear(); Spec_tb.Clear(); Surname_tb.Clear();

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
                string surname = Surname_tb.Text;
                string name = Name_tb.Text;
                string patronym = Patronym_tb.Text;
                string date = Date_tb.Text;
                string adres = Adres_tb.Text;
                string phone = Phone_tb.Text;
                string salary = Salary_tb.Text;
                string spec = Spec_tb.Text;

                int newid = Convert.ToInt32(ID_tb_Copy.Text);
                string newsurname = Surname_tb_Copy.Text;
                string newname = Name_tb_Copy.Text;
                string newpatronym = Patronym_tb_Copy.Text;
                string newdate = Date_tb_Copy.Text;
                string newadres = Adres_tb_Copy.Text;
                string newphone = Phone_tb_Copy.Text;
                string newsalary = Salary_tb_Copy.Text;
                string newspec = Spec_tb_Copy.Text;


                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string cmdTxt1 = $"UPDATE Trainers SET Surname = '{newsurname}'  WHERE ID_trainer = '{id}'";
                SqlCommand command1 = new SqlCommand(cmdTxt1, connection);
                string cmdTxt2 = $"UPDATE Trainers SET Name = '{newname}'  WHERE ID_trainer = '{id}'";
                SqlCommand command2 = new SqlCommand(cmdTxt2, connection);
                string cmdTxt3 = $"UPDATE Trainers SET Patronymic = '{newpatronym}'  WHERE ID_trainer = '{id}'";
                SqlCommand command3 = new SqlCommand(cmdTxt3, connection);
                string cmdTxt4 = $"UPDATE Trainers SET DateOfBirth = '{newdate}'  WHERE ID_trainer = '{id}'";
                SqlCommand command4 = new SqlCommand(cmdTxt4, connection);
                string cmdTxt5 = $"UPDATE Trainers SET Address = '{newadres}'  WHERE ID_trainer = '{id}'";
                SqlCommand command5 = new SqlCommand(cmdTxt5, connection);
                string cmdTxt6 = $"UPDATE Trainers SET PhoneNumber = '{newphone}'  WHERE ID_trainer = '{id}'";
                SqlCommand command6 = new SqlCommand(cmdTxt6, connection);
                string cmdTxt7 = $"UPDATE Trainers SET Salary = '{newsalary}'  WHERE ID_trainer = '{id}'";
                SqlCommand command7 = new SqlCommand(cmdTxt7, connection);
                string cmdTxt8 = $"UPDATE Trainers SET Specialization = '{newspec}'  WHERE ID_trainer = '{id}'";
                SqlCommand command8 = new SqlCommand(cmdTxt8, connection);


                command1.ExecuteNonQuery(); command2.ExecuteNonQuery(); command3.ExecuteNonQuery(); command4.ExecuteNonQuery();
                command5.ExecuteNonQuery(); command6.ExecuteNonQuery(); command7.ExecuteNonQuery(); command8.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!", "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);


                ID_tb.Clear(); Date_tb.Clear(); Name_tb.Clear(); Patronym_tb.Clear(); Adres_tb.Clear(); Phone_tb.Clear(); Salary_tb.Clear(); Spec_tb.Clear(); Surname_tb.Clear();
                ID_tb_Copy.Clear(); Date_tb_Copy.Clear(); Name_tb_Copy.Clear(); Patronym_tb_Copy.Clear(); Adres_tb_Copy.Clear(); Phone_tb_Copy.Clear(); Salary_tb_Copy.Clear(); Spec_tb_Copy.Clear(); Surname_tb_Copy.Clear();
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
                string cmdTxt = $"DELETE FROM Trainers WHERE ID_trainer = '{id}'";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nУдалено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_tb.Clear(); Date_tb.Clear(); Name_tb.Clear(); Patronym_tb.Clear(); Adres_tb.Clear(); Phone_tb.Clear(); Salary_tb.Clear(); Spec_tb.Clear(); Surname_tb.Clear();
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
