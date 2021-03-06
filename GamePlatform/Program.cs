﻿using System;
using System.Collections.Generic;
using GamePlatform.Entities;
using GamePlatform.Managers;

namespace GamePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            GameManager gameManager = new GameManager();
            while (true)
            {
                Console.WriteLine("*******************MENU*******************");
                Console.WriteLine("1-) Add Gamer\n2-) Delete Gamer\n3-) List Gamer\n4-) Add Game\n5-) Delete Game\n6-) List Game\n7-) Sell Game\n8-) Exit");
                Console.WriteLine("******************************************");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (choice == 1)
                {
                    Console.WriteLine("Enter the information of the player you want to add");
                    Console.WriteLine("Id:            (Only Numbers)");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("First Name: ");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Last Name: ");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Nationality Id: ");
                    string NationalityId = Console.ReadLine();
                    Console.WriteLine("Year of Birth:             (Only 4 digit number) ");
                    long YearOfBirth = Convert.ToInt32(Console.ReadLine());
                    gamerManager.Add(new Gamer() { Id = Id, FirstName = FirstName, LastName = LastName, NationalityId = NationalityId, YearOfBirth = YearOfBirth });
                    Console.Clear();
                }

                else if (choice == 2)
                {
                    gamerManager.List();
                    Console.WriteLine("Enter the id of the player you want to delete : ");
                    gamerManager.Delete(Convert.ToInt32(Console.ReadLine()));
                    Console.Clear();
                }

                else if (choice == 3)
                {
                    gamerManager.List();
                } 

                else if (choice == 4)
                {
                    Console.WriteLine("Enter the information of the game you want to add : ");
                    Console.WriteLine("Game Name : ");
                    string GameName = Console.ReadLine();
                    Console.WriteLine("Game Type : ");
                    string GameType = Console.ReadLine();
                    Console.WriteLine("Game Price : ");
                    double GamePrice = Convert.ToDouble(Console.ReadLine());
                    gameManager.Add(new Game() { GameName = GameName, GameType = GameType, GamePrice = GamePrice });
                    Console.Clear();
                }

                else if (choice == 5)
                {
                    gameManager.List();
                    Console.WriteLine("Enter the name of the game you want to delete : ");
                    gameManager.Delete(Console.ReadLine());
                    Console.Clear();
                }

                else if (choice == 6)
                {
                    gameManager.List();
                }

                else if (choice == 7)
                {
                    while (true)
                    {
                        Console.WriteLine("***********Choose a Campaign***********");
                        Console.WriteLine("1-) Quarter Discount Campaign\n2-) Half Discount Campaign" );
                        Console.WriteLine("***************************************");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (choice2==1)
                        {
                            gameManager.List();
                            Console.WriteLine("Which game would you like to apply a quarter discount");
                            string namegame = Console.ReadLine();
                            Console.Clear();
                            ICampaignServices campaign = new QuarterDiscountCampaign();
                            gameManager.GetGame(namegame, campaign);
                            gamerManager.List();
                            Console.WriteLine("Who is buying this game");
                            string namegamer = Console.ReadLine();
                            Console.WriteLine(namegame + " selled to the " + namegamer);
                            gameManager.Delete(namegame);
                            break;
                        }

                        else if (choice2 == 2)
                        {
                            gameManager.List();
                            Console.WriteLine("Which game would you like to apply a half discount");
                            string namegame = Console.ReadLine();
                            Console.Clear();
                            ICampaignServices campaign = new HalfDiscountCampaign();
                            gameManager.GetGame(namegame, campaign);
                            gamerManager.List();
                            Console.WriteLine("Who is buying this game");
                            string namegamer = Console.ReadLine();
                            Console.WriteLine(namegame + " selled to the " + namegamer);
                            gameManager.Delete(namegame);
                            break;
                        }

                        else
                        {
                            break;
                        }
                    }

                }

                else
                {
                    break;
                }

            }





        }
    }
}
