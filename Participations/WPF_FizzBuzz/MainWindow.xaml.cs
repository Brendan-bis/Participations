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

namespace WPF_FizzBuzz
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

        private void btnWordOrNumber_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            for (int i = 1; i < 1001; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                {
                    listFizzBuzz.Items.Add(i.ToString("n0"));
                }
                else if (i%3 == 0)
                {
                    listFizz.Items.Add(i.ToString("n0"));
                }
                else if (i%5 == 0)
                {
                    lstBuzz.Items.Add(i.ToString("n0"));
                }
            }
        }
    }
}
