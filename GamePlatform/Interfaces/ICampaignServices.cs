using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Entities;

namespace GamePlatform
{
    interface ICampaignServices
    {
        void CalculateDiscount(Game game);
        void DiscountInfo(Game game);
        
    }
}
