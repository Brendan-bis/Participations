using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_Chuck_Norris_Jokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cboCharacters.Items.Add("All");
            cboCharacters.SelectedIndex = 0;

            
            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://api.chucknorris.io/jokes/categories").Result;

                List<string> categories = JsonConvert.DeserializeObject<List<string>>(jsonData);

                foreach (string cat in categories)
                {
                    cboCharacters.Items.Add(cat);
                }


            }
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            string category = cboCharacters.SelectedValue.ToString();
            string url = "https://api.chucknorris.io/jokes/random";
            if (category != "All")
            {
                url += "?category=" + category;
            }
            

            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync(url).Result;

                Categories categories = JsonConvert.DeserializeObject<Categories>(jsonData);

                txtBlock.Text = categories.value;


            }
        }


    }
}
