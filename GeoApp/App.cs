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
            SelectGameMode();
        }

        private void SelectGameMode()
        {
            gameModeView = new GameModeView
            {
                Dock = DockStyle.Fill
            };

            ToggleView(gameModeView);
        }

        public void StartGame(QuestionType qt, AnswerType at)
        {
            gameView = new GameView(qt, at)
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
