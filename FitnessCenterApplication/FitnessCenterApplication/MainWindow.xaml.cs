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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace FitnessCenterApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static DataTable Select(string selectSQL) // подключение к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");

            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=FitnessCenter; Integrated Security=True");
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = selectSQL;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dataTable);
            return dataTable;

        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (LogInTextBox.Text.Length > 0) // проверяем введён ли логин     
            {
                if (PasswordTextBox.Text.Length > 0) // проверяем введён ли пароль         
                {   // ищем в базе данных пользователя с такими данными         
                    DataTable dt_admin = Select("SELECT * FROM [dbo].[Administrators] WHERE [Login] = '" + LogInTextBox.Text + "' AND [Password] = '" + PasswordTextBox.Text + "'");

                    if (dt_admin.Rows.Count > 0) // если такая запись существует       
                    {
                        Window1 window1 = new Window1();
                        window1.Show();
                        this.LogInWindow.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!"); // выводим ошибку 
                    }  
                }
                else
                {
                    MessageBox.Show("Введите пароль!"); // выводим ошибку    
                }
                    
            }
            else
            {
                MessageBox.Show("Введите логин!"); // выводим ошибку 
            }
                

        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            if (LogInTextBox.Text.Length > 0) // проверяем введён ли логин     
            {
                if (PasswordTextBox.Text.Length > 0) // проверяем введён ли пароль         
                {   // ищем в базе данных пользователя с такими данными         
                    DataTable dt_user = Select("SELECT * FROM [dbo].[Clients] WHERE [Login] = '" + LogInTextBox.Text + "' AND [Password] = '" + PasswordTextBox.Text + "'");

                    if (dt_user.Rows.Count > 0) // если такая запись существует       
                    {
                        Window10 window10 = new Window10();
                        window10.Show();
                        this.LogInWindow.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!\nИли же такой пользователь не зарегистрирован."); // выводим ошибку 
                    }
                }
                else
                {
                    MessageBox.Show("Введите пароль!"); // выводим ошибку    
                }

            }
            else
            {
                MessageBox.Show("Введите логин!"); // выводим ошибку 
            }
        }


    }
}
