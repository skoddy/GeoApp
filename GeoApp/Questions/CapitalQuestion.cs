using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GeoApp
{
    public class CapitalQuestion : Question
    {
        public override AnswerType At { get; set; }

        public CapitalQuestion(GeoData question, List<GeoData> answers, AnswerType at) 
            : base(question, answers, at)
        {
            Text = question.Capital;
        }

        public override List<GeoData> WrongAnswers { get; set; }
        public override List<GeoData> AllAnswers { get; set; }
        public override string Text { get; set; }
        public override GeoData CorrectAnswer { get; set; }

        public override void CreateAnswers(GeoData question, List<GeoData> answers, AnswerType at)
        {
 
            Random gen = new Random(Guid.NewGuid().GetHashCode());

            At = at;
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
                    Answers.Add(new CountryAnswer(AllAnswers[0]));
                    Answers.Add(new CountryAnswer(AllAnswers[1]));
                    Answers.Add(new CountryAnswer(AllAnswers[2]));
                    Answers.Add(new CountryAnswer(AllAnswers[3]));
                    break;
                case AnswerType.Flag:
                    Answers.Add(new FlagAnswer(AllAnswers[0]));
                    Answers.Add(new FlagAnswer(AllAnswers[1]));
                    Answers.Add(new FlagAnswer(AllAnswers[2]));
                    Answers.Add(new FlagAnswer(AllAnswers[3]));
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