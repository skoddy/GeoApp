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

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public bool Authed { get; set; } = false;
        public int Score { get; set; } = 0;
    }
}