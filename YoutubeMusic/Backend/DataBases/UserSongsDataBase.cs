using System;
using System.Collections.Generic;

namespace YoutubeMusic.DataBases
{
    public class UserSongsDatabase
    {
        public List<YoutubeMusic.Backend.User> Users { get; private set; }

        public UserSongsDatabase()
        {
            Users = new List<YoutubeMusic.Backend.User>();
        }

        public void AddUser(YoutubeMusic.Backend.User user)
        {
            if (!Users.Contains(user))
            {
                Users.Add(user);
                Console.WriteLine($"Добавлен пользователь: {user.Username}");
            }
        }
        public YoutubeMusic.Backend.User? GetUser(string username)
        {
            return Users.FirstOrDefault(u => u.Username == username);
        }

        public void ShowAllUsers()
        {
            Console.WriteLine("Все пользователи:");
            foreach (var user in Users)
                Console.WriteLine($"- {user.Username}");
        }
    }
}
