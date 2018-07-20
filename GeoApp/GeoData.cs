using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoApp
{
    public class GeoData
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Flag { get; set; }
        public string Capital { get; set; }
        public bool State { get; set; }

        public GeoData(int id, string country, string flag, string capital, bool state = false )
        {
            Id = id;
            Country = country;
            Flag = flag;
            Capital = capital;
            State = state;
        }

        public GeoData()
        {
        }
    }
}
