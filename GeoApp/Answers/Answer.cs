using System.Windows.Forms;

namespace GeoApp
{
    // Abstrakte Antwort Klasse
    public abstract class Answer
    {
        public abstract string Text { get; set; }
        public abstract bool State { get; set; }
        public Answer(GeoData data) { }
        public abstract RadioButton GetContent();

    }
}