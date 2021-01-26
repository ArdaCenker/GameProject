using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    class GameManager
    {
        List<Games> games = new List<Games>() { };

        public void Add(Games game)
        {
            games.Add(game);
            Console.WriteLine(game.GameName + " isimli oyun eklendi.");
        }

        public void Update(Games game)
        {
            Console.WriteLine(game.GameName + " isimli oyun güncellendi.");
        }

        public void Delete(string GameName)
        {
            foreach (var game in games)
            {
                if (game.GameName == GameName)
                {
                    games.Remove(game);
                    Console.WriteLine(game.GameName + " isimli oyun sistemden silindi.");
                    break;
                }

                else
                {
                    continue;
                }
            }

        }

        public void BuyGame(string GameName, ICampaignService campaign)
        {
            foreach (var game in games)
            {
                if (game.GameName == GameName)
                {
                    campaign.CalculateSale(game);
                    campaign.SaleInfo(game);
                }

                else
                {
                    continue;
                }
            }
        }
    }
}

