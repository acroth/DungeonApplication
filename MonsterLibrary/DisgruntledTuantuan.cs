using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
   public class DisgruntledTuantuan : Monster
    {
        // fields
        //properties
        public bool IsEnraged { get; set; }
        //ctors
        public DisgruntledTuantuan(string name, int life, int maxLife, int hitChance,
           int block, int minDamage, int maxDamage, string description, bool isEnraged)
            :base(name, hitChance,block,life,maxLife,minDamage,maxDamage,description)
        {

            IsEnraged = isEnraged;

        }

        public override string ToString()
        {
            return base.ToString() + (IsEnraged ? "The TaunTaun rears his head and spits a wad at your feet" : "He's only mildly disgruntled");
        }

        //methods


        }



    }

