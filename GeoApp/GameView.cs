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
        private Database db;
        private Question<Label>[] questions;
        private int questionIndex = 0;
        private List<GeoData> listGeodata;
        Panel panGame;
        Panel panGameMenu;
        Button btnGameMenuGiveAnswer;

        GroupBox grpQuestion;
        GroupBox grpAnswers;
        GroupBox grpResult;

        Label lblResult;
        public GameView()
        {
            Init();
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
                Location = new Point(10, 20)
            };

            btnGameMenuGiveAnswer.Click += (s, e) =>
            {
                GiveAnswer();
            };

            grpQuestion.Controls.Add(questions[questionIndex].GetContent());

            foreach (Answer<Label> answer in questions[questionIndex].Answers)
            {
                grpAnswers.Controls.AddRange(new Control[] 
                {
                        answer.RadioButton(),
                        answer.GetContent()
                });
            }
            grpResult.Controls.Add(lblResult);
            panGameMenu.Controls.Add(btnGameMenuGiveAnswer);

            panGame.Controls.AddRange(new Control[]
            {
                grpQuestion,
                grpAnswers,
                grpResult,
                panGameMenu

            });

            Controls.Add(panGame);
        }

        private void GiveAnswer()
        {
            RadioButton rb = grpAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            if (rb != null)
            {
                if (rb.Name == "True")
                {
                    lblResult.Text = "Richtig!";
                }
                else
                {
                    lblResult.Text = "Falsch.";
                }
            }
        }

        private void Init()
        {

            int maxQuestions = 20;

            db = new Database();
            listGeodata = db.GetData();

            QuestionType qt = QuestionType.Capital;
            switch (qt)
            {
                case QuestionType.Capital:
                    questions = new Question<Label>[maxQuestions];
                    break;
                case QuestionType.Country:
                    questions = new Question<Label>[maxQuestions];
                    break;
                case QuestionType.Flag:
                    questions = new Question<Label>[maxQuestions];
                    break;
                default:
                    questions = new Question<Label>[maxQuestions];
                    break;
            }

            for (int i = 0; i < maxQuestions; i++)
            {
                AnswerType at = AnswerType.Flag;
                switch (at)
                {
                    case AnswerType.Capital:
                        questions[i] = new CapitalQuestion(listGeodata[i], db);
                        break;
                    case AnswerType.Country:
                        questions[i] = new CapitalQuestion(listGeodata[i], db);
                        break;
                    case AnswerType.Flag:
                        questions[i] = new CapitalQuestion(listGeodata[i], db);
                        break;
                    default:
                        questions[i] = new CapitalQuestion(listGeodata[i], db);
                        break;
                }

            }
        }
    }
}
