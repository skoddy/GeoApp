using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public class CountryQuestion : Question
    {
        Random gen;
 

        public CountryQuestion(GeoData question, List<GeoData> answers, AnswerType at, string continent = "") : base(question, answers, at, continent)
        {
            Text = question.Country;
        }

        public override AnswerType At { get; set; }
        public override GeoData CorrectAnswer { get; set; }
        public override List<GeoData> WrongAnswers { get; set; }
        public override List<GeoData> AllAnswers { get; set; }
        public override string Text { get; set; }

        public override void CreateAnswers(GeoData question, List<GeoData> answers, AnswerType at, string continent = "")
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
                case AnswerType.Capital:
                    Answers.Add(new CapitalAnswer(10, 20, AllAnswers[0]));
                    Answers.Add(new CapitalAnswer(10, 40, AllAnswers[1]));
                    Answers.Add(new CapitalAnswer(10, 60, AllAnswers[2]));
                    Answers.Add(new CapitalAnswer(10, 80, AllAnswers[3]));
                    break;
                case AnswerType.Flag:
                    Answers.Add(new FlagAnswer(10, 20, AllAnswers[0]));
                    Answers.Add(new FlagAnswer(10, 80, AllAnswers[1]));
                    Answers.Add(new FlagAnswer(10, 140, AllAnswers[2]));
                    Answers.Add(new FlagAnswer(10, 200, AllAnswers[3]));
                    break;
                default:
                    break;
            }
        }

        public override Label GetContent()
        {
            Label lbl = new Label
            {
                Name = "lblQuestion",
                Text = Text,
                Location = new Point(10, 20)
            };

            lbl.Font = new Font(lbl.Font.FontFamily, 14);

            return lbl;
        }
    }
}
