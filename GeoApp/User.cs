using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoApp
{
    public class User
    {
        // Singleton Pattern
        private static User _instance;

        public static User Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new User();
                }
                return _instance;
            }
        }

        public string DisplayName { get; set; }
        public int Score { get; set; } = 0;
    }
}