using System.Windows.Forms;

namespace GeoApp
{
    public abstract class Answer<T> : IContent
    {
        public abstract int PosX { get; set; }
        public abstract int PosY { get; set; }
        public abstract string Text { get; set; }
        public abstract bool State { get; set; }
        public Answer(int posX, int posY, GeoData data) { }

        public abstract T GetContent();
        public abstract RadioButton RadioButton();

        object IContent.GetContent()
        {
            return GetContent();
        }
    }
}