using System;
using System.Collections.Generic;
using System.Text;

namespace P_ChuckNorrisJokes
{
    public class CategoriesAPI
    {
        public List<ResultObject> results { get; set; }
    }
    public class ResultObject
    {
        public string icon_url { get; set; }
        public int id { get; set; }
        public string url { get; set; }
        public string value { get; set; }

    }
}
