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
    public partial class Form1 : Form
    {
        private List<GeoData> listGeodata;
        private Database db;
        private Question<Label>[] questions;
        private int questionIndex = 0;

        public Form1()
        {
            InitializeComponent();

            Init();
            ShowQuestion();
        }

        enum QuestionType
        {
            Country,
            Capital,
            Flag
        }

        enum AnswerType
        {
            Country,
            Capital,
            Flag
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

        private void ShowQuestion()
        {
            grpQuestion.Controls.Clear();
            grpAnswers.Controls.Clear();

            lblResult.Text = null;

            grpQuestion.Controls.Add(questions[questionIndex].GetContent());

            foreach (Answer<Label> answer in questions[questionIndex].Answers)
            {
                grpAnswers.Controls.AddRange(
                    new Control[] {
                        answer.RadioButton(),
                        answer.GetContent()
                    });
            }
            // ShowPanel(panQuiz);
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            questionIndex++;
            ShowQuestion();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
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

        private void ShowPanel(Panel panel)
        {
            List<Panel> panels = new List<Panel>(Controls.OfType<Panel>());

            foreach (Panel p in panels)
            {
                p.Visible = false;
            }

            panel.Visible = true;
        }
    }
}
