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
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        private User user;
        private UserTask userTask;
        public AddUserWindow(Window window)
        {
            InitializeComponent();
            this.userTask = new UserTask();
            this.user = new User();
            this.userTask.User = this.user;
            canvasUser.DataContext = this.userTask.User;
        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {
            
            this.userTask.save(this.user);
            Window currentForm = this;
            currentForm.Close();
        }

        private void btnCancelAddUser_Click(object sender, RoutedEventArgs e)
        {
            Window currentForm = this;
            currentForm.Close();
        }
    }
}
