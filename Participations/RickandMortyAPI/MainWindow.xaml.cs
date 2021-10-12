﻿using Newtonsoft.Json;
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
        private RickAndMortyAPI api;
        public MainWindow()
        {

            InitializeComponent();
            
            //https://rickandmortyapi.com/api/character

            cboCharacters.Items.Clear();
            using (var client = new HttpClient())
            {

                for (int i = 1; i < api.info.next.Length; i++)
                {
                    string jsonData = client.GetStringAsync("https://rickandmortyapi.com/api/character").Result;
                    RickAndMortyAPI api = JsonConvert.DeserializeObject<RickAndMortyAPI>(jsonData);
                    foreach (Character item in api.results)
                    {
                        cboCharacters.Items.Add(item);
                    }

                }
                
            }
        }
    }
}