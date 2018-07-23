using System.Windows.Forms;

namespace GeoApp
{
    public class CapitalAnswer : Answer
    {
        public CapitalAnswer(GeoData data) : base(data)
        {
            Text = data.Capital;
            State = data.State;
        }

        public override string Text { get; set; }
        public override bool State { get; set; }

        public override RadioButton GetContent()
        {
            RadioButton rb = new RadioButton
            {
                Tag = State.ToString(),
                Name = Text,
                Text = Text,
                AutoSize = true
            };

            return rb;
        }
    }
}
