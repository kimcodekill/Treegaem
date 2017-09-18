using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treegaem
{
    public class AppleTree : Tree
    {
        public AppleTree(int id, double quality)
        {
            Id = id;
            Quality = quality;
            TreeType = "Apple";
            Growth = 0.1;
            Price = 250;
            FruitGrowth = 0.3;
            FruitDecay = 1.2;
            Height = 0.5;
            FruitType = "Apple";
        }
    }
}
