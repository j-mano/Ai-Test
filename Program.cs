using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AITest
{
    class villager
    {
        string name = "";
        int PostX = 0;
        int PostY = 0;
        bool ISFemle = false;
    }
    class farm
    {
        int id;
    }

    class feild
    {
        int BelongToFarmWitrhId;
        int PostX = 0;
        int PostY = 0;
    }

    class foodstorage
    {
        int PostX = 0;
        int PostY = 0;
        int AmountOfFood = 0;
        int MaxStorage = 100;
        bool StorageFull = false;

        void ismax()
        {
            if (MaxStorage <= AmountOfFood)
            {
                StorageFull = true;
            }
        }
    }

    class PosMark {
        bool hasBuilding = false;
        bool hasCreature = false;
    }

    class Program
    {
        static int MapHeigt     = 9;
        static int MapWidth     = 9;
        static string[,] Map = new string[MapHeigt, MapWidth];

        static void Main(string[] args)
        {
            while (true)
            {
                update();
            }
        }

        static void update()
        {
            VillagerCheckMove();
            Updatemap();
            printout();

            Console.ReadLine();
        }
        static void Updatemap()
        {
            int i = 0;
            int j = 0;
            while (j < MapHeigt)
            {
                Map[i, j] = j.ToString();
                while (i < MapWidth)
                {
                    Map[i, j] = i.ToString();
                    i++;
                }
                i = 0;
                j++;
            }
        }

        static void printout()
        {
            int i = 0;
            int j = 0;
            while (j < MapHeigt)
            {
                while (i < MapWidth)
                {
                    Console.Write(Map[i, j]);
                    i++;
                }
                Console.WriteLine(Map[i, j]);
                i = 0;
                j++;
            }
        }

        static void VillagerCheckMove()
        {

        }
    }
}
