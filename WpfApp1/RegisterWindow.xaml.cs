using MongoDB.Driver;
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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SignUp(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = DatabaseManagement.instance.Users.Find(x => x.username.Equals(UserName_txt.Text)).Single<User>();

                ShowErrorMessage(false, "This user already exits, please change the username");


            }
            catch(Exception )
            {
                if (Password1_txt.Password.Equals(Password2_txt.Password)) {
                    User newUser = new User()
                    {
                        username = UserName_txt.Text,
                        password = Password1_txt.Password,
                        role = "user",
                    };

                    DatabaseManagement.instance.Users.InsertOne(newUser);
                    ShowErrorMessage(true, "Successfully registered");
                }
                else
                {
                    ShowErrorMessage(false, "Passwords do not match");
                }
            }
            

        }

        private async void ShowErrorMessage(bool isLogged, String message)
        {
            SignUp_Failed_Text.Text = message;
            SignUp_Failed.Visibility = Visibility.Visible;
            await Task.Delay(1000);
            SignUp_Failed.Visibility = Visibility.Collapsed;

            if (isLogged)
                this.Close();
        }

    }
}
