using System;

namespace Roll_dice_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string chooseSword;
            bool magic;
            bool flaming;

            for (int i = 0; i < 1;)
            {

                Console.WriteLine("Hi, please select type of a sword !");
                Console.WriteLine("0 for no magic/flaming" + "\n" + "1 - for magic " + "\n" + "2 - for flaming" + "\n" + "anything else to quit");

                chooseSword = Console.ReadLine();
                SwordDamage sword = new SwordDamage();

                if (chooseSword == "0")
                {
                    sword.CalculateDamage();
                }
                else if (chooseSword == "1")
                {
                    magic = true;
                    sword.SetMagic(magic);
                    sword.CalculateDamage();

                }
                else if (chooseSword == "2")
                {
                    flaming = true;
                    sword.SetFlamin(flaming);
                    sword.CalculateDamage();
                }
                else
                {
                    Console.WriteLine("You can close the app");
                    i = 1;
                }
            }
        }
    }
}
