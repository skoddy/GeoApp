using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void ShowQuestion()
        {
            gameView = new GameView
            {
                Dock = DockStyle.Fill
            };

            Show(gameView);
        }

        private void ShowGameMode()
        {
            gameModeView = new GameModeView
            {
                Dock = DockStyle.Fill
            };

            Show(gameModeView);
        }

        private void Show(UserControl uc)
        {
            foreach (Control c in Controls.OfType<UserControl>())
            {
                Controls.Remove(c);
            }

            Controls.Add(uc);
        }

    }
}
