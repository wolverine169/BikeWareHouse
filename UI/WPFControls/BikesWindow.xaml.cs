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
    /// Interaction logic for BikesWindow.xaml
    /// </summary>
    public partial class BikesWindow : Window
    {
        public BikesWindow()
        {
            InitializeComponent();
        }

        private void AddBikeButtonClick(object sender, RoutedEventArgs e)
        {
            //Window newForm = new UsersWindow();

            //newForm.Show();

        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            Window currentForm = this;
            currentForm.Close();

        }
    }
}
