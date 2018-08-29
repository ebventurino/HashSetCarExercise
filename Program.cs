using System;
using System.Collections.Generic;


namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a hashset, adding 5 cars
            HashSet<string> showRoom = new HashSet<string>();
            showRoom.Add("Car1");
            showRoom.Add("Car2");
            showRoom.Add("Car3");
            showRoom.Add("Car4");
            showRoom.Add("Car5");
            Console.WriteLine($"There are {showRoom.Count} cars in my show room");

            // looping through the showroom, console.logging the results
            foreach (string item in showRoom)
            {
                Console.WriteLine(item);


            }
            // creating a new hashset, adding two more cars
            HashSet<string> usedLot = new HashSet<string>();
            usedLot.Add("Car6");
            usedLot.Add("Car7");

            // combining used lot to show room. removing car5
            usedLot.UnionWith(showRoom);
            usedLot.Remove("Car5");

            // creating a new hashset, adding two more cars to junk yard
            HashSet<string> junkYard = new HashSet<string>();
            junkYard.Add("Car8");
            junkYard.Add("Car9");

            // cloning a hashset, merging with used lot?
            HashSet<string> clone = new HashSet<string>(showRoom);
            clone.IntersectWith(usedLot);

            //looping through the cloned hashset, posting cars
            Console.WriteLine("Cars in common between show room and junk yard:");
            foreach (string car in clone)
            {
                Console.WriteLine($"  {car}");
            }
            // merging showroom with junkyard, then looping through to post updated cars in the showroom
            Console.WriteLine("Buying all the cars in the junk yard. I now own:");
            showRoom.UnionWith(junkYard);
            foreach (string car in showRoom)
            {
                Console.WriteLine($"  {car}");

            

                }
            }
        }
    
    }
