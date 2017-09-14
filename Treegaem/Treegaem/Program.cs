using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treegaem
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int money;
            int difficulty;
            bool done = false;

            do
            {
                Console.WriteLine("Choose difficulty: ");
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Hard");
                difficulty = int.Parse(Console.ReadLine());

                if (difficulty == 1)
                {
                    money = 5000;
                    done = true;
                }
                else if (difficulty == 2)
                {
                    money = 2000;
                    done = true;
                }
                else if (difficulty == 3)
                {
                    money = 500;
                    done = true;
                }
                else
                {
                    Console.WriteLine(string.Format("{0} is not a valid input", difficulty));
                }
            }
            while (!done);
            List<Tree> TreesDB = new List<Tree>();

            TreesDB.Add(new Tree()
            {
                TreeType = "Apple",
                Growth = 0.1,
                Price = 250,
                FruitGrowth =0.3,
                FruitDecay =1.2
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Pear",
                Growth = 0.15,
                Price = 350,
                FruitGrowth = 0.25,
                FruitDecay = 1.4
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Orange",
                Growth = 0.05,
                Price = 600,
                FruitGrowth = 0.15,
                FruitDecay = 1.5
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Banana",
                Growth = 0.5,
                Price = 750,
                FruitGrowth = 0.2,
                FruitDecay = 1.3
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Peach",
                Growth = 0.25,
                Price = 500,
                FruitGrowth = 0.6,
                FruitDecay = 1.5
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Cherry",
                Growth = 0.05,
                Price = 500,
                FruitGrowth = 0.95,
                FruitDecay = 1.65
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Pine",
                Growth = 0.6,
                Price = 150,
                FruitGrowth = 0.05,
                FruitDecay = 1.01
            });
            TreesDB.Add(new Tree()
            {
                TreeType = "Oak",
                Growth = 0.05,
                Price = 1000,
                FruitGrowth = 0.05,
                FruitDecay = 1.01
            });
        }
    }
}
