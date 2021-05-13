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
            Random random = new Random();

            for (int i = 0; i < 1;)
            {

                Console.WriteLine("Hi, please select type of a sword !");
                Console.WriteLine("0 for no magic/flaming" + "\n" + "1 - for magic " + "\n" + "2 - for flaming" + "\n" + "anything else to quit");

                chooseSword = Console.ReadLine();
                SwordDamage sword = new SwordDamage();
                sword.Roll = 0;

                if (chooseSword == "0")
                {
                    // roll 3d6 by calling random.Next(1,7) three times and adding the results together, and set the Roll field 
                    for (int y = 0;  y <= 2; y++)
                    {
                        
                        int roll= (int)random.Next(1, 7);
                        sword.Roll = sword.Roll + roll;
                    }
                    
                    sword.CalculateDamage();
                }
                else if (chooseSword == "1")
                {
                
                    for (int y = 0; y <= 2; y++)
                    {
                        int roll = (int)random.Next(1, 7);
                        sword.Roll += roll;
                    }
                    magic = true;
                    sword.SetMagic(magic);
                    

                }
                else if (chooseSword == "2")
                {
                
                    for (int y = 0; y <= 2; y++)
                    {
                        int roll = (int)random.Next(1, 7);
                        sword.Roll = sword.Roll + roll;
                    }
                    flaming = true;
                    sword.SetFlamin(flaming);
                   
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
