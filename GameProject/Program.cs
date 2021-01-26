using GameProject.Entities;
using GameProject.Abstract;
using GameProject.Manager;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() { PlayerFirstName = "Arda Cenker", PlayerLastName = "Karagöz", Birthday = 2005, TcNo = "456161268486" };
            Player player2 = new Player() { PlayerFirstName = "Ahmet", PlayerLastName = "Uçan", Birthday = 2009, TcNo = "516515455135" };
            Player player3 = new Player() { PlayerFirstName = "Burak", PlayerLastName = "Kuş", Birthday = 2007, TcNo = "115156456166" };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Update(player2);
            playerManager.Delete("115156456166");

            Games game1 = new Games();
            game1.GameName = "Assassin's Creed : Valhalla";
            game1.GameType = "Open World Action";
            game1.GameId = 1;
            game1.GamePrice = 249.90;

            Games game2 = new Games();
            game2.GameName = "Need For Speed : Heat";
            game2.GameType = "Racing";
            game2.GameId = 2;
            game2.GamePrice = 149.90;

            Games game3 = new Games();
            game3.GameName = "Doom Eternal";
            game3.GameType = "FPS Shooter";
            game3.GameId = 3;
            game3.GamePrice = 119.90;

            Games game4 = new Games();
            game4.GameName = "Euro Truck Simulator";
            game4.GameType = "Simulation";
            game4.GameId = 4;
            game4.GamePrice = 29.90;

            GameManager games = new GameManager();
            games.Add(game1);
            games.Update(game2);
            games.Delete("Doom Eternal");
            //games.BuyGame("Euro Truck Simulator");



        }
    }
}
