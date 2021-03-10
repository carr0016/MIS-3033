using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
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

namespace P_ChuckNorrisJokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string url = "https://api.chucknorris.io/jokes/random";
            CategoriesAPI api;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                // Use if you need to validate that it was successful

                var result = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<CategoriesAPI>(result);

            }


            foreach (ResultObject result in api.results.OrderBy(x => x.value).ToList())
            {
                cbo_Categories.Items.Add(result);
            }

        }


    }

        
    }


