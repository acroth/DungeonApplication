using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value >= 1 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }

            }//propfull tab-tab

            //Mini-Lab!
            // Build the business rule logic:
            // MinDamage greater than 0 and not more than MaxDamage

            //Tiny-Lab!
            
           
        }
        public Monster(string name, int hitChance, int block, int life, int maxLife, int minDamage,
            int maxDamage, string description)
        {
            MaxDamage = maxDamage;
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            MinDamage = minDamage;
            Description = description;         
        }//end FQCTOR

        public override string ToString()
        {
            return string.Format("\nMonstern\n" +
                "{0}\nLife: {1} of {2}\nDamage: {3} to {4}\n"+
                "Block: {5}\nHitChance : {6}\nDescription: \n{7}",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                Block,
                HitChance,
                Description);
        }// end ToString()

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage,MaxDamage + 1);   
        }// end CalcDamage

    }
}
