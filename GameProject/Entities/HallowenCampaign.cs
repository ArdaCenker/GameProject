using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class HallowenCampaign : ICampaignService
    {
        public void CalculateSale(Games game)
        {
            game.GamePrice = game.GamePrice - game.GamePrice * 0.25;
        }

        public void SaleInfo(Games game)
        {
            Console.WriteLine(game.GameName + " isimli oyuna Cadılar Bayramı kampanyası uygulandı. Yeni Fiyat: " + game.GamePrice + " TL");
        }
    }
}
