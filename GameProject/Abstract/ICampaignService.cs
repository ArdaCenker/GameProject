using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampaignService
    {
        void CalculateSale(Games game);
        void SaleInfo(Games game);
    }
}
