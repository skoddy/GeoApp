using GeoApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public class FlagQuestion : Question
    {
        Random gen;

        public FlagQuestion(GeoData question, List<GeoData> answers, AnswerType at, string continent) 
            : base(question, answers, at, continent)
        {
            Text = question.Flag.ToLower();
        }

        public override AnswerType At { get; set; }
        public override GeoData CorrectAnswer { get; set; }
        public override List<GeoData> WrongAnswers { get; set; }
        public override List<GeoData> AllAnswers { get; set; }
        public override string Text { get; set; }

        public override void CreateAnswers(GeoData question, List<GeoData> answers, AnswerType at, string continent)
        {
  
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
            AllAnswers.Insert(gen.Next(0, 4), CorrectAnswer);

            switch (At)
            {
                case AnswerType.Country:
                    Answers.Add(new CountryAnswer(10, 20, AllAnswers[0]));
                    Answers.Add(new CountryAnswer(10, 40, AllAnswers[1]));
                    Answers.Add(new CountryAnswer(10, 60, AllAnswers[2]));
                    Answers.Add(new CountryAnswer(10, 80, AllAnswers[3]));
                    break;
                case AnswerType.Capital:
                    Answers.Add(new CapitalAnswer(10, 20, AllAnswers[0]));
                    Answers.Add(new CapitalAnswer(10, 40, AllAnswers[1]));
                    Answers.Add(new CapitalAnswer(10, 60, AllAnswers[2]));
                    Answers.Add(new CapitalAnswer(10, 80, AllAnswers[3]));
                    break;

                default:
                    break;
            }

        }

        public override Label GetContent()
        {
            ResourceManager rm = Resources.ResourceManager;
            Image image = (Bitmap)rm.GetObject(Text.ToLower());
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
