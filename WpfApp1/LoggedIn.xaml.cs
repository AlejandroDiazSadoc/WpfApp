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

            ProfilePanel.Visibility = Visibility.Hidden;

            // If user is not admin, doesn't have the option of see the users in the menu.
            if (currentUser.role.Equals("admin"))
                UserContentMenu.Visibility = Visibility.Visible;
            else
                UserContentMenu.Visibility = Visibility.Collapsed;


            List<Book> items = DatabaseManagement.instance.Books.Find(x => true).ToList<Book>();
            List<User> users = DatabaseManagement.instance.Users.Find(x => true).ToList<User>();

            

            lvBooks.ItemsSource = items;
            lvUsers.ItemsSource = users;
           
            

        }
        
        /**
         * Update the listview with the books in the grid.
         */
        public void UpdateBookList()
        {
            List<Book> items = DatabaseManagement.instance.Books.Find(x => true).ToList<Book>();
            lvBooks.ItemsSource = items;
        }
        /**
         * Update the listview with the users in the grid.
         */
        public void UpdateUserList()
        {
            List<User> users = DatabaseManagement.instance.Users.Find(x => true).ToList<User>();
            lvUsers.ItemsSource = users;
        }

        /**
         * Logout the user logged.
         */
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }
        /**
         * Show the dialog content say goodbye to the user and open the main window of login.
         */
        private async void Logout()
        {
            
            MainWindow logout = new MainWindow();
            LoggedOut.IsOpen = true;
            await Task.Delay(1000);
            LoggedOut.IsOpen = false;
            logout.Show();    
            this.Close();
        }

        /**
         * Open the navigation drawer
         */
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }
        /**
         * Close the navigation drawer
         */
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        /**
         * Shutdown the application
         */
        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #region ContentGrid

        /** 
         * In this region, all the functions are related to change the content of the grid "ContentGrid"
         */

        private void GithubContent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BooksPanel.Visibility = Visibility.Hidden;
            HomePanel.Visibility = Visibility.Hidden;
            UserPanel.Visibility = Visibility.Hidden;
            ProfilePanel.Visibility = Visibility.Hidden;

            if (GithubPanel.Visibility != Visibility.Visible)
                GithubPanel.Visibility = Visibility.Visible;
        }

        private void HomeContent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BooksPanel.Visibility = Visibility.Hidden;
            GithubPanel.Visibility = Visibility.Hidden;
            UserPanel.Visibility = Visibility.Hidden;
            ProfilePanel.Visibility = Visibility.Hidden;

            if (HomePanel.Visibility != Visibility.Visible)
                HomePanel.Visibility = Visibility.Visible;
            
        }


        private void BooksContent_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GithubPanel.Visibility = Visibility.Hidden;
            HomePanel.Visibility = Visibility.Hidden;
            UserPanel.Visibility = Visibility.Hidden;
            ProfilePanel.Visibility = Visibility.Hidden;

            if (BooksPanel.Visibility != Visibility.Visible)
                BooksPanel.Visibility = Visibility.Visible;
        }

        private void UserContent_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BooksPanel.Visibility = Visibility.Hidden;
            GithubPanel.Visibility = Visibility.Hidden;
            HomePanel.Visibility = Visibility.Hidden;
            ProfilePanel.Visibility = Visibility.Hidden;

            if (UserPanel.Visibility != Visibility.Visible)
                UserPanel.Visibility = Visibility.Visible;

        }

        private void UserProfile_Click(object sender, RoutedEventArgs e)
        {
            BooksPanel.Visibility = Visibility.Hidden;
            GithubPanel.Visibility = Visibility.Hidden;
            HomePanel.Visibility = Visibility.Hidden;
            UserPanel.Visibility = Visibility.Hidden;

            if (ProfilePanel.Visibility != Visibility.Visible)
            {
                ProfilePanel.Visibility = Visibility.Visible;

                UserNameProfile_txt.Text = currentUser.username;

                PasswordProfile_txt.Text = currentUser.password;

                RoleUserProfile.Text = currentUser.role;
            }


        }

        #endregion

        /**
         * Add a new user to the database showing a new window this its fields.
         */
        private void AddUser_Button_Click(object sender, RoutedEventArgs e)
        {
            AddUser addUser = new AddUser(this);
            addUser.Show();
            WindowState = WindowState.Minimized;
        }

        /**
         * Allow to move the window.
         */
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

        /**
         * Delete the user from the row of the button which activated this function.
         */
        private void DeleteUser_Button_Click(object sender, RoutedEventArgs e)
        {
            var curItem = ((ListBoxItem)lvUsers.ContainerFromElement((Button)sender));
            User user = (User)curItem.DataContext;


            DatabaseManagement.instance.Users.DeleteOne(a => a.username.Equals(user.username));

            UpdateUserList();

            if (user.username.Equals(currentUser.username))
                Logout();

        }

        /**
         * Change the role of the user in the row of the button which activated this function.
         */
        private void ChangeUser_Button_Click(object sender, RoutedEventArgs e)
        {
            var curItem = ((ListBoxItem)lvUsers.ContainerFromElement((Button)sender));
            User user = (User)curItem.DataContext;
            string role = user.role.Equals("user") ? "admin" : "user";
            UpdateDefinition<User> update = Builders<User>.Update.Set(p => p.role,role);
            
            DatabaseManagement.instance.Users.UpdateOne<User>(x => x.username.Equals(user.username), update );

            if (user.username.Equals(currentUser.username))
            {
                currentUser.role = role;
                RefreshWindow(currentUser);
            }
            else
            {
                UpdateUserList();
            }
            
        }

        /**
         * Check if the user logged is the one who has rented the book and change the content of the button,
         * if the book is rented disable the button.
         */
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

        /**
         * Check if the book is Rented or Not in order to make the function of returning the book
         * from the user that has it rented. And if the book is not rented, rent it from the user logged.
         */
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

        /**
         * Check if the user logged is admin or not in order, to let him
         * add new books.
         */
        private void PanelAddBook_Loaded(object sender, RoutedEventArgs e)
        {
            StackPanel sp = (StackPanel)sender;

            foreach (Button child in sp.Children)
            {
                string childname = (child as FrameworkElement).Name;
                if (childname.Equals("AddBook_Button") && currentUser.role.Equals("admin"))
                {
                        
                        child.Visibility = Visibility.Visible;
                }
                else
                {
                    child.Visibility = Visibility.Hidden;
                }
                
            }
        }

        /**
         * 
         * Delete the book of the Database chosen by the row of the button that has been clicked.
         */
        private void DeleteBook_Button_Click(object sender, RoutedEventArgs e)
        {
            var curItem = ((ListBoxItem)lvBooks.ContainerFromElement((Button)sender));
            Book book = (Book)curItem.DataContext;

            DatabaseManagement.instance.Books.DeleteOne(a => a.title.Equals(book.title));

            UpdateBookList();
        }

        /**
         * Action of clicking the button related to the book in the same row. 
         * (Opens the dialog panel to edit of the book).
         */
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

        /**
         * Exit editing the book discarding the changes.
         */
        private void CancelEdit_Click(object sender, RoutedEventArgs e)
        {
            EditBookContent.IsOpen = false;
        }


        /**
         * Saves the new data in the book picked to edit.
         */
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



        /**
         * Check if already exits an user with this username and save a new user otherwise.
         */
        private void SaveUser(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = DatabaseManagement.instance.Users.Find(x => x.username.Equals(UserNameProfile_txt.Text)).Single<User>();

                if (user.username.Equals(currentUser.username))
                {
                    var update = Builders<User>.Update
                    .Set(p => p.username, UserNameProfile_txt.Text)
                    .Set(p => p.password, PasswordProfile_txt.Text);

                    DatabaseManagement.instance.Users.UpdateOne<User>(x => x.id.Equals(currentUser.id), update);

                    currentUser.username = UserNameProfile_txt.Text;
                    currentUser.password = PasswordProfile_txt.Text;

                    

                    ShowErrorMessage("Changes saved");
                    RefreshWindow(currentUser);
                }
                else
                {
                    ShowErrorMessage("This username already exits, please change the username");
                }


            }
            catch (Exception)
            {

                var update = Builders<User>.Update
                    .Set(p => p.username, UserNameProfile_txt.Text)
                    .Set(p => p.password, PasswordProfile_txt.Text);

                DatabaseManagement.instance.Users.UpdateOne<User>(x => x.id.Equals(currentUser.id), update);

                currentUser.username = UserNameProfile_txt.Text;
                currentUser.password = PasswordProfile_txt.Text;

                

                ShowErrorMessage( "Changes saved");

                RefreshWindow(currentUser);
                
            }


        }

        /**
         * Shows the dialog content with the message in "message" for 1 second.
         */
        private async void ShowErrorMessage( String message)
        {
            SaveUser_Failed_Text.Text = message;
            SaveUser_Failed.Visibility = Visibility.Visible;
            await Task.Delay(1000);
            SaveUser_Failed.Visibility = Visibility.Collapsed;

            
        }

        private void RefreshWindow(User current)
        {
            LoggedIn newLoggedIn = new LoggedIn(current);
            newLoggedIn.Show();
            this.Close();
            
        }

    }
}
