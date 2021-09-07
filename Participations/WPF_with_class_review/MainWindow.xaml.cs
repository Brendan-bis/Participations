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

namespace WPF_with_class_review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtWordOrNumber.Clear();
          
        }

        private void btnWordOrNumber_Click(object sender, RoutedEventArgs e)
        {
            string input = txtWordOrNumber.Text;
            double value;
            bool isNumber = double.TryParse(input, out value);
            if (isNumber)
            {
                listBoxNumbers.Items.Add(value.ToString("N3"));
            }
            else
            {
                listBoxWords.Items.Add(input);
            }
            txtWordOrNumber.Clear();

            
        }
    }
}
