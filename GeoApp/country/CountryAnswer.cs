﻿using System.Drawing;
using System.Windows.Forms;

namespace GeoApp
{
    public class CountryAnswer : Answer
    {
        public CountryAnswer(GeoData data) : base(data)
        {
            Text = data.Country;
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
                AutoSize = true
            };

            return rb;
        }
    }
}