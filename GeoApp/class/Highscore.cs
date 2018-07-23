using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoApp
{
    public class Highscore
    {
        public Highscore(int id, string displayName, int score, DateTime date)
        {
            Id = id;
            DisplayName = displayName;
            Score = score;
            Date = date;
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}