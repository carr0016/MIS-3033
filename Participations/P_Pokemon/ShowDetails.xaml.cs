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
    public partial class ShowDetails : Window //PokemonInfoWindow:Window
    {
        public ShowDetails() 
        {
            InitializeComponent();
        }
        public void PopulateForm(PokemonInfo pokeIno)
        {
            imgPokemon.Source = new BitmapImage(new Uri(PokemonInfoAPI.squigglyWorm.front_default));
            lblTitle.Content = pokeInfo.name;
            lblHeight.Content = 
            lblWeight.Content = $"Weight: {PokemonInfoAPI.weight}";
        }

        private void btnDance_Click(object sender, RoutedEventArgs e)
        {
            imgPokemon.Source = new BitmapImage(new Uri(pokeinfo))
        }
    }
}
