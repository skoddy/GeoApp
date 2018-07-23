using GeoApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace GeoApp
{
    public class FlagQuestion : Question
    {
        public FlagQuestion(GeoData question, List<GeoData> answers, AnswerType at) 
            : base(question, answers, at)
        {
            Text = question.Flag.ToLower();
        }

        public override AnswerType At { get; set; }
        public override GeoData CorrectAnswer { get; set; }
        public override List<GeoData> WrongAnswers { get; set; }
        public override List<GeoData> AllAnswers { get; set; }
        public override string Text { get; set; }

        public override void CreateAnswers(GeoData question, List<GeoData> answers, AnswerType at)
        {
            Random gen = new Random(Guid.NewGuid().GetHashCode());

            At = at;
            gen = new Random(Guid.NewGuid().GetHashCode());
            CorrectAnswer = question;
            CorrectAnswer.State = true;

            WrongAnswers = new List<GeoData>();
            WrongAnswers = answers;

            AllAnswers = new List<GeoData>();
            AllAnswers.Add(WrongAnswers[0]);
            AllAnswers.Add(WrongAnswers[1]);
            AllAnswers.Add(WrongAnswers[2]);
            AllAnswers.Insert(gen.Next(4), CorrectAnswer);

            switch (At)
            {
                case AnswerType.Country:
                    Answers.Add(new CountryAnswer(AllAnswers[0]));
                    Answers.Add(new CountryAnswer(AllAnswers[1]));
                    Answers.Add(new CountryAnswer(AllAnswers[2]));
                    Answers.Add(new CountryAnswer(AllAnswers[3]));
                    break;
                case AnswerType.Capital:
                    Answers.Add(new CapitalAnswer(AllAnswers[0]));
                    Answers.Add(new CapitalAnswer(AllAnswers[1]));
                    Answers.Add(new CapitalAnswer(AllAnswers[2]));
                    Answers.Add(new CapitalAnswer(AllAnswers[3]));
                    break;

                default:
                    break;
            }

        }

        public override Label GetContent()
        {
            ResourceManager rm = Resources.ResourceManager;

            Image image = (Bitmap)rm.GetObject(Text);

            Label lbl = new Label
            {
                Size = new Size(image.Width, image.Height),
                Image = image,
                Location = new Point(14, 14)
            };

            return lbl;
        }
     }
}
