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

namespace WPF_Classes
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

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            bool isEverythingGood = true;


            if (string.IsNullOrWhiteSpace(txtManufacturer.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Manufacturer!");
            }
 
            if (string.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Name!");
            }
            if (string.IsNullOrWhiteSpace(txtImage.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Image!");
            }

            //double
            string number = txtPrice.Text;
            double value;
            bool isNumber = double.TryParse(number, out value);
            if (isNumber == false)
            {
                isNumber = false;
                MessageBox.Show("You must enter a valid Price!");
            }

            if (isEverythingGood == false)
            {
                return;
            }

            Toy toys = new Toy()
            {
                Manufacturer = txtManufacturer.Text,
                Name = txtName.Text,
                Image = txtImage.Text,
                Price = Convert.ToDouble(number),

            };

            lstToys.Items.Add(toys);
            txtName.Clear();
            txtManufacturer.Clear();
            txtImage.Clear();
            txtPrice.Clear();

        }

        private void lstToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)lstToys.SelectedItem;
            MessageBox.Show($"{selectedToy.ToString()} is found on aisle: {selectedToy.GetAisle().ToUpper()}");

            
            var uri = new Uri(selectedToy.Image);
            var img = new BitmapImage(uri);
            imgToy.Source = img;
        }
    }
}
