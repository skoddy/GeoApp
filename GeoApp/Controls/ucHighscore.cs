using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace GeoApp
{
    public partial class ucHighscore : UserControl
    {
        private static ucHighscore _instance;
        private List<Highscore> listHighscore;
        private Database db;
        public static ucHighscore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucHighscore();
                }
                return _instance;
            }
        }

        public ucHighscore()
        {
            InitializeComponent();
            db = new Database();
            listHighscore = db.GetHighscores();
            CreateHighscoreList();

        }

        private void CreateHighscoreList()
        {
            lvHighscores.Items.Clear();

            int rank = 1;
            foreach (Highscore highscore in listHighscore)
            {
                string[] row = { rank.ToString(), highscore.DisplayName, highscore.Score.ToString(), highscore.Date.ToString("dd.MM") };
                var listViewItem = new ListViewItem(row);
                lvHighscores.Items.Add(listViewItem);
                rank++;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _instance.SendToBack();
            _instance = null;
        }

        private void cbOnlyMine_CheckedChanged(object sender, EventArgs e)
        {
            if (User.Instance.Authed)
            {
                if (cbOnlyMine.Checked)
                {
                    listHighscore = db.GetHighscores(User.Instance.Id);
                    CreateHighscoreList();
                }
                else
                {
                    listHighscore = db.GetHighscores();
                    CreateHighscoreList();
                }
            }
            else
            {
                MessageBox.Show("Um Ihre persönlichen Bestzeiten zu sehen, müssen Sie sich erst anmelden.");
            }
        }

    }
}
