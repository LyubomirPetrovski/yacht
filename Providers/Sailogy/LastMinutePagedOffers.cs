using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yacht.Providers.Sailogy
{
    internal class LastMinutePagedOffers
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Offer> results { get; set; }

        public class Boat
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public Type type { get; set; }
            public int year { get; set; }
            public int wc { get; set; }
            public List<Gallery> gallery { get; set; }
            public object refit_year { get; set; }
            public double length { get; set; }
            public Cabins cabins { get; set; }
            public int berths { get; set; }
            public object boat_class { get; set; }
            public Model model { get; set; }
        }

        public class Cabins
        {
            public int @double { get; set; }
            public int single { get; set; }
            public int total { get; set; }
            public int double_bunk_cabins { get; set; }
        }

        public class DepartureMarina
        {
            public string slug { get; set; }
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Gallery
        {
            public string url { get; set; }
            public string type { get; set; }
        }

        public class Model
        {
            public int id { get; set; }
            public string slug { get; set; }
        }

        public class Offer
        {
            public int id { get; set; }
            public Boat boat { get; set; }
            public DepartureMarina departure_marina { get; set; }
            public double final_price { get; set; }
            public double original_price { get; set; }
            public string start_date { get; set; }
            public string end_date { get; set; }
            public bool is_skippered { get; set; }
        }

        public class Type
        {
            public int value { get; set; }
            public string label { get; set; }
        }
    }
}
