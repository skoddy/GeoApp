using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class GameView : UserControl
    {
        private int questionIndex = 0;

        private Database db;
        private Question<Label>[] questions;
        private List<GeoData> listGeodata;

        private Panel panGame;
        private Panel panGameMenu;

        private Button btnGameMenuGiveAnswer;
        private Button btnNextQuestion;

        private GroupBox grpQuestion;
        private GroupBox grpAnswers;
        private GroupBox grpResult;

        private Label lblResult;

        QuestionType _qt;
        AnswerType _at;

        public GameView(QuestionType qt, AnswerType at)
        {
            _qt = qt;
            _at = at;

            #region create elements

            panGame = new Panel
            {
                Name = "panGame",
                Size = new Size(230, 450)
            };

            panGameMenu = new Panel
            {
                Name = "panGameMenu",
                Dock = DockStyle.Bottom
            };

            btnGameMenuGiveAnswer = new Button
            {
                Name = "btnGameMenuGiveAnswer",
                Text = "Antworten",
                Location = new Point(14, 16)
            };

            btnNextQuestion = new Button
            {
                Name = "btnNextQuestion",
                Text = "Weiter",
                Location = new Point(100, 16),
                Enabled = false
            };

            grpQuestion = new GroupBox
            {
                Name = "grpQuestion",
                Text = "Frage",
                Location = new Point(14, 16)
            };

            grpAnswers = new GroupBox
            {
                Name = "grpAnswers",
                Text = "Antworten",
                Location = new Point(14, 122)
            };

            grpResult = new GroupBox
            {
                Name = "grpResult",
                Text = "Ergebnis",
                Location = new Point(14, 240)
            };

            lblResult = new Label
            {
                Location = new Point(10, 20),
                MaximumSize = new Size(100, 0),
                AutoSize = true
            };

            #endregion create elements

            #region add events

            btnGameMenuGiveAnswer.Click += (s, e) =>
            {
                GiveAnswer();
            };

            btnNextQuestion.Click += (s, e) =>
            {
                CreateQuiz();
            };

            #endregion add events

            #region add to controls

            grpResult.Controls.Add(lblResult);

            panGameMenu.Controls.AddRange(new Control[]
            {
                btnGameMenuGiveAnswer,
                btnNextQuestion
            });

            panGame.Controls.AddRange(new Control[]
            {
                grpQuestion,
                grpAnswers,
                grpResult,
                panGameMenu
            });

            Controls.Add(panGame);

            #endregion add to controls

            Init();
            CreateQuiz();
        }

        private void CreateQuiz()
        {
            grpQuestion.Controls.Clear();
            grpAnswers.Controls.Clear();

            btnNextQuestion.Enabled = false;
            btnGameMenuGiveAnswer.Enabled = true;

            lblResult.Text = null;

            grpQuestion.Controls.Add(questions[questionIndex].GetContent());

            foreach (Answer<Label> answer in questions[questionIndex].Answers)
            {
                grpAnswers.Controls.AddRange(new Control[]
                {
                        answer.RadioButton(),
                        answer.GetContent()
                });
            }

            questionIndex++;
        }

        private void GiveAnswer()
        {
            RadioButton rb = grpAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            RadioButton rb2 = grpAnswers.Controls.OfType<RadioButton>()
                .First(r => r.Name == "True");

            if (rb != null)
            {
                Label lblClicked = grpAnswers.Controls.OfType<Label>()
                    .FirstOrDefault(l => l.Name == rb.Tag.ToString());

                Label lblCorrect = grpAnswers.Controls.OfType<Label>()
                    .FirstOrDefault(l => l.Name == rb2.Tag.ToString());

                if (rb.Name == "True")
                {
                    lblClicked.ForeColor = Color.Green;
                    lblResult.Text = "Richtig!";
                }
                else
                {
                    lblClicked.ForeColor = Color.Red;
                    lblCorrect.ForeColor = Color.Green;
                    lblResult.Text = "Falsch.\nRichtige Antwort: " + rb2.Tag;
                }

                btnGameMenuGiveAnswer.Enabled = false;
                btnNextQuestion.Enabled = true;
            }
        }

        private void Init()
        {
            int maxQuestions = 20;

            db = new Database();

            listGeodata = db.GetData();

            questions = new Question<Label>[maxQuestions];

            for (int i = 0; i < maxQuestions; i++)
            {
                switch (_qt)
                {
                    case QuestionType.Capital:
                        questions[i] = new CapitalQuestion(listGeodata[i], db, _at);
                        break;
                    case QuestionType.Country:
                        questions[i] = new CountryQuestion(listGeodata[i], db, _at);
                        break;
                    case QuestionType.Flag:
                        questions[i] = new CapitalQuestion(listGeodata[i], db, _at);
                        break;
                }

            }
        }
    }
}
