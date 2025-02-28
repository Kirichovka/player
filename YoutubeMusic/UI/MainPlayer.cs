using YoutubeMusic.UI.Player_UI;
using YoutubeMusic.UI.Player_UI.footer;
using YoutubeMusic.UI.PlayList_UI;
using YoutubeMusic.UI.song_info_UI;

namespace YoutubeMusic
{
    public partial class MainPlayer : Form

    {
        private SongInfoControl songInfoControl = new SongInfoControl();
        private PlayerElements playerElements = new PlayerElements();
        private Footer footer = new Footer();
        private PlayList playList = new PlayList();

        public MainPlayer()
        {
            InitializeComponent();
            ShowPlayer();

            footer.OpenPlayerRequested += Footer_OpenPlayerRequested;
            footer.OpenPlayListRequested += Footer_OpenPlayListRequested;
        }
        private void Footer_OpenPlayerRequested(object sender, EventArgs e)
        {
            ShowPlayer();
        }
        private void Footer_OpenPlayListRequested(object sender, EventArgs e)
        {
            ShowPlayList();
        }
        private void ShowPlayList()
        {
            PlayerTableLayoutPanel.Controls.Clear();
            PlayerTableLayoutPanel.RowCount = 2; 

            PlayerTableLayoutPanel.RowStyles.Clear();
            PlayerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); 
            PlayerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));

            PlayerTableLayoutPanel.Controls.Add(playList, 0, 0);
            PlayerTableLayoutPanel.Controls.Add(footer, 0, 1);
        }

        private void ShowPlayer()
        {
            PlayerTableLayoutPanel.Controls.Clear();
            SetupTableLayout(); 

            PlayerTableLayoutPanel.Controls.Add(songInfoControl, 0, 0);
            PlayerTableLayoutPanel.Controls.Add(playerElements, 0, 1);
            PlayerTableLayoutPanel.Controls.Add(footer, 0, 2);
        }

        private void SetupTableLayout()
        {
            PlayerTableLayoutPanel.RowCount = 3;

            PlayerTableLayoutPanel.RowStyles.Clear();

            PlayerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80));

            PlayerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18));

            PlayerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
        }


    }
}
