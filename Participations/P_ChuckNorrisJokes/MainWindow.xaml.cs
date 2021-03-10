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
            WebClient client = new WebClient();
            string url = "https://api.chucknorris.io/jokes/random";
            string json = client.DownloadString(url);

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(ResultObject));
                ResultObject obj = (ResultObject)deserializer.ReadObject(ms);

                // Assign data to combo box  
                foreach (var name in obj.icon_url)
                {

                    cbo_Categories.Items.Add(name);
                }
            }


        }

        private void btnQuote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

