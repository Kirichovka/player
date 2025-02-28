using System;
using System.IO;

namespace YoutubeMusic
{
    public class Song
    {
        public string Title { get; set; } // Название песни
        public string Artist { get; set; } // Исполнитель
        public string Lyrics { get; private set; } // Текст песни
        public string CoverPath { get; private set; } // Обложка
        public string FolderPath { get; private set; } // Папка с песней

        public Song(string title, string artist, string folderPath)
        {
            Title = title;
            Artist = artist;
            FolderPath = folderPath;

            LoadLyrics();
            LoadCover();
        }

        private void LoadLyrics()
        {
            string lyricsFile = Path.Combine(FolderPath, "lyrics.txt");
            Lyrics = File.Exists(lyricsFile) ? File.ReadAllText(lyricsFile) : null;
        }

        private void LoadCover()
        {
            string[] possibleCovers = { "cover.jpg", "cover.png" };
            foreach (var fileName in possibleCovers)
            {
                string coverPath = Path.Combine(FolderPath, fileName);
                if (File.Exists(coverPath))
                {
                    CoverPath = coverPath;
                    return;
                }
            }
            CoverPath = null;
        }

        public override string ToString()
        {
            return $"{Artist} - {Title}";
        }
    }
}
