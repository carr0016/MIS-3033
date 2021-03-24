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

namespace WPF_JSON_RickAndMorty
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
                string url = "https://rickandmortyapi.com/api/character";
                
               while (string.IsNullOrWhiteSpace(url) == false)
                {
                    var result = client.GetAsync(url).Result;

                    if (result.IsSuccessStatusCode)
                    {

                        string json = "";
                        RickAndMortyAPI api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);

                        foreach (var character in api.results)
                        {
                            lstCharacters.Items.Add(character);
                        }
                        url = api.info.next;
                    }
            }
        }

        private void lstCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character c = (Character)lstCharacters.SelectedItem;

            CharacterInfo infoWindow = new CharacterInfo();
            infoWindow.SetImageSource(c);
            infoWindow.ShowDialog();

        }
    }
}
   


