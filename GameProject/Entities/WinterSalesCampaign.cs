using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class WinterSalesCampaign : ICampaignService
    {
        public void CalculateSale(Games game)
        {
            game.GamePrice = game.GamePrice - game.GamePrice * 0.3;
        }

        public void SaleInfo(Games game)
        {
            Console.WriteLine(game.GameName + " isimli oyuna öğrenci kampanyası uygulandı. Yeni Fiyat: " + game.GamePrice + " TL" );
        } 
    }
}
