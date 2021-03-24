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
        private List<TVShow> TVShows = new List<TVShow>(); 
        private char[] CharactersToTrim = { '"', ' ' }; //gets ride of extra puncuation country options
        public MainWindow()
        {
            InitializeComponent();
            var lines = File.ReadAllLines("TV Show Data.txt"); //making variable that represents text file
            foreach (var line in lines) //
            {
                TVShows.Add(new TVShow(line)); //relates to pieces in class
            }
            PopulateListBox(TVShows); //generate method for all of these
            PopulateRatingFilter();
            PopulateCountryFilter();
            PopulateLanguageFilter();
        }

        private void PopulateLanguageFilter()
        {
            cboLanguage.Items.Add("All");
            cboLanguage.SelectedIndex = 0;

            // foreach loop to go through the data set. If it's an empty string we continue
            // but otherwise we make sure it isn't in the listbox. if it doesn't already contain a value we just add it
            // we do the same thing for country and rating
            foreach (var show in TVShows) //going through the list 
            {
                var values = show.Language.Split(','); //able to go through list and for every language we want to add it to combo box
                foreach (var val in values) //values is different types of languages, each one is called val
                {
                    if (string.IsNullOrWhiteSpace(val)) 
                    {
                        continue;
                    }
                    string cleanedValue = val.Trim(CharactersToTrim);
                    if (!cboLanguage.Items.Contains(cleanedValue))
                    {
                        cboLanguage.Items.Add(cleanedValue);
                    }
                }
            }
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
