using BikeWarehouse.Domain;
using BikeWareHouse.Tasks;
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

namespace UI.WPFControls
{
    /// <summary>
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
       
        public UsersWindow()
        {
            InitializeComponent();
            UserTask ust = new UserTask();
            List<User> userList = new List<User>();
            userList = ust.Users();
            lstUsers.ItemsSource = userList;
        }

        private void AddUserButtonClick(object sender, RoutedEventArgs e)
        {
            Window newForm = new AddUserWindow(this);
            newForm.ShowDialog();
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            Window currentForm = this;
            currentForm.Close();

        }
    }
}
