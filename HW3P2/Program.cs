using System;

namespace HW3P2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLampPlugged = true, isBulbBurnt = false; 


            
            Console.WriteLine("Lamp does not work.");

            Console.WriteLine("Is lamp plugged in?");
            if (isLampPlugged) 
            {
                Console.WriteLine("Yes, lamp is plugged in.");

                Console.WriteLine("Is Bulb burnt out?");
                if(isBulbBurnt)
                {
                    Console.WriteLine("Yes, replace light bulb.");
                }
                else
                {
                    Console.WriteLine("No, repair lamp.");
                }

            }
            else
            {
                Console.WriteLine("No, plug lamp in.");
            }
            
            





        }
    }
}
    