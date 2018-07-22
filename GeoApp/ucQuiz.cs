﻿using GeoApp.Properties;
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
            InitializeQuiz();
            CreateQuiz();
        }

        private void InitializeQuiz()
        {
            // TODO: maxQuestions müsste woanders hin
            int maxQuestions = 10;

            db = new Database();

            // Daten holen
            listGeodata = db.GetData(maxQuestions, ucQuizMode.Instance.Continent);

            // Objekt questions mit Abstrakter Klasse initialisieren
            questions = new Question[maxQuestions];

            for (int i = 0; i < maxQuestions; i++)
            {
                // Den ersten Eintrag als Frage speichern
                GeoData question = listGeodata[i];

                // Falsche Anworten holen (WHERE id != question.Id)
                List<GeoData> answers = db.GetFalseAnswers(question.Id, ucQuizMode.Instance.Continent);

                // Je nach Fragentyp (Qt) wird das abstrakte Objekt
                // mit einem konkreten Objekt 'gefüllt'.
                // Als Parameter werden die Frage, die Antworten und der Antworttyp übergeben.
                switch (ucQuizMode.Instance.Qt)
                {
                    case QuestionType.Capital:
                        questions[i] = new CapitalQuestion(
                            question, 
                            answers, 
                            ucQuizMode.Instance.At
                            );
                        break;
                    case QuestionType.Country:
                        questions[i] = new CountryQuestion(
                            question, 
                            answers, 
                            ucQuizMode.Instance.At
                            );
                        break;
                    case QuestionType.Flag:
                        questions[i] = new FlagQuestion(
                            question, 
                            answers, 
                            ucQuizMode.Instance.At
                            );
                        break;
                }
            }
        }

        private void CreateQuiz()
        {
            // Frage, Anworten und Ergebnis entfernen
            grpQuestion.Controls.Clear();
            panAnswers.Controls.Clear();
            pbResult.Image = null;
            lblResult.Text = null;

            // Buttons aktivieren und deaktivieren
            btnNextQuestion.Enabled = false;
            btnAnswer.Enabled = true;

            // Frage anzeigen
            grpQuestion.Controls.Add(questions[questionIndex].GetContent());

            // Anworten anzeigen
            foreach (Answer answer in questions[questionIndex].Answers)
            {
                panAnswers.Controls.Add(answer.GetContent());
            }

            // Index erhöhen
            questionIndex++;
        }

        private void CheckAnswer()
        {
            // Markierte Antwort suchen. In dem Panel panAnswers
            // nach einem RadioButton suchen, der den Status checked hat.
            RadioButton clickedAnswer = panAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            // Richtige Antwort suchen. Da die Antworten im Tag den Status ("True"/"False") gepeichert haben,
            // suchen wir im Panel panAnswers nach einem RadioButton,
            // der als Tag "True" hat.
            RadioButton correctAnswer = panAnswers.Controls.OfType<RadioButton>()
                .First(r => r.Tag.ToString() == "True");

            if (clickedAnswer != null)
            {
                // Richtige Antwort
                if (clickedAnswer.Tag.ToString() == "True")
                {
                    clickedAnswer.ForeColor = Color.Green;
                    lblResult.Text = "Richtig!";
                }
                // Falsche Antwort
                else
                {
                    clickedAnswer.ForeColor = Color.Red;
                    correctAnswer.ForeColor = Color.Green;
                    lblResult.Text = "Falsch.\nRichtige Antwort: " + correctAnswer.Text;

                    ResourceManager rm = Resources.ResourceManager;
                    Image image = (Bitmap)rm.GetObject(correctAnswer.Name.ToLower());

                    // In CorrectAnswer.Name steht entweder eine Stadt ("Berlin"), ein Land ("Deutschland")
                    // oder die Länderkennung ("DE").
                    // Die Bilder der Flaggen sind als Resource mit der Länderkennung als Name gepeichert, zb: "de.png".
                    // image gibt nur einen Wert zurück, wenn in CorrectAnswer.Name die Länderkennung steht.
                    // Somit war die Antwort eine Flagge und kann angezeigt werden.
                    if (image != null)
                    {
                        pbResult.Image = image;
                        pbResult.Size = new Size(image.Width + 20, image.Height);
                    }
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
            CheckAnswer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _instance = null;
            App app = (App)Parent.Parent;
            app.QuizMode();
        }
    }
}
