using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P_Pokemon
{
    /// <summary>
    /// Interaction logic for ShowDetails.xaml
    /// </summary>
    public partial class ShowDetails : Window
    {
        public string URL { get; set; }
        public ShowDetails()
        {
            InitializeComponent();
        }
        public void SetImageSource(ResultObject result)
        {
            imgPoster.Source = new BitmapImage(new Uri(result.image));
        }
    }
}
