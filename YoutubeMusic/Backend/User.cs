using System;
using System.Collections.Generic;

namespace YoutubeMusic.Backend
{
    public class User
    {
        public string Username { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public User(string username)
        {
            Username = username;
            FavoriteSongs = new List<Song>();
        }

        public void AddToFavorites(Song song)
        {
            if (!FavoriteSongs.Contains(song))
            {
                FavoriteSongs.Add(song);
                Console.WriteLine($"Добавлено в избранное: {song}");
            }
        }

        public void RemoveFromFavorites(Song song)
        {
            if (FavoriteSongs.Contains(song))
            {
                FavoriteSongs.Remove(song);
                Console.WriteLine($"Удалено из избранного: {song}");
            }
        }

        public void ShowFavorites()
        {
            Console.WriteLine($"Избранные песни ({Username}):");
            foreach (var song in FavoriteSongs)
                Console.WriteLine($"- {song}");
        }
    }
}
