using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Описать класс комплексных чисел.
Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух
комплексных чисел. Переопределить метод ToString() для комплексного числа.
Протестировать на простом примере.
 */

namespace лаба_12.@classes
{
    internal class Complex
    {
        private int Real;
        private int Mnim;
        public Complex() { }
        public Complex(int real, int mnim)
        {
            this.Real = real;
            this.Mnim = mnim;
        }
        //сложения
        public static Complex operator +(Complex a, Complex b)
        {
            int sum1 = a.Real + b.Real;
            int sum2 = b.Mnim + a.Mnim;
            return new Complex(sum1,sum2);
        }
        //умножения
        public static Complex operator *(Complex a, Complex b)
        {
            int sum1 = a.Real * b.Real - a.Mnim*a.Mnim;
            int sum2 = b.Mnim * a.Real + a.Mnim*b.Real;
            return new Complex(sum1, sum2);
        }
        //вычитания
        public static Complex operator -(Complex a, Complex b)
        {
            int sum1 = a.Real - b.Real;
            int sum2 = b.Mnim - a.Mnim;
            return new Complex(sum1, sum2);
        }
        //проверку на равенство
        public static bool operator ==(Complex a, Complex b)
        {
            return a.Real == b.Real && a.Mnim == b.Mnim;
        }
        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }
        //Переопределить метод ToString()
        public override string ToString()
        {
            return $"{this.Real} + ({this.Mnim})i";
        }
    }
}
