using System;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class ucUser : UserControl
    {
        // Singleton Pattern
        private static ucUser _instance;

        public static ucUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucUser();
                }
                return _instance;
            }
        }

        public ucUser()
        {
            InitializeComponent();
            tbDisplayName.Text = User.Instance.DisplayName;
        }

        private void SignIn(object sender, EventArgs e)
        {
            if (tbDisplayName.Text.Length >= 3 && tbPassword.Text.Length >= 3)
            {
                Database db = new Database();
                db.SignIn(tbDisplayName.Text, tbPassword.Text);

                if(User.Instance.Authed)
                {
                    App app = (App)Parent.Parent;
                    app.QuizConfig();
                }
                else
                {
                    MessageBox.Show("Name oder Passwort falsch!");
                }
            }
            else
            {
                MessageBox.Show("Mindestens 3 Zeichen!");
            }
        }

        private void SignUp(object sender, EventArgs e)
        {
            if (tbDisplayName.Text.Length >= 3 && tbPassword.Text.Length >= 3)
            {
                Database db = new Database();
                db.SignUp(tbDisplayName.Text, tbPassword.Text);
                User.Instance.DisplayName = tbDisplayName.Text;
            }
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            App app = (App)Parent.Parent;
            app.Highscores();
        }
    }
}
