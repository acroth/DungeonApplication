﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker,Character defender)
        {
            Random rand = new Random();
            Thread.Sleep(25);

            int diceRoll = rand.Next(1,25);
            Thread.Sleep(25);
            if (diceRoll <= attacker.CalcHitchance()-defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;//subtracts damageDealt from defenders life

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} far {2} damage!", attacker.Name,defender.Name,damageDealt);
                Console.ResetColor();

            }
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }//endelse

        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }//end if


        }//if
    }
}
