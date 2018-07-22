using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeoApp
{
    public abstract class Question
    {
        // Der Konstruktor ruft die Factory Methode auf.
        public Question(GeoData question, List<GeoData> anwers, AnswerType at, string continent = "")
        {
            CreateAnswers(question, anwers, at, continent);
        }

        public abstract AnswerType At { get; set; }
        public abstract GeoData CorrectAnswer { get; set; }
        public abstract List<GeoData> WrongAnswers { get; set; }
        public abstract List<GeoData> AllAnswers { get; set; }
        public abstract string Text { get; set; }
        public List<Answer> Answers { get; } = new List<Answer>();
        public abstract Label GetContent();

        // Die Factory Methode!!
        public abstract void CreateAnswers(GeoData question, List<GeoData> anwers, AnswerType at, string continent = "");

    }

}