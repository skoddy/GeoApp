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
        private RadioButton rbModeCountryAnswers;
        private RadioButton rbModeCapitalAnswers;
        private RadioButton rbModeFlagAnswers;

        QuestionType qt;
        AnswerType at;

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
                Tag = "Country",
                Checked = true,
                Location = new Point(7, 20)
            };

            rbModeCapitalQuestions = new RadioButton
            {
                Name = "rbModeCapitalQuestions",
                Text = "Hauptstädte",
                Tag = "Capital",
                Location = new Point(7, 43)
            };

            rbModeFlagQuestions = new RadioButton
            {
                Name = "rbModeFlagQuestions",
                Text = "Flaggen",
                Tag = "Flag",
                Location = new Point(7, 66)
            };

            rbModeCountryAnswers = new RadioButton
            {
                Name = "cbModeCountryAnswers",
                Text = "Länder",
                Tag = "Country",
                Location = new Point(7, 20)
            };

            rbModeCapitalAnswers = new RadioButton
            {
                Name = "cbModeCapitalAnswers",
                Text = "Hauptstädte",
                Tag = "Capital",
                Location = new Point(7, 43)
            };

            rbModeFlagAnswers = new RadioButton
            {
                Name = "cbModeFlagAnswers",
                Text = "Flaggen",
                Tag = "Flag",
                Location = new Point(7, 66)
            };

            #endregion create elements

            #region add events

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
                RadioButton rbQ = grpGameModeQuestions.Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked);

                RadioButton rbA = grpGameModeAnswers.Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked);

                Enum.TryParse(rbQ.Tag.ToString(), out qt);
                Enum.TryParse(rbA.Tag.ToString(), out at);
                StartGame();
            };

            #endregion add events

            #region add to controls

            grpGameModeQuestions.Controls.AddRange(new Control[]
            {
                rbModeCountryQuestions,
                rbModeCapitalQuestions,
                rbModeFlagQuestions
            });

            grpGameModeAnswers.Controls.AddRange(new Control[] 
            {
                rbModeCountryAnswers,
                rbModeCapitalAnswers,
                rbModeFlagAnswers
            });

            panSelectGameModeMenu.Controls.Add(btnStartGame);

            panSelectGameMode.Controls.AddRange(new Control[]
            {
                grpGameModeQuestions,
                grpGameModeAnswers,
                panSelectGameModeMenu
            });

            Controls.Add(panSelectGameMode);

            #endregion add to controls

        }

        private void StartGame()
        {
            App app = (App)Parent;
            app.StartGame(qt, at);
        }

        public void ToggleAnswerBox()
        {
            RadioButton rb = grpGameModeQuestions.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            switch (rb.Name)
            {
                case "rbModeCountryQuestions":
                    DisableAnswerType(rbModeCountryAnswers);
                    break;
                case "rbModeCapitalQuestions":
                    DisableAnswerType(rbModeCapitalAnswers);
                    break;
                case "rbModeFlagQuestions":
                    DisableAnswerType(rbModeFlagAnswers);
                    break;
                default:
                    break;
            }
        }

        private void DisableAnswerType(RadioButton cb)
        {
            foreach (RadioButton c in grpGameModeAnswers.Controls.OfType<RadioButton>())
            {
                c.Enabled = true;
                c.Checked = false;
            }

            cb.Checked = false;
            cb.Enabled = false;
        }
    }
}
