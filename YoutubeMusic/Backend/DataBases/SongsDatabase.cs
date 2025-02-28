using System;
using System.Collections.Generic;
using System.IO;

namespace YoutubeMusic.DataBase
{
    public class SongsDatabase
    {
        public List<Song> AllSongs { get; private set; }

        public SongsDatabase(string basePath)
        {
            AllSongs = new List<Song>();
            LoadSongs(basePath);
        }

        private void LoadSongs(string basePath)
        {
            if (!Directory.Exists(basePath))
            {
                Console.WriteLine("Ошибка: Папка с песнями не найдена!");
                return;
            }

            foreach (string artistFolder in Directory.GetDirectories(basePath))
            {
                string artistName = Path.GetFileName(artistFolder);

                foreach (string songFolder in Directory.GetDirectories(artistFolder))
                {
                    string songTitle = Path.GetFileName(songFolder);
                    Song song = new Song(songTitle, artistName, songFolder);
                    AllSongs.Add(song);
                }
            }

            Console.WriteLine($"Загружено {AllSongs.Count} песен.");
        }

        public void ShowAllSongs()
        {
            Console.WriteLine("Все песни:");
            foreach (var song in AllSongs)
            {
                Console.WriteLine($"- {song} | Lyrics: {(song.Lyrics != null ? "✅" : "❌")} | Cover: {(song.CoverPath != null ? "✅" : "❌")}");
            }
        }
    }
}
