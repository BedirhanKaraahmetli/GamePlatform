using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Entities;

namespace GamePlatform.Managers
{
    class GameManager
    {
        List<Game> games = new List<Game>() { };
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.GameName + " is added to the system." + "\n ");
        }
        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " is updated." + "\n ");
        }
        public void Delete(string GameName)
        {
            foreach (var game in games)
            {
                if (game.GameName == GameName)
                {
                    games.Remove(game);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public void GetGame(string GameName, ICampaignServices campaign)
        {
            foreach (var namegame in games)
            {
                if (namegame.GameName == GameName)
                {
                    campaign.CalculateDiscount(namegame);
                    campaign.DiscountInfo(namegame);

                }

                else
                {
                    continue;
                }
            }
        }
        public void List()
        {
            Console.WriteLine("Games;");
            int i = 1;
            foreach (var game in games)
            {
                Console.WriteLine("Name : " + game.GameName + " Type : " + game.GameType +  " Price : " + game.GamePrice);
            }
        }

    }
}
