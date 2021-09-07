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

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //one way
            //lblOutput.Content = "";
            lblOutput.Visibility = Visibility.Hidden;
            wndName.Background = Brushes.Gray;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("You Clicked me!");
            string dobValue = txtDOB.Text;
            DateTime dob = Convert.ToDateTime(dobValue);

            TimeSpan age = DateTime.Now - dob;

            int years = age.Days / 365;
            string name = txtName.Text;
            lblOutput.Content = $"Hey {name} you are {years.ToString("G0")}";
            lblOutput.Visibility = Visibility.Visible;
        }

        private void btnSubmit_MouseEnter(object sender, MouseEventArgs e)
        {
            wndName.Background = Brushes.AliceBlue;
        }

        private void btnSubmit_MouseLeave(object sender, MouseEventArgs e)
        {
            wndName.Background = Brushes.Gray;
        }
    }
}
