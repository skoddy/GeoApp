using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public class FlagAnswer : Answer
    {
        public FlagAnswer(int posX, int posY, GeoData data) : base(posX, posY, data)
        {
        }

        public override int PosX { get; set; }
        public override int PosY { get; set; }
        public override string Text { get; set; }
        public override bool State { get; set; }

        public override RadioButton GetContent()
        {
            Image image = null;
            RadioButton rb;

            try
            {
                image = Image.FromFile($"c:\\quiz\\{Text}.png");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Bild nicht gefunden: " + ex.Message);
            }

            rb = new RadioButton
            {
                Tag = State.ToString(),
                Name = Text,
                Location = new Point(PosX, PosY),
                Size = new Size(image.Width + 20, image.Height),
                Image = image
            };

            return rb;
        }
    }
}
