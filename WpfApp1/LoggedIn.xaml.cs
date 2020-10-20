using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Lógica de interacción para LoggedIn.xaml
    /// </summary>
    public partial class LoggedIn : Window
    {
        private User currentUser;

        private Book currentBookEditing;

        public LoggedIn( User loggedInUser)
        {
            InitializeComponent();

            currentUser = loggedInUser;

            UserName.Text = currentUser.username;

            HomePanel.Visibility = Visibility.Visible;

            GithubPanel.Visibility = Visibility.Hidden;

            BooksPanel.Visibility = Visibility.Hidden;

            UserPanel.Visibility = Visibility.Hidden;


            if (currentUser.role.Equals("admin"))
                UserContentMenu.Visibility = Visibility.Visible;



            List<Book> items = DatabaseManagement.instance.Books.Find(x => true).ToList<Book>();
            List<User> users = DatabaseManagement.instance.Users.Find(x => true).ToList<User>();

            

            lvBooks.ItemsSource = items;
            lvUsers.ItemsSource = users;
           
            

        }
        
        public void UpdateBookList()
        {
            List<Book> items = DatabaseManagement.instance.Books.Find(x => true).ToList<Book>();
            lvBooks.ItemsSource = items;
        }

        public void UpdateUserList()
        {
            List<User> users = DatabaseManagement.instance.Users.Find(x => true).ToList<User>();
            lvUsers.ItemsSource = users;
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }
        private async void Logout()
        {
            
            MainWindow logout = new MainWindow();
            LoggedOut.IsOpen = true;
            await Task.Delay(1000);
            LoggedOut.IsOpen = false;
            logout.Show();    
            this.Close();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GithubContent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BooksPanel.Visibility = Visibility.Hidden;
            HomePanel.Visibility = Visibility.Hidden;
            UserPanel.Visibility = Visibility.Hidden;

            if (GithubPanel.Visibility != Visibility.Visible)
                GithubPanel.Visibility = Visibility.Visible;
        }

        private void HomeContent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BooksPanel.Visibility = Visibility.Hidden;
            GithubPanel.Visibility = Visibility.Hidden;
            UserPanel.Visibility = Visibility.Hidden;

            if (HomePanel.Visibility != Visibility.Visible)
                HomePanel.Visibility = Visibility.Visible;
            
        }


        private void BooksContent_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GithubPanel.Visibility = Visibility.Hidden;
            HomePanel.Visibility = Visibility.Hidden;
            UserPanel.Visibility = Visibility.Hidden;

            if (BooksPanel.Visibility != Visibility.Visible)
                BooksPanel.Visibility = Visibility.Visible;
        }

        private void UserContent_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BooksPanel.Visibility = Visibility.Hidden;
            GithubPanel.Visibility = Visibility.Hidden;
            HomePanel.Visibility = Visibility.Hidden;

            if (UserPanel.Visibility != Visibility.Visible)
                UserPanel.Visibility = Visibility.Visible;

        }

        private void AddUser_Button_Click(object sender, RoutedEventArgs e)
        {
            AddUser addUser = new AddUser(this);
            addUser.Show();
            WindowState = WindowState.Minimized;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void AddBook_Button_Click(object sender, RoutedEventArgs e)
        {
            AddBook addBook = new AddBook(this);
            addBook.Show();
            WindowState = WindowState.Minimized;
        }

        private void DeleteUser_Button_Click(object sender, RoutedEventArgs e)
        {
            var curItem = ((ListBoxItem)lvUsers.ContainerFromElement((Button)sender));
            User user = (User)curItem.DataContext;

            DatabaseManagement.instance.Users.DeleteOne(a => a.username.Equals(user.username));

            UpdateUserList();
        }

        private void ChangeUser_Button_Click(object sender, RoutedEventArgs e)
        {
            var curItem = ((ListBoxItem)lvUsers.ContainerFromElement((Button)sender));
            User user = (User)curItem.DataContext;
            string role = user.role.Equals("user") ? "admin" : "user";
            var update = Builders<User>.Update.Set(p => p.role,role);
            
            DatabaseManagement.instance.Users.UpdateOne<User>(x => x.username.Equals(user.username), update );

            UpdateUserList();
        }

        private void ActionBookButtons_Loaded(object sender, RoutedEventArgs e)
        {
            StackPanel sp = (StackPanel)sender;
            var curItem = ((ListBoxItem)lvBooks.ContainerFromElement((StackPanel)sender));
            Book book = (Book)curItem.DataContext;

            

            foreach (Button child in sp.Children)
            {
                string childname = (child as FrameworkElement).Name;

                if (childname.Equals("RentBook_Button") && book.isRented)
                {
                    if (book.userRented.Equals(currentUser.username))
                        child.Content = "Return";
                    else
                        child.IsEnabled = false;
                }

                if (childname.Equals("DeleteBook_Button") && currentUser.role.Equals("admin"))
                    child.Visibility = Visibility.Visible;
                if (childname.Equals("EditBook_Button") && currentUser.role.Equals("admin"))
                    child.Visibility = Visibility.Visible;
            }
        }

        private void RentBook_Button_Click(object sender, RoutedEventArgs e)
        {
            var curItem = ((ListBoxItem)lvBooks.ContainerFromElement((Button)sender));
            Book book = (Book)curItem.DataContext;
            UpdateDefinition<Book> update;
            if (!book.isRented)
                update = Builders<Book>.Update.Set(p => p.isRented, true).Set(p => p.userRented, currentUser.username);
            else
            {
                update = Builders<Book>.Update.Set(p => p.isRented, false).Set(p => p.userRented, "");
                curItem.Content = "Rent";
                curItem.IsEnabled = true;
            }

            DatabaseManagement.instance.Books.UpdateOne<Book>(x => x.title.Equals(book.title), update);

            UpdateBookList();
        }

        private void PanelAddBook_Loaded(object sender, RoutedEventArgs e)
        {
            StackPanel sp = (StackPanel)sender;

            foreach (Button child in sp.Children)
            { 
                if (currentUser.role.Equals("user"))
                {
                    child.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void DeleteBook_Button_Click(object sender, RoutedEventArgs e)
        {
            var curItem = ((ListBoxItem)lvBooks.ContainerFromElement((Button)sender));
            Book book = (Book)curItem.DataContext;

            DatabaseManagement.instance.Books.DeleteOne(a => a.title.Equals(book.title));

            UpdateBookList();
        }
        private void EditBook_Button_Click(object sender, RoutedEventArgs e)
        {
            EditBookContent.IsOpen = true;

            var curItem = ((ListBoxItem)lvBooks.ContainerFromElement((Button)sender));
            Book book = (Book)curItem.DataContext;

            currentBookEditing = book;

            EditTitle_txt.Text = book.title;
            EditUserRented_txt.Text = book.userRented;
            EditPublisher_txt.Text = book.publisher;
            
            
            foreach(ComboBoxItem item in RentedPicker.Items)
            {
                if (item.Content.Equals(book.isRented.ToString().ToLower()))
                    RentedPicker.SelectedItem = item;
            }

            

        }

        private void CancelEdit_Click(object sender, RoutedEventArgs e)
        {
            EditBookContent.IsOpen = false;
        }

        private void SaveEdit_Click(object sender, RoutedEventArgs e)
        {
            if (RentedPicker.Text.Equals("false"))
                EditUserRented_txt.Text = "";
            UpdateDefinition<Book> update = Builders<Book>.Update
                .Set(p => p.isRented, Convert.ToBoolean(RentedPicker.Text))
                .Set(p => p.userRented, EditUserRented_txt.Text)
                .Set(p => p.title, EditTitle_txt.Text)
                .Set(p => p.publisher, EditPublisher_txt.Text);

            DatabaseManagement.instance.Books.UpdateOne<Book>(x => x.id.Equals(currentBookEditing.id), update);

            UpdateBookList();

            EditBookContent.IsOpen = false;
        }
    }
}
