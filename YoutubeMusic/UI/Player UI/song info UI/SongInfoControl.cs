using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using YoutubeMusic.UI.song_info_UI.additionInfo;
using YoutubeMusic.DataBase; // ✅ Подключаем SongsDatabase

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

            // Добавляем обработчики событий
            additionalInformationPanel.MouseWheel += AdditionalInformationPanel_MouseWheel;
            this.MouseWheel += AdditionalInformationPanel_MouseWheel;
            additionalInformationPanel.MouseEnter += (sender, e) => additionalInformationPanel.Focus();
        }

        private void AdditionalInformationPanel_MouseWheel(object? sender, MouseEventArgs e)
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

        /// <summary>
        /// Загружает обложку песни.
        /// </summary>
        public void SetSongCover(Song selectedSong)
        {
            if (selectedSong == null)
                return;

            try
            {
                string coverPath = selectedSong.CoverPath;

                // Если у песни нет обложки, берём стандартную картинку из базы
                if (string.IsNullOrEmpty(coverPath) || !File.Exists(coverPath))
                {
                    coverPath = SongsDatabase.DefaultCoverPath; // ✅ Загружаем дефолтное изображение
                }

                if (File.Exists(coverPath))
                {
                    coverPictureBox.Image?.Dispose(); // Освобождаем память
                    coverPictureBox.Image = Image.FromFile(coverPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки обложки: {ex.Message}");
            }
        }
    }
}
