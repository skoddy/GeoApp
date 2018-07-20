using System.Collections.Generic;

namespace GeoApp
{
    public abstract class Question<T> : IContent
    {
        // Der Konstruktor ruft die Factory Methode auf.
        public Question(GeoData data, Database db)
        {
            CreateAnswers(data, db);
        }
        public abstract GeoData CorrectAnswer { get; set; }
        public abstract List<GeoData> WrongAnswers { get; set; }
        public abstract List<GeoData> AllAnswers { get; set; }
        public abstract string Text { get; set; }
        public List<Answer<T>> Answers { get; } = new List<Answer<T>>();
        public abstract T GetContent();

        // Die Factory Methode!!
        public abstract void CreateAnswers(GeoData data, Database db);

        object IContent.GetContent()
        {
            return GetContent();
        }
    }

}