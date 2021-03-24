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

namespace Practicing_Problem1Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<TVShow> TVShows = new List<TVShow>();
        public MainWindow()
        {
            InitializeComponent();
            var lines = File.ReadAllLines("TV Show Data");
            foreach (var line in lines)
            {
                TVShows.Add(new TVShow(line));
            }

            PopulateListBox(TVShows);
            PopulateRatingFilter();
            PopulateCountryFilter();
            PopulateLanguageFilter();
        }

        private void PopulateLanguageFilter()
        {
            cboLanguage.Items.Add("All");
            cboLanguage.SelectedIndex = 0;
        }

        private void PopulateCountryFilter()
        {
            cboCountry.Items.Add("All");
            cboCountry.SelectedIndex = 0;
        }

        private void PopulateRatingFilter()
        {
            cboRating.Items.Add("All");
            cboRating.SelectedIndex = 0;
        }

        private void PopulateListBox(List<TVShow> tVShows)
        {
            
        }
    }
}
