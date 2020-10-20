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
    /// Lógica de interacción para AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        private LoggedIn windowLogged;
        public AddBook(LoggedIn window)
        {
            InitializeComponent();

            windowLogged = window;
        }

        /**
         * Close the window and reopens the logged in window.
         */
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            windowLogged.WindowState = WindowState.Normal;
        }

        /**
         * Check if already exits a book with this title and save a new user otherwise.
         */
        private void InsertBook(object sender, RoutedEventArgs e)
        {
            try
            {
                Book book = DatabaseManagement.instance.Books.Find(x => x.title.Equals(Title_txt.Text)).Single<Book>();

                ShowErrorMessage(false, "This title already exits, please change the title");


            }
            catch (Exception)
            {

                    Book newBook = new Book()
                    {
                     title = Title_txt.Text,
                     publisher = Publisher_txt.Text,
                     isRented = false,
                     userRented = "",
                    };

                    DatabaseManagement.instance.Books.InsertOne(newBook);
                    ShowErrorMessage(true, "Successfully added a new Book");
                    windowLogged.UpdateBookList();
                
            }


        }

        /**
         * Shows the dialog content with the message in "message" for 1 second.
         */
        private async void ShowErrorMessage(bool isLogged, String message)
        {
            AddBook_Failed_Text.Text = message;
            AddBook_Failed.Visibility = Visibility.Visible;
            await Task.Delay(1000);
            AddBook_Failed.Visibility = Visibility.Collapsed;

            if (isLogged)
            {
                this.Close();
                windowLogged.WindowState = WindowState.Normal;
            }
        }




    }
}
