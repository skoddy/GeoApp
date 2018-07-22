using System;
using System.Linq;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class ucQuizMode : UserControl
    {
        // Singleton Pattern
        private static ucQuizMode _instance;

        public static ucQuizMode Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucQuizMode();
                }
                return _instance;
            }
        }

        public string Continent { get; set; }
        public AnswerType At { get; set; }
        public QuestionType Qt { get; set; }

        public ucQuizMode()
        {
            InitializeComponent();
            
        }

        private void ToggleAnswerBox(object sender, EventArgs e)
        {
            grpAnswerMode.Enabled = true;
            RadioButton rb = panQuestionMode.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            switch (rb.Name)
            {
                case "rbCountryQuestions":
                    Qt = QuestionType.Country;
                    DisableAnswerType(rbCountryAnswers);
                    break;
                case "rbCapitalQuestions":
                    Qt = QuestionType.Capital;
                    DisableAnswerType(rbCapitalAnswers);
                    break;
                case "rbFlagQuestions":
                    Qt = QuestionType.Flag;
                    DisableAnswerType(rbFlagAnswers);
                    break;
                default:
                    break;
            }
        }

        private void DisableAnswerType(RadioButton cb)
        {
            foreach (RadioButton c in panAnswerMode.Controls.OfType<RadioButton>())
            {
                c.Enabled = true;
                c.Checked = false;
            }

            cb.Checked = false;
            cb.Enabled = false;
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            App app = (App)Parent.Parent;
            app.Quiz();
        }

        private void rbCountryAnswers_CheckedChanged(object sender, EventArgs e)
        {
            At = AnswerType.Country;
            btnStartQuiz.Enabled = true;
        }

        private void rbCapitalAnswers_CheckedChanged(object sender, EventArgs e)
        {
            At = AnswerType.Capital;
            btnStartQuiz.Enabled = true;
        }

        private void rbFlagAnswers_CheckedChanged(object sender, EventArgs e)
        {
            At = AnswerType.Flag;
            btnStartQuiz.Enabled = true;
        }
    }
}
