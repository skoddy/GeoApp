using GeoApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public class FlagAnswer : Answer
    {
        public FlagAnswer(GeoData data) : base(data)
        {
        }

        public override string Text { get; set; }
        public override bool State { get; set; }

        public override RadioButton GetContent()
        {
            ResourceManager rm = Resources.ResourceManager;
            Image image = (Bitmap)rm.GetObject(Text.ToLower());
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
