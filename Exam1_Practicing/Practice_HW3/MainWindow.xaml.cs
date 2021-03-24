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

namespace Practice_HW3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<TVShow> TVShows = new List<TVShow>; 
        public MainWindow()
        {
            InitializeComponent();
            var lines = File.ReadAllLines("TV Show Data.txt");
        }

        private void cboRating_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cboCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cboLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
