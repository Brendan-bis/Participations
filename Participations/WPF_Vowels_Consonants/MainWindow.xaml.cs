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

namespace WPF_Vowels_Consonants
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtInput.Clear();
            
        }

        private void btnWordOrNumber_Click(object sender, RoutedEventArgs e)
        {
            lstVowels.Items.Clear();
            lstConsonants.Items.Clear();
            string input = txtInput.Text;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'o' || input[i] == 'i' || input[i] == 'u')
                {
                    lstVowels.Items.Add(input[i]);
                }
                else
                {
                    lstConsonants.Items.Add(input[i]);

                }
                

            }
           
            txtInput.Clear();
            
        }
    }
}
