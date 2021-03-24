using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_HW3
{
    class TVShow
    {
        public string Actors { get; set; }
        public string Awards { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string RuntimeInMinutes { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Writer { get; set; }
        public string Year { get; set; }
        public string ImdbID { get; set; }
        public string ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string TotalSeasons { get; set; }

        public TVShow () //create an empty constructor
        {
            Actors = String.Empty;
            Awards = String.Empty;
            Country = String.Empty;
            Director = String.Empty;
            Genre = String.Empty;
            Language = String.Empty;
            Plot = String.Empty;
            Poster = String.Empty;
            Rated = String.Empty;
            Released = String.Empty;
            RuntimeInMinutes = String.Empty;
            Title = String.Empty;
            Type = String.Empty;
            Writer = String.Empty;
            Year = String.Empty;
            ImdbID = String.Empty;
            ImdbRating = String.Empty;
            ImdbVotes = String.Empty;
            TotalSeasons = String.Empty;
        }
        public TVShow(string line)
        {
            var pieces = line.Split('\t'); //parse it into pieces

            Actors = pieces[1];
            Awards = pieces[2];
            Country = pieces[3];
            Director = pieces[4];
            Genre = pieces[5];
            Language = pieces[6];
            Plot = pieces[7];
            Poster = pieces[8];
            Rated = pieces[9];
            Released = pieces[10];
            RuntimeInMinutes = pieces[11];
            Title = pieces[12];
            Type = pieces[13];
            Writer = pieces[14];
            Year = pieces[15];
            ImdbID = pieces[16];
            ImdbRating = pieces[17];
            ImdbVotes = pieces[18];
            TotalSeasons = pieces[19];
        }
    }
}
