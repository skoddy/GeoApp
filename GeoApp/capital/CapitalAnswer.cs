using System.Drawing;
using System.Windows.Forms;

namespace GeoApp
{
    public class CapitalAnswer : Answer
    {
        public CapitalAnswer(int posX, int posY, GeoData data) : base(posX, posY, data)
        {
            PosX = posX;
            PosY = posY;
            Text = data.Capital;
            State = data.State;
        }

        public override int PosX { get; set; }
        public override int PosY { get; set; }
        public override string Text { get; set; }
        public override bool State { get; set; }

        public override RadioButton GetContent()
        {
            RadioButton rb = new RadioButton
            {
                Tag = State.ToString(),
                Name = Text,
                Text = Text,
                Location = new Point(PosX, PosY),
                AutoSize = true
            };

            return rb;
        }
    }
}
