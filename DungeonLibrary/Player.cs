using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //fields
        // With automatic properties we only need to create fields
        //for properties that will have buisness rules
        //private int _life;


        //properties
        //public string Name { get; set; }
        //public int MaxLife { get; set; }
        //public int HitChance { get; set; }
        //public int Block { get; set; }
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //You cannot use automatic propertiesd for properties
        //that have business rules:
        //public int Life
        //{
        //    get { return _life; }
        //    set
        //    {
        //        if (value <= MaxLife)
        //        {
        //            _life = value;
        //        }//end if
        //        else
        //        {
        //            _life = MaxLife;
        //        }//end else
        //    }//end set

        //}//end Life

        //ctors
        public Player(string name, int hitChance, int block, int life, int maxLife, Race playerRace, Weapon equippedWeapon )
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;
        }

        //methods
        public override string ToString()
        {
            string description = "";
            switch (PlayerRace)
            {
                case Race.Human:
                    description = "Lame";
                    break;
                case Race.Angel:
                    description = "Not of this world";
                    break;
                case Race.Vampire:
                    description = "Creature of the night";
                    break;
                case Race.Werewolf:
                    description = " Fluffy";
                    break;
                default:
                    break;
            }//end sitch
            return string.Format("Name: {0}\n" +
                "Life: {1} of {2}\nHit chance: {3}%\n" +
                "Weapon: \n{4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                HitChance,
                EquippedWeapon,
                Block,
                description);
        }// end toString()

        public override int CalcDamage()
        {
            //Random rand = new Random();

            //int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            //return damage ;

            return new Random().Next(EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage + 1);
        }

            public override int CalcHitchance()
        {
            return base.CalcHitchance() + EquippedWeapon.BonusHitChance;
        }//end CalcDamage()
    }




}
