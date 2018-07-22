using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class ucUser : UserControl
    {
        // Singleton Pattern
        private static ucUser _instance;

        public static ucUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucUser();
                }
                return _instance;
            }
        }

        public ucUser()
        {
            InitializeComponent();
            tbDisplayName.Text = User.Instance.DisplayName;
        }

        private void SaveDisplayName(object sender, EventArgs e)
        {
            if (tbDisplayName.Text.Length >= 3)
            {
                User.Instance.DisplayName = tbDisplayName.Text;
                User.Instance.Score = 0;
                App app = (App)Parent.Parent;
                app.QuizConfig();
                _instance = null;
            }
        }
    }
}
