using System;
using System.Drawing;
using System.Windows.Forms;

namespace YoutubeMusic.UI.Player_UI
{
    public partial class PlayerElements : UserControl
    {
        private SeekBar seekBar;

        public PlayerElements()
        {
            InitializeComponent();

            // Создаём SeekBar
            seekBar = new SeekBar
            {
                Location = new Point(0, 0),
                Dock = DockStyle.Fill,
                BackColor = Color.Black
            };

            seekBarPanel.Controls.Add(seekBar);

            seekBar.SetBuffered(0.7f);
            seekBar.SetProgress(0.3f);
        }
    }
}
