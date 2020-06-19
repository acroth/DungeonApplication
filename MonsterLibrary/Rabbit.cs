using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Rabbit : Monster
    {
        public bool IsFluffy { get; set; }

        public Rabbit(string name, int life, int maxLife,int hitChance,
            int block, int minDamage, int maxDamage,string description, bool isFluffy)
            :base(name, hitChance,block,life,maxLife,minDamage,maxDamage,description)
        {

            IsFluffy = isFluffy;

        }

        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "It looks super cuddly and fluffy" : "It's raggedy");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;

        }
    }
}
