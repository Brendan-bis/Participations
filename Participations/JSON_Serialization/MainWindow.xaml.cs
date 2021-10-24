using System;
using System.Collections.Generic;
using System.IO;
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

namespace JSON_Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Game> AllGames = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();

            string[] linesOfFile = File.ReadAllLines("all_games.csv");
            cboPlatforms.Items.Add("All");
            for (int i = 0; i < linesOfFile.Length; i++)
            {
                string[] pieces = linesOfFile[i].Split(",");

                Game g = new Game()
                {
                    name = pieces[0].Trim(),
                    platform = pieces[1].Trim(),
                    //release_date = Convert.ToDateTime(pieces[2].Trim()),
                    summary = pieces[3].Trim(),
                    meta_score = Convert.ToInt32(pieces[4].Trim()),
                    user_review = pieces[5].Trim(),
                };

                if (cboPlatforms.Items.Contains(g.platform) == false)
                {
                    cboPlatforms.Items.Add(g.platform);
                }

                lstGames.Items.Add(g);
                AllGames.Add(g);
            }
            lblCount.Content = $"Record Count : {lstGames.Items.Count.ToString("N0")}";





        }

        private void cboPlatforms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string platform = cboPlatforms.SelectedItem.ToString();
            string platform = (string)cboPlatforms.SelectedItem;
            lstGames.Items.Clear();
            foreach (var game in AllGames)
            {
                if (platform == "All")
                {
                    lstGames.Items.Add(game);
                }
                else if (game.platform == platform)
                {
                    lstGames.Items.Add(game);
                }

            }

            lblCount.Content = $"Record Count : {lstGames.Items.Count.ToString("N0")}";
        }
    }
}
