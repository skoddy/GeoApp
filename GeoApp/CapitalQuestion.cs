using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GeoApp
{
    public class CapitalQuestion : Question<Label>
    {
        Random gen = new Random();
        Database _db;

        public CapitalQuestion(GeoData data, Database db) : base(data, db)
        {
            Text = data.Capital;
        }

        public override List<GeoData> WrongAnswers { get; set; }
        public override List<GeoData> AllAnswers { get; set; }
        public override string Text { get; set; }
        public override GeoData CorrectAnswer { get; set; }

        public override void CreateAnswers(GeoData data, Database db)
        {
            _db = db;

            CorrectAnswer = data;
            CorrectAnswer.State = true;

            WrongAnswers = new List<GeoData>();
            WrongAnswers = _db.GetFalseAnswers(CorrectAnswer.Id);

            AllAnswers = new List<GeoData>();
            AllAnswers.Add(WrongAnswers[0]);
            AllAnswers.Add(WrongAnswers[1]);
            AllAnswers.Add(WrongAnswers[2]);
            AllAnswers.Insert(gen.Next(0, 4), CorrectAnswer);

            Answers.Add(new CountryAnswer(10, 20, AllAnswers[0]));
            Answers.Add(new CountryAnswer(10, 40, AllAnswers[1]));
            Answers.Add(new CountryAnswer(10, 60, AllAnswers[2]));
            Answers.Add(new CountryAnswer(10, 80, AllAnswers[3]));
        }

        public override Label GetContent()
        {
            Label lbl = new Label
            {
                Name = "lblQuestion",
                Text = Text,
                Location = new Point(10, 20)
            };

            return lbl;
        }
    }
}