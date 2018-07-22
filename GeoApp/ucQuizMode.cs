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
            RadioButton rbQuestionType = panQuestionMode.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            Qt = (QuestionType)Enum.Parse(typeof(QuestionType), rbQuestionType.Tag.ToString());

            switch (Qt)
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
            if (At)
            {

            }
            App app = (App)Parent.Parent;
            app.Quiz();
        }

        private void SetAnswerType(object sender, EventArgs e)
        {
            RadioButton rbAnswerType = panAnswerMode.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            At = (AnswerType)Enum.Parse(typeof(AnswerType), rbAnswerType.Tag.ToString());

            grpContinent.Enabled = true;
        }

        private void SetContinent(object sender, EventArgs e)
        {
            RadioButton rbContinent = panContinent.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            Continent = rbContinent.Tag.ToString();

            btnStartQuiz.Enabled = true;
        }


    }
}
