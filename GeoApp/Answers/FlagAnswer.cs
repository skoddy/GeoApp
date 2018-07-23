using GeoApp.Properties;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace GeoApp
{
    public class FlagAnswer : Answer
    {
        public FlagAnswer(GeoData data) : base(data)
        {
            Text = data.Flag;
            State = data.State;
        }

        public override string Text { get; set; }
        public override bool State { get; set; }

        public override RadioButton GetContent()
        {
            ResourceManager rm = Resources.ResourceManager;

            Image image = (Bitmap)rm.GetObject(Text);

            // Ich habe nicht überprüft ob alle Flaggen vorhanden sind. (250 Stk.)
            // falls eine fehlt, kommt diese Ausgabe
            if(image == null)
            {
                MessageBox.Show(Text);
            }

            RadioButton rb = new RadioButton
            {
                Tag = State.ToString(),
                Name = Text,
                Size = new Size(image.Width + 20, image.Height),
                Image = image
            };

            return rb;
        }
    }
}
