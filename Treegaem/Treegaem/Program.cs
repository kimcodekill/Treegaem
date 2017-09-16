﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treegaem
{
    class Program
    {
        public static int Money { get; set; }
        public static bool Done { get; set; }
        public static List<Tree> TreesDB = new List<Tree>();
        public static List<Tree> Trees = new List<Tree>();


        static void Main(string[] args)
        {
            //vars
            
            Random r = new Random();
            Money = 0;
            int difficulty;
            int buyTree;
            Done = false;
            int menu = 0;

            //Counters for things
            int c = 1;

            //Create some trees
            TreesDB.Add(new Tree()
            {
                TreeType = "Apple",
                Growth = 0.1,
                Price = 250,
                FruitGrowth = 0.3,
                FruitDecay = 1.2,
                Height = 0.5
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Pear",
                Growth = 0.15,
                Price = 350,
                FruitGrowth = 0.25,
                FruitDecay = 1.4,
                Height = 0.5
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Orange",
                Growth = 0.05,
                Price = 600,
                FruitGrowth = 0.15,
                FruitDecay = 1.5,
                Height = 0.5
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Banana",
                Growth = 0.5,
                Price = 750,
                FruitGrowth = 0.2,
                FruitDecay = 1.3,
                Height = 1.5
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Peach",
                Growth = 0.25,
                Price = 500,
                FruitGrowth = 0.6,
                FruitDecay = 1.5,
                Height = 0.5
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Cherry",
                Growth = 0.05,
                Price = 500,
                FruitGrowth = 0.95,
                FruitDecay = 1.65,
                Height = 0.5
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Pine",
                Growth = 0.6,
                Price = 150,
                FruitGrowth = 0.05,
                FruitDecay = 1.01,
                Height = 0.02
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Oak",
                Growth = 0.05,
                Price = 1000,
                FruitGrowth = 0.05,
                FruitDecay = 1.01,
                Height = 0.02
            });

            //Welcome message
            Console.WriteLine("When making inputs, please make sure to only use numbers unless specified otherwise.");


            //Difficulty menu
            do
            {
                Console.WriteLine("Choose difficulty: ");
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Hard");
                Console.WriteLine("0. Exit");
                difficulty = int.Parse(Console.ReadLine());

                switch (difficulty)
                {
                    case 1:
                        Money = 5000;
                        Done = true;
                        break;

                    case 2:
                        Money = 2000;
                        Done = true;
                        break;

                    case 3:
                        Money = 500;
                        Done = true;
                        break;
                    case 0:
                        Terminate();
                        break;

                    default:
                        WrongInput(difficulty);
                        break;
                }
            }
            while (!Done);



            Console.Clear();
            //Menu
            do
            {
                Console.WriteLine("Do you want to: ");
                Console.WriteLine("1. Buy some trees?");
                Console.WriteLine("2. Check on you plantation?");
                Console.WriteLine("3. Harvest some trees?");
                Console.WriteLine("4. Sell some trees?");
                Console.WriteLine("0. Exit");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        //Print all trees
                        Console.WriteLine(string.Format("You have {0} moneys", Money));
                        foreach (Tree t in TreesDB)
                        {
                            Console.WriteLine(string.Format("{0}. {1}, {2} moneys", c, t.TreeType, t.Price));
                            c++;
                        }
                        c = 1;
                        Console.WriteLine("What tree do you want to buy?");
                        buyTree = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        //EXTEND SWITCH IF YOU ADD MORE TREES
                        switch (buyTree)
                        {
                            case 1:
                                Buy(buyTree);
                                break;
                            case 2:
                                Buy(buyTree);
                                break;
                            case 3:
                                Buy(buyTree);
                                break;
                            case 4:
                                Buy(buyTree);
                                break;
                            case 5:
                                Buy(buyTree);
                                break;
                            case 6:
                                Buy(buyTree);
                                break;
                            case 7:
                                Buy(buyTree);
                                break;
                            case 8:
                                Buy(buyTree);
                                break;
                            default:
                                WrongInput(buyTree);
                                break;
                        }
                        break;

                    //Print all the trees
                    case 2:
                        PrintTrees(Trees);
                        break;




                    case 0:
                        Terminate();
                        break;
                    default:
                        WrongInput(menu);
                        break;
                }
            }
            while (menu != 0); 
        }

        

        private static void Buy(int p)
        {
            if (money >= TreesDB[p-1].Price)
            {
                Trees.Add(TreesDB[p-1]);
                money = money - TreesDB[p-1].Price;
            }
            else
            {
                Console.WriteLine("You dont have enought money to buy the {0}-tree", TreesDB[p-1].TreeType);
            }
        }

        private static void PrintTrees(List<Tree> Trees)
        {
            List<String> TreeCheck = new List<String>();

            foreach (Tree t in Trees)
            {
                if (!TreeCheck.Contains(t.TreeType))
                {
                    int x = Trees.Count(y => y.TreeType == t.TreeType);
                    Console.WriteLine("{0} {1}-trees", x, t.TreeType);
                    TreeCheck.Add(t.TreeType);
                }
                
            }
        }

        private static void WrongInput(int i)
        {
            Console.WriteLine(string.Format("{0} is not a valid input", i));
        }

        private static void Terminate()
        {
            Environment.Exit(0);
        }
    }
}