using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Entities;

namespace GamePlatform
{
    class GamerManager
    {
        List<Gamer> gamers = new List<Gamer>() { };
        public void Add(Gamer gamer)
        {
            gamers.Add(gamer);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " has been added to the system." + "\n ");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " has been updated." + "\n ");

        }
        public void Delete(int Id)
        {
            foreach (var gamer in gamers)
            {
                if (gamer.Id == Id)
                {
                    gamers.Remove(gamer);
                    Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " has been deleted from the system." + "\n ");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public void List()
        {
            Console.WriteLine("Gamers;");
            foreach (var gamer in gamers)
            {
                Console.WriteLine("Id : " + gamer.Id + " Name : " + gamer.FirstName + " " + gamer.LastName);
            }
        }
    }
}
