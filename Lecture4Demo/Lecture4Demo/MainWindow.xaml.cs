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

namespace Lecture4Demo
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

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            int celsius = Convert.ToInt32(CelsiusTextBox.Text);

            double fahrenheit = ((9 /(double) 5) * celsius) + 32;
            FahrenheitTextBox.Text = Convert.ToString(fahrenheit);

            if (fahrenheit >= 90)
            {
                FahrenheitCanvas.Background = Brushes.Red;
            }
            else if (fahrenheit >= 80)
            {
                FahrenheitCanvas.Background = Brushes.Yellow;
            }
            else if(fahrenheit >= 65)
            {
                FahrenheitCanvas.Background = Brushes.Green;
            }
            else
            {
                FahrenheitCanvas.Background = Brushes.Purple;
            }
        }
    }
}
