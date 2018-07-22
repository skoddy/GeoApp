using System.Drawing;
using System.Windows.Forms;

namespace GeoApp
{
    public class CountryAnswer : Answer
    {
        public CountryAnswer(GeoData data) : base(data)
        {
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