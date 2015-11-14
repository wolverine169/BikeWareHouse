using BikeWareHouse.Domain.Reusable;
using System.Windows;
using System.Windows.Controls;

namespace UI.WPFControls.CustomControl
{
    /// <summary>
    /// Interaction logic for DateControl.xaml
    /// </summary>
    public partial class DateControl : UserControl
    {

        private PopulateDate datePopulator;

        public DateControl()
        {
            InitializeComponent();
            this.datePopulator = new PopulateDate();
            cmbDate.ItemsSource = this.datePopulator.DaysOfMonth();
            cmbMonths.ItemsSource = this.datePopulator.MonthsOfYear();
            cmbYear.ItemsSource = this.datePopulator.YearsOfAge();
            cnvDate.DataContext = this;
            
        }

        public object Value
        {
            get { return (object)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }


        public static readonly DependencyProperty ValueProperty =
      DependencyProperty.Register("Value", typeof(object),
        typeof(DateControl), new PropertyMetadata(null));

     }
}
