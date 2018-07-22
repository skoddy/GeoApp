using GeoApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class ucQuiz : UserControl
    {
        // Singleton Pattern
        private static ucQuiz _instance;

        public static ucQuiz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucQuiz();
                }
                return _instance;
            }
        }

        private int questionIndex = 0;

        private Database db;
        private Question[] questions;
        private List<GeoData> listGeodata;

        public ucQuiz()
        {
            InitializeComponent();
            Init();
            CreateQuiz();
        }

        private void Init()
        {
            int maxQuestions = 20;
            db = new Database();
            listGeodata = db.GetData("Europe");
            questions = new Question[maxQuestions];

            for (int i = 0; i < maxQuestions; i++)
            {
                GeoData question = listGeodata[i];
                List<GeoData> answers = db.GetFalseAnswers(question.Id, "Europe");
                switch (ucQuizMode.Instance.Qt)
                {
                    case QuestionType.Capital:
                        questions[i] = new CapitalQuestion(question, answers, ucQuizMode.Instance.At, ucQuizMode.Instance.Continent);
                        break;
                    case QuestionType.Country:
                        questions[i] = new CountryQuestion(question, answers, ucQuizMode.Instance.At, ucQuizMode.Instance.Continent);
                        break;
                    case QuestionType.Flag:
                        questions[i] = new FlagQuestion(question, answers, ucQuizMode.Instance.At, ucQuizMode.Instance.Continent);
                        break;
                }

            }
        }
        private void CreateQuiz()
        {
            grpQuestion.Controls.Clear();
            panAnswers.Controls.Clear();

            btnNextQuestion.Enabled = false;
            btnAnswer.Enabled = true;
            pbResult.Image = null;
            lblResult.Text = null;

            grpQuestion.Controls.Add(questions[questionIndex].GetContent());

            foreach (Answer answer in questions[questionIndex].Answers)
            {
                panAnswers.Controls.AddRange(new Control[]
                {
                        answer.GetContent()
                });
            }

            questionIndex++;
        }

        private void GiveAnswer()
        {
            RadioButton rb = panAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            RadioButton rb2 = panAnswers.Controls.OfType<RadioButton>()
                .First(r => r.Tag.ToString() == "True");

            if (rb != null)
            {

                if (rb.Tag.ToString() == "True")
                {
                    rb.ForeColor = Color.Green;
                    lblResult.Text = "Richtig!";
                }
                else
                {
                    ResourceManager rm = Resources.ResourceManager;
                    Image image = (Bitmap)rm.GetObject(rb2.Name.ToLower());

                    if (image != null)
                    {
                        pbResult.Image = image;
                        pbResult.Size = new Size(image.Width + 20, image.Height);
                    }

                    rb.ForeColor = Color.Red;
                    rb2.ForeColor = Color.Green;
                    lblResult.Text = "Falsch.\nRichtige Antwort: " + rb2.Text;
                }

                btnAnswer.Enabled = false;
                btnNextQuestion.Enabled = true;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            CreateQuiz();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            GiveAnswer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _instance = null;
            App app = (App)Parent.Parent;
            app.QuizMode();
        }
    }
}
