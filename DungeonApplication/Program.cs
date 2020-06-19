using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;

namespace DungeonApplication
{
    class Program
    {
        //This global variable is available to anything inside the 
        //application. The downside is that, since it is the first thing
        //created in the application, it will persist for as long as the application is running
        //(we cannot dispose of it) 
       static Random rand = new Random();

        int number;
        static void Main(string[] args)
        {
            Console.WriteLine("Caverns of Hoth");
            Console.Title = "Caverns of Hoth";
            
            //TODO Create a player
            Weapon lightsaber = new Weapon(15, 35, "Green Saber", true, 10);

            Player player = new Player("Joe", 70, 10, 80, 80, Race.Human, lightsaber);



            //TODO Create a loop for the room & Monster
            bool exit = false;

            do
            {
                //TODO Create a Method to get a room description
                Console.WriteLine(GetRoom());
                //TODO Generate a Monster in the room 
                Rabbit rabbit = new Rabbit("White Rabbit", 30, 30, 20, 20, 20, 40, "super cute\n ", true);
                Rabbit rabbit2 = new Rabbit("White Rabbit", 30, 30, 20, 20, 30, 50, "super cute\n ", false);
                DisgruntledTuantuan gary = new DisgruntledTuantuan("Gary the TaunTaun", 60, 60, 40, 25, 30, 60, "He's Pissed!\n ", false);
                DisgruntledTuantuan bill = new DisgruntledTuantuan("bill the TaunTaun", 60, 60, 48, 25, 30, 85, "He's Pissed!\n ", true);
                Monster[] monsters =
                    {
                        rabbit,rabbit,rabbit,rabbit2,gary,gary,gary,bill, bill
                    };
               Monster monster = monsters[rand.Next(monsters.Length)];
                Console.WriteLine("\nIn This Room " + monster.Name);
                // TODO Create a loop for the menu
                bool reload = false;

                do
                {
                    // TODO Create the menu

                    Console.WriteLine("\n Choose an action, Hero:\n" +
                        "A) Attack\n" +
                        "R) RUN AWAY\n" +
                        "P) Player Info\n" +
                        "M) Monster Into\n" +
                        "X) Exit");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"You killed {monster.Name}!");
                                Console.ResetColor();
                            }
                            break;

                        case ConsoleKey.R:
                            Console.WriteLine("Run");
                            Console.WriteLine(monster.Name + " attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            reload = true;//gets hero out of room and into new room
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.X:
                            Console.WriteLine("Later");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("wrong key, can you even read?");
                            break;
                    }//end switch


                    if (player.Life <= 0)
                    {
                        Console.WriteLine("You Died");
                        exit = true;
                    }//end if player dies
                    //while (!reload == !exit);
                } while (!reload && !exit);
            } while (!exit);


        }//end Main()

        private static string GetRoom()
        {
            string[] rooms =
                {
                "You open the door to a long narrow room with a high ceiling. Three thick circles of wood rest on wooden stands. You're not certain what they are because you came into the room behind them. ",
                "You push open the stone door to this room and note that the only other exit is a door made of wood. It and the table shoved against it are warped and swollen. Indeed, the table only barely deserves that description. Its surface is rippled into waves and one leg doesn't even touch the floor. The door shows signs of someone trying to chop through from the other side, but it looks like they gave up.",
                "A wall that holds a seat with a hole in it is in this chamber. It's a privy! The noisome stench from the hole leads you to believe that the privy sees regular use.",
                "You feel a sense of foreboding upon peering into this cavernous chamber. At its center lies a low heap of refuse, rubble, and bones atop which sit several huge broken eggshells. Judging by their shattered remains, the eggs were big enough to hold a crouching man, making you wonder how large -- and where -- the mother is.",
                " You catch a whiff of the unmistakable metallic tang of blood as you open the door. The floor is covered with it, and splashes of blood spatter the walls. Some drops even reach the ceiling. It looks fresh, but you don't see any bodies or footprints leaving the chamber.",
                " A stone throne stands on a foot-high circular dais in the center of this cold chamber. The throne and dais bear the simple adornments of patterns of crossed lines -- a pattern also employed around each door to the room",
                "A huge stewpot hangs from a thick iron tripod over a crackling fire in the center of this chamber. A hole in the ceiling allows some of the smoke from the fire to escape, but much of it expands across the ceiling and rolls down to fill the room in a dark fog. Other details are difficult to make out, but some creature must be nearby, because it smells like a good soup is cooking.",
                "A chill crawls up your spine and out over your skin as you look upon this room. The carvings on the wall are magnificent, a symphony in stonework -- but given the themes represented, it might be better described as a requiem. Scenes of death, both violent and peaceful, appear on every wall framed by grinning skeletons and ghoulish forms in ragged cloaks."

                };

            return rooms[new Random().Next(rooms.Length)];

            //Random rand = new Random();
            //int indexNbr = rand.Next(rooms.Length);
            //string room = rooms[indexNbr];
            //return room;
        }//end GetRoom()

    }//end class
}//end namespace
