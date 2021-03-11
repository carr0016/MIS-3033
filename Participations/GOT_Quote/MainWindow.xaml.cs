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

namespace GOT_Quote
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

        private void btnGetQuote_Click(object sender, RoutedEventArgs e)
        {
            QuoteInfo quote;
            using (var client = new HttpClient())
            {
                string url = "https://got-quotes.herokuapp.com/quotes";
                GOTAPI api;
                
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<GOTAPI>(json);

                txtQuote.Text = $"{quote} {character}";

            }
        }
    }
}
