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
        private int _noOfErrorsOnScreen = 0;

        public AddUserWindow(Window window)
        {
            InitializeComponent();
            this.userTask = new UserTask();
            this.user = new User();
            this.userTask.User = this.user;
            canvasUser.DataContext = this.userTask.User;
            dtpUser.DisplayDate = DateTime.Today;
            dtpUser.DisplayDateStart = new DateTime(1925, 1, 1);
            dtpUser.DisplayDateEnd = DateTime.Today;


        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                _noOfErrorsOnScreen++;
            else
                _noOfErrorsOnScreen--;
        }

        private void AddUser_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _noOfErrorsOnScreen == 0;
            e.Handled = true;
        }

        private void AddUser_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            
            this.userTask.save(this.user);
            e.Handled = true;
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
