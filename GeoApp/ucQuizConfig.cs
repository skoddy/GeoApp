using System;
using System.Linq;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class ucQuizConfig : UserControl
    {
        // Singleton Pattern, Best Pattern :)
        private static ucQuizConfig _instance;

        public static ucQuizConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucQuizConfig();
                }
                return _instance;
            }
        }
        
        public ucQuizConfig()
        {
            InitializeComponent();
        }

        private void ToggleAnswerBox()
        {
            grpAnswerMode.Enabled = true;

            switch (QuizConfig.Instance.Qt)
            {
                case QuestionType.Country:
                    DisableAnswerType(rbCountryAnswers);
                    break;
                case QuestionType.Capital:
                    DisableAnswerType(rbCapitalAnswers);
                    break;
                case QuestionType.Flag:
                    DisableAnswerType(rbFlagAnswers);
                    break;
                default:
                    break;
            }
        }

        private void DisableAnswerType(RadioButton rb)
        {
            foreach (RadioButton r in panAnswerMode.Controls.OfType<RadioButton>())
            {
                r.Enabled = true;
                r.Checked = false;
            }

            rb.Checked = false;
            rb.Enabled = false;
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            _instance = null;
            App app = (App)Parent.Parent;
            app.Quiz();
        }

        private void SetQuestionType(object sender, EventArgs e)
        {
            RadioButton rbQuestionType = panQuestionMode.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            QuizConfig.Instance.Qt = (QuestionType)Enum
                .Parse(typeof(QuestionType), rbQuestionType.Tag.ToString());

            ToggleAnswerBox();
        }

        private void SetAnswerType(object sender, EventArgs e)
        {
            RadioButton rbAnswerType = panAnswerMode.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            QuizConfig.Instance.At = (AnswerType)Enum.Parse(typeof(AnswerType), rbAnswerType.Tag.ToString());

            grpContinent.Enabled = true;
        }

        private void SetContinent(object sender, EventArgs e)
        {
            RadioButton rbContinent = panContinent.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            QuizConfig.Instance.Continent = rbContinent.Tag.ToString();

            btnStartQuiz.Enabled = true;
        }

        private void CancelConfig(object sender, EventArgs e)
        {
            _instance = null;
            App app = (App)Parent.Parent;
            app.User();
        }
    }
}
