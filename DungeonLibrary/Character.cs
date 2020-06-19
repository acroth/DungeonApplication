using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //The abstract modifier indicates that the thing being modified
    //has an incomplete implementation. It can be used with classes, 
    //methods and properties.This indicates that this class is only 
    //ever intended to be used as a parent class for other classes.


   public abstract class Character
    {
        private int _life;

        //properties
        public string Name { get; set; }
        public int MaxLife { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }//end else
            }//end set

        }//end Life

        // we are not bringing a constructor in since we will
        // never instatiate character

        public virtual int CalcBlock()
        {
            return Block;

        }

        //MiniLab
        //Make the CalcHitChance() return the HitChance.
        //Make it overridable

        public virtual int CalcHitchance()
        {
            return HitChance;

        }

        public virtual int CalcDamage()
        {
            return 0;
        }

    }
}
