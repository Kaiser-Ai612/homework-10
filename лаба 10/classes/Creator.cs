using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using лаба_11;
using лаба_11.classes;

namespace лаба_11.classes
{
    internal class Creator
    {
        private static Dictionary<uint, House> houses = new Dictionary<uint, House>();
        private Creator() { }

        public static House CreateBuild(ushort h, ushort f, ushort fl, ushort p)
        {
            House house = new House(h, f, fl, p);
            houses.Add(house.Id, house); 
            return house;
        }

        public static void RemoveHouse(uint id)
        {
            if (houses.ContainsKey(id))
            {
                houses.Remove(id);
                Console.WriteLine($"Дом с id {id} удален.");
            }
            else
            {
                Console.WriteLine($"Дом с id {id} не найден.");
            }
        }

        public static void PrintAllHouses()
        {
            foreach (var house in houses.Values)
            {
                house.Print();
            }
        }
    }
}
