using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Entities
{
    class HalfDiscountCampaign : ICampaignServices
    {
        public void CalculateDiscount(Game game)
        {
            game.GamePrice -= game.GamePrice * (0.5);
        }

        public void DiscountInfo(Game game)
        {
            Console.WriteLine("Half Discount Applied");
            Console.WriteLine(game.GameName + "'s new price is : " + game.GamePrice);
        }
    }
}
