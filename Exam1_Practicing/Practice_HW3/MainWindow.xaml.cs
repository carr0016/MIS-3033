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

            foreach (var show in TVShows)
            {
                var values = show.Country.Split(',');
                foreach (var val in values)
                {
                    if (string.IsNullOrWhiteSpace(val))
                    {
                        continue;
                    }
                    string cleanedValue = val.Trim(CharactersToTrim);
                    if (!cboCountry.Items.Contains(cleanedValue))
                    {
                        cboCountry.Items.Add(cleanedValue);
                    }
                }
            }
        }

        private void PopulateRatingFilter()
        {
            cboRating.Items.Add("All");
            cboRating.SelectedIndex = 0;

            foreach (var show in TVShows)
            {
                if (string.IsNullOrWhiteSpace(show.Rated))
                {
                    continue;
                }
                string cleanedValue = show.Rated.Trim();
                if (!cboRating.Items.Contains(cleanedValue))
                {
                    cboRating.Items.Add(cleanedValue);
                }
            }
        }

        private void PopulateListBox(List<TVShow> tvShows)
        {
            lstShows.Items.Clear();
            foreach (var show in tvShows)
            {
                lstShows.Items.Add(show);
            }
        }

        private void cboRating_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboRating.SelectedValue !=null)
            {
                UpdateDateForFilters(); //generate method
            }
        }

        private void UpdateDateForFilters()
        {
            if (cboCountry.SelectedValue is null
                || cboLanguage.SelectedValue is null
                || cboRating.SelectedValue is null)
            {
                return;
            }
            List<TVShow> filteredShows;
            filteredShows = FilterRating(TVShows); //generate method
            filteredShows = FilterCountry(filteredShows);
            filteredShows = FilterLanguage(filteredShows);

            PopulateListBox(filteredShows);

        }

        private List<TVShow> FilterLanguage(List<TVShow> shows)
        {
            string language = cboLanguage.SelectedValue.ToString();
            List<TVShow> filteredShows = new List<TVShow>();

        }

        private List<TVShow> FilterCountry(List<TVShow> shows)
        {
            throw new NotImplementedException();
        }

        private List<TVShow> FilterRating(List<TVShow> shows)
        {
            throw new NotImplementedException();
        }

        private void cboCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cboLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
