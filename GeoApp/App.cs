using System.Linq;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            User();
        }

        public void User()
        {
            ToggleView(ucUser.Instance);
        }

        public void Quiz()
        {
            ToggleView(ucQuiz.Instance);
        }

        public void QuizConfig()
        {
            ToggleView(ucQuizConfig.Instance);
        }
 
        private void ToggleView(UserControl uc)
        {
            foreach (Control c in panel.Controls.OfType<UserControl>())
            {
                panel.Controls.Remove(c);
            }

            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
