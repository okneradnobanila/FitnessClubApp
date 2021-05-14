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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
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

                string query = $"SELECT TOP (1000) [ID_card], [ID_client], [ID_abonnement], [StartDate], [EndDate] FROM [FitnessCenter].[dbo].[AbonnementsSales]";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                dt.NewRow();

                adapter.Fill(dt);

                AbonnementsSalesDataGrid.ItemsSource = dt.DefaultView;
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
                int client = Convert.ToInt32(Client_tb.Text);
                int abon = Convert.ToInt32(Abon_tb.Text);
                string start = Start_tb.Text;
                string end = End_tb.Text;

                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string cmdTxt = $"INSERT INTO AbonnementsSales (ID_card, ID_client, ID_abonnement, StartDate, EndDate) VALUES ('{id}', '{client}', '{abon}',  '{start}',  '{end}')";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nВставлено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_tb.Clear(); Client_tb.Clear(); Abon_tb.Clear(); Start_tb.Clear(); End_tb.Clear();

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
                string cmdTxt = $"DELETE FROM AbonnementsSales WHERE ID_card = '{id}'";
                SqlCommand command = new SqlCommand(cmdTxt, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!\nУдалено объектов: " + number, "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);

                ID_tb.Clear(); Client_tb.Clear(); Abon_tb.Clear(); Start_tb.Clear(); End_tb.Clear();
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
                int client = Convert.ToInt32(Client_tb.Text);
                int abon = Convert.ToInt32(Abon_tb.Text);
                string start = Start_tb.Text;
                string end = End_tb.Text;

                int newid = Convert.ToInt32(NewID_tb.Text);
                int newclient = Convert.ToInt32(NewClient_tb.Text);
                int newabon = Convert.ToInt32(NewAbon_tb.Text);
                string newstart = NewStart_tb.Text;
                string newend = NewEnd_tb.Text;


                string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = FitnessCenter; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string cmdTxt1 = $"UPDATE AbonnementaSales SET ID_client = '{newclient}'  WHERE ID_card = '{id}'";
                SqlCommand command1 = new SqlCommand(cmdTxt1, connection);
                string cmdTxt2 = $"UPDATE AbonnementsSales SET ID_abonnement = '{newabon}'  WHERE ID_card = '{id}'";
                SqlCommand command2 = new SqlCommand(cmdTxt2, connection);
                string cmdTxt3 = $"UPDATE AbonnemensSales SET StartDate = '{newstart}'  WHERE ID_card = '{id}'";
                SqlCommand command3 = new SqlCommand(cmdTxt3, connection);
                string cmdTxt4 = $"UPDATE AbonnemensSales SET EndDate = '{newend}'  WHERE ID_card = '{id}'";
                SqlCommand command4 = new SqlCommand(cmdTxt4, connection);


                command1.ExecuteNonQuery(); command2.ExecuteNonQuery(); command3.ExecuteNonQuery(); command4.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены успешно!", "Статус действия", MessageBoxButton.OK, MessageBoxImage.Information);


                ID_tb.Clear(); Client_tb.Clear(); Abon_tb.Clear(); Start_tb.Clear(); End_tb.Clear();
                NewID_tb.Clear(); NewClient_tb.Clear(); NewAbon_tb.Clear(); NewStart_tb.Clear(); NewEnd_tb.Clear();
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
