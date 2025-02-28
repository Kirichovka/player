using System;
using System.Drawing;
using System.Windows.Forms;
using YoutubeMusic.UI.song_info_UI.additionInfo;

namespace YoutubeMusic.UI.song_info_UI
{
    public partial class SongInfoControl : UserControl
    {
        private AdditionInfouserControl additionInfouserControl;

        public SongInfoControl()
        {
            InitializeComponent();

            additionInfouserControl = new AdditionInfouserControl
            {
                Location = new Point(0, 0),
                Size = new Size(919, 70)
            };

            additionalInformationPanel.Controls.Add(additionInfouserControl);

            additionalInformationPanel.MouseWheel += AdditionalInformationPanel_MouseWheel;
            this.MouseWheel += AdditionalInformationPanel_MouseWheel;

            additionalInformationPanel.MouseEnter += (sender, e) => additionalInformationPanel.Focus();
        }

        private void AdditionalInformationPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            int scrollAmount = 20;

            int newX = additionInfouserControl.Location.X + (e.Delta > 0 ? scrollAmount : -scrollAmount);

            int minX = additionalInformationPanel.Width - additionInfouserControl.Width;
            int maxX = 0;

            newX = Math.Max(minX, Math.Min(maxX, newX));

            additionInfouserControl.Location = new Point(newX, additionInfouserControl.Location.Y);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            AdditionalInformationPanel_MouseWheel(this, e);
        }
    }
}
