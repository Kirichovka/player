using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeMusic.UI.Player_UI.footer
{
    public partial class Footer : UserControl
    {
        public event EventHandler OpenPlayerRequested;
        public event EventHandler OpenPlayListRequested;
        public Footer()
        {
            InitializeComponent();
            OpenPlayerRequested += delegate { };
            OpenPlayListRequested += delegate { };
        }

        private void PlayerButton_Click(object sender, EventArgs e)
        {
            OpenPlayerRequested?.Invoke(this, EventArgs.Empty);
        }

        private void PlayListButton_Click(object sender, EventArgs e)
        {
            OpenPlayListRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
