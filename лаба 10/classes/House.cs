using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_11.classes
{
    internal class House
    {
        public uint Id;
        private static uint idgen = 0;
        private ushort high;//meters
        private ushort floors;
        private ushort flat;
        private ushort podyezd;

        public House(ushort h, ushort f, ushort fl, ushort p)
        {
            Id = GenId();
            high = h;
            floors = f;
            flat = fl;
            podyezd = p;
        }

        private uint GenId()
        {
            idgen++; return Id;
        }
        public void FloorHigh(byte num)
        {
            if (high / floors >= 2)
            {
                float one = high / floors * num;
                Console.WriteLine($"{num} этаж находится на высоте {one} метра(ов)");
            }
            else
            {
                Console.WriteLine("невозможное значение");
            }
        }
        public void CountFlatOnPod()
        {
            if (flat > podyezd)
            {
                int k = flat / podyezd;
                Console.WriteLine($"в подьезде {k} квратир(а)");
            }
            else
            {
                Console.WriteLine("невозможное значение");
            }
        }
        public void CountFlatOnFloor()
        {
            int k = flat / podyezd;
            if (k / floors > 0)
            {
                Console.WriteLine($"на каждом этаже минимум есть по {k / floors} квартир(е)/(ы)");
            }
            else
            {
                Console.WriteLine("невозможное значение");
            }
        }

        public void Print()
        {
            Console.WriteLine($"id {Id},высота дома {high} м,всего этажей {floors}, всего квартир{flat},количество подъездов {podyezd}");
        }
    }
}
