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

namespace RickandMortyAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private RickAndMortyAPI api;
        public MainWindow()
        {

            InitializeComponent();
            
            //https://rickandmortyapi.com/api/character

            cboCharacters.Items.Clear();
            string url = "https://rickandmortyapi.com/api/character";
            using (var client = new HttpClient())
            {
                for (int i = 0; i < 34; i++)
                {
                    string jsonData = client.GetStringAsync(url).Result;
                    RickAndMortyAPI api = JsonConvert.DeserializeObject<RickAndMortyAPI>(jsonData);
                    foreach (Character item in api.results)
                    {
                        cboCharacters.Items.Add(item);
                    }
                    url = api.info.next;
                }
               
            }
        }
    }
}
