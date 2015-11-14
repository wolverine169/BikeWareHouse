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
using UI.WPFControls;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UsersClick(object sender, RoutedEventArgs e)
        {
            Window newForm = new UsersWindow();

            newForm.Show();

        }

        private void BikesClick(object sender, RoutedEventArgs e)
        {
            Window newForm = new BikesWindow();

            newForm.Show();

        }

        private void PartsClick(object sender, RoutedEventArgs e)
        {
            Window newForm = new PartsWindow();

            newForm.Show();

        }

        private void ToolsClick(object sender, RoutedEventArgs e)
        {
            Window newForm = new ToolsWindow();

            newForm.Show();

        }
    }
}
