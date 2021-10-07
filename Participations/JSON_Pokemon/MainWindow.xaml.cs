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

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?limit=1118&offset=0").Result;

                PokemonAPI api = JsonConvert.DeserializeObject<PokemonAPI>(jsonData);

                foreach (PokemonResultsAPI item in api.results)
                {
                    cboPokemon.Items.Add(item);
                }
            }
        }


        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            PokemonResultsAPI pokemon = (PokemonResultsAPI)cboPokemon.SelectedItem;

            string pokemonName = cboPokemon.Text;

            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/" + pokemonName).Result;

                IndividualPokemonAPI api = JsonConvert.DeserializeObject<IndividualPokemonAPI>(jsonData);

                txtHeight.Text = api.height;
                txtWeight.Text = api.weight;

                SpritesAPI spritesAPI = api.sprites;
                if (spritesAPI == null)
                {
                    return;
                }
                imgSprite.Source = new BitmapImage(new Uri(spritesAPI.front_default));


            }
        }

        //private void btnFrontDefault_Click(object sender, RoutedEventArgs e)
        //{
        //    IndividualPokemonAPI selected = (IndividualPokemonAPI)cboPokemon.SelectedItem;
        //    if (imgSprite.Source == new BitmapImage(new Uri(selected.sprites.front_default)))
        //    {
        //        imgSprite.Source = new BitmapImage(new Uri(selected.sprites.back_default));
        //    }
            
        //}
    }
}
