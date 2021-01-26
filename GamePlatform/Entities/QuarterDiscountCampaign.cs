using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Entities
{
    class QuarterDiscountCampaign : ICampaignServices
    {
        public void CalculateDiscount(Game game)
        {
            game.GamePrice -= game.GamePrice * (0.25);
        }

        public void DiscountInfo(Game game)
        {
            Console.WriteLine("Quarter Discount Applied");
            Console.WriteLine(game.GameName + "'s new price is : " + game.GamePrice);
        }
    }
}
