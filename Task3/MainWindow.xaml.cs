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

namespace Task3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boolean login = Service.Autorization.loginMethod(TextLogin.Text.Trim());
            Boolean password = Service.Autorization.loginMethod(TextPassword.Text.Trim());

            if(login == false)
            {
                MessageBox.Show("Не верный логин");
            }
            if(password == false)
            {
                MessageBox.Show("Не верный пароль");
            }
            if(login == true && password == true)
            {
              MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
              mainWindow.Hide();
                ListClients listClients = new ListClients();
                listClients.Show();
            }
        }
    }
}
