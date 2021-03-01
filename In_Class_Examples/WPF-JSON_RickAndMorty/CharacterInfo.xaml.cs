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

namespace WPF_JSON_RickAndMorty
{
    /// <summary>
    /// Interaction logic for CharacterInfo.xaml
    /// </summary>
    public partial class CharacterInfo : Window
    {
        public string URL { get; set; }
        public CharacterInfo()
        {
            InitializeComponent();
        }
        private void SetImageSource()
        {
            imgPicture.Source = new BitmapImage(new);
        }

        }

}
