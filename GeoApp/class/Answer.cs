using System.Windows.Forms;

namespace GeoApp
{
    public abstract class Answer
    {
        public abstract int PosX { get; set; }
        public abstract int PosY { get; set; }
        public abstract string Text { get; set; }
        public abstract bool State { get; set; }
        public Answer(int posX, int posY, GeoData data)
        {
            PosX = posX;
            PosY = posY;
            Text = data.Flag;
            State = data.State;
        }
        public abstract RadioButton GetContent();

    }
}