using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class GameModeView : UserControl
    {
        private Panel panSelectGameMode;
        private Panel panSelectGameModeMenu;
        private Button btnStartGame;
        private GroupBox grpGameModeQuestions;
        private GroupBox grpGameModeAnswers;
        private RadioButton rbModeCountryQuestions;
        private RadioButton rbModeCapitalQuestions;
        private RadioButton rbModeFlagQuestions;
        private CheckBox cbModeCountryAnswers;
        private CheckBox cbModeCapitalAnswers;
        private CheckBox cbModeFlagAnswers;

        public GameModeView()
        {
            #region create elements

            panSelectGameMode = new Panel
            {
                Name = "panSelectGameMode",
                Size = new Size(230, 450)
            };

            panSelectGameModeMenu = new Panel
            {
                Name = "panSelectGameModeMenu",
                Dock = DockStyle.Bottom
            };

            btnStartGame = new Button
            {
                Name = "btnStartGame",
                Text = "Spiel starten"
            };

            grpGameModeQuestions = new GroupBox
            {
                Name = "grpGameModeQuestions",
                Text = "Fragen",
                Location = new Point(14, 16)
            };

            grpGameModeAnswers = new GroupBox
            {
                Name = "grpGameModeAnswers",
                Text = "Antworten",
                Location = new Point(14, 122)
            };

            rbModeCountryQuestions = new RadioButton
            {
                Name = "rbModeCountryQuestions",
                Text = "Länder",
                Location = new Point(7, 20)
            };

            rbModeCapitalQuestions = new RadioButton
            {
                Name = "rbModeCapitalQuestions",
                Text = "Hauptstädte",
                Location = new Point(7, 43)
            };

            rbModeFlagQuestions = new RadioButton
            {
                Name = "rbModeFlagQuestions",
                Text = "Flaggen",
                Location = new Point(7, 66)
            };

            cbModeCountryAnswers = new CheckBox
            {
                Name = "cbModeCountryAnswers",
                Text = "Länder",
                Location = new Point(7, 20)
            };

            cbModeCapitalAnswers = new CheckBox
            {
                Name = "cbModeCapitalAnswers",
                Text = "Hauptstädte",
                Location = new Point(7, 43)
            };

            cbModeFlagAnswers = new CheckBox
            {
                Name = "cbModeFlagAnswers",
                Text = "Flaggen",
                Location = new Point(7, 66)
            };

            #endregion create elements

            #region add eventhandler

            rbModeCountryQuestions.Click += (s, e) =>
            {
                ToggleAnswerBox();
            };

            rbModeCapitalQuestions.Click += (s, e) =>
            {
                ToggleAnswerBox();
            };

            rbModeFlagQuestions.Click += (s, e) =>
            {
                ToggleAnswerBox();
            };

            btnStartGame.Click += (s, e) =>
            {
                App app = (App)Parent;
                app.ShowQuestion();
            };

            #endregion add eventhandler

            #region add elements to controls

            grpGameModeQuestions.Controls.AddRange(new Control[]
            {
                rbModeCountryQuestions,
                rbModeCapitalQuestions,
                rbModeFlagQuestions
            });

            grpGameModeAnswers.Controls.AddRange(new Control[] 
            {
                cbModeCountryAnswers,
                cbModeCapitalAnswers,
                cbModeFlagAnswers
            });

            panSelectGameModeMenu.Controls.Add(btnStartGame);

            panSelectGameMode.Controls.AddRange(new Control[]
            {
                grpGameModeQuestions,
                grpGameModeAnswers,
                panSelectGameModeMenu
            });

            Controls.Add(panSelectGameMode);

            #endregion add elements to controls

        }

        public void ToggleAnswerBox()
        {
            RadioButton rb = grpGameModeQuestions.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            switch (rb.Name)
            {
                case "rbModeCountryQuestions":
                    DisableAnswerType(cbModeCountryAnswers);
                    break;
                case "rbModeCapitalQuestions":
                    DisableAnswerType(cbModeCapitalAnswers);
                    break;
                case "rbModeFlagQuestions":
                    DisableAnswerType(cbModeFlagAnswers);
                    break;
                default:
                    break;
            }
        }

        private void DisableAnswerType(CheckBox cb)
        {
            foreach (CheckBox c in grpGameModeAnswers.Controls.OfType<CheckBox>())
            {
                c.Enabled = true;
                c.Checked = false;
            }

            cb.Checked = false;
            cb.Enabled = false;
        }
    }
}
