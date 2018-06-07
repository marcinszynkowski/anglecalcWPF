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

namespace AngleCalcWPF
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int hour = Int32.Parse(hours.Text);
            int minutes = Int32.Parse(mins.Text);

            if (hour > 12)
            {
                hour = hour - 12;
            }

            int hour_angle = hour * 30;
            int mins_angle = minutes * 6;

            if (minutes > hour)
            {
                int result = mins_angle - hour_angle;
                if (result < 0)
                {
                    result = result * (-1);
                }
                angle.Content = result.ToString();
            }
            else
            {
                int result = hour_angle - mins_angle;
                if (result < 0)
                {
                    result = result * (-1);
                }
                angle.Content = result.ToString();
            }
        }
    }
}
