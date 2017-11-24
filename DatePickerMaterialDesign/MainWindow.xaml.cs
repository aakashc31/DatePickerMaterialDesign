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

namespace DatePickerMaterialDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dp.DisplayDateStart = new DateTime(2017, 10, 17);
            dp.DisplayDateEnd = new DateTime(2017, 11, 17);
            dp.BlackoutDates.Add(new CalendarDateRange(new DateTime(2017, 11, 16), new DateTime(2017, 11, 16)));
            dp.BlackoutDates.Add(new CalendarDateRange(new DateTime(2017, 11, 4), new DateTime(2017, 11, 5)));
        }
    }
}
