using System;
using System.Collections.Generic;


namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showRoom = new HashSet<string>();
            showRoom.Add("Car1");
            showRoom.Add("Car2");
            showRoom.Add("Car3");
            showRoom.Add("Car4");
            showRoom.Add("Car4");
            Console.WriteLine($"There are {showRoom.Count} cars in my show room");

            foreach (string item in showRoom)
            {
                Console.WriteLine(item);


            }

            HashSet<string> usedLot = new HashSet<string>();
            usedLot.Add("Car5");
            usedLot.Add("Car6");

            usedLot.UnionWith(showRoom);
            usedLot.Remove("Car5");

            HashSet<string> junkYard = new HashSet<string>();
            junkYard.Add("Car7");
            junkYard.Add("Car8");

            HashSet<string> clone = new HashSet<string>(showRoom);
            clone.IntersectWith(usedLot);

            Console.WriteLine("Cars in common between show room and junk yard:");
            foreach (string car in clone)
            {
                Console.WriteLine($"  {car}");
            }
            Console.WriteLine("Buying all the cars in the junk yard. I now own:");
            showRoom.UnionWith(junkYard);
            foreach (string car in showRoom)
            {
                Console.WriteLine($"  {car}");

            

                }
            }
        }
    
    }
