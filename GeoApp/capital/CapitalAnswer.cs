using System.Drawing;
using System.Windows.Forms;

namespace GeoApp
{
    public class CapitalAnswer : Answer<Label>
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

        public override Label GetContent()
        {
            Label lbl = new Label
            {
                Name = Text,
                Text = Text,
                Location = new Point(PosX + 40, PosY),
                AutoSize = true
            };

            return lbl;
        }

        public override RadioButton RadioButton()
        {
            RadioButton rb = new RadioButton
            {
                Tag = Text,
                Name = State.ToString(),
                Text = "",
                Location = new Point(PosX, PosY),
                AutoSize = true
            };

            return rb;
        }
    }
}
