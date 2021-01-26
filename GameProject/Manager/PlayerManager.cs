using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    class PlayerManager
    {
        List<Player> players = new List<Player>() { };
        public void Add(Player player)
        {
            players.Add(player);
            Console.WriteLine(player.PlayerFirstName + " " + player.PlayerLastName + " isimli oyuncu sisteme eklendi!");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi : " + player.PlayerFirstName);
        }

        public void Delete(string TcNo)
        {
            foreach (var player in players)
            {
                if (player.TcNo == TcNo)
                {
                    players.Remove(player);
                    Console.WriteLine(player.PlayerFirstName + " " + player.PlayerLastName + "isimli oyuncu sistemden silindi.");
                }

                else
                {
                    continue;
                }
            }
        }
    }
}
