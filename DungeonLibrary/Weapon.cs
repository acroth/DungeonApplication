using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Weapon
    {
        //fields
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private bool _isTwoHanded;
        private int _bonusHitChance;
        //properties
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }//end MaxDamage

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end Name
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }//end IsTwoHanded
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }//end BonusHitChance

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //MinDamage cannot be less than 1 or greater than MaxDamage
                //MiniLab!
                //Write business rule
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }//if
                else
                {
                    _minDamage = 1;
                }//else
            }//set
        }

        //ctors

        public Weapon(int minDamage, int maxDamage, string name,
            bool isTwohanded, int bonusHitChance)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            IsTwoHanded = isTwohanded;
            BonusHitChance = bonusHitChance;
        }//end Ctor


        //methods

        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} damage\n" +
                "Bonus Hit: {3}%\t{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance, IsTwoHanded ? "Two handed" : "One handed");

        }

    }
}
