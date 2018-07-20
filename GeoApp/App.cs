using System.Linq;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class App : Form
    {
        GameModeView gameModeView;
        GameView gameView;

        public App()
        {
            InitializeComponent();
            ShowGameMode();
        }

        private void ShowGameMode()
        {
            gameModeView = new GameModeView
            {
                Dock = DockStyle.Fill
            };

            ToggleView(gameModeView);
        }

        public void ShowQuestion()
        {
            gameView = new GameView
            {
                Dock = DockStyle.Fill
            };

            ToggleView(gameView);
        }

        private void ToggleView(UserControl uc)
        {
            foreach (Control c in Controls.OfType<UserControl>())
            {
                Controls.Remove(c);
            }

            Controls.Add(uc);
        }

    }
}
