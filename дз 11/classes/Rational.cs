using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_12.@classes
{
    internal class Rational
    {
        private int num;  
        private int znam; 
        public Rational(int num, int znam)
        {
            if (znam == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю.");

            this.num = num;
            this.znam = znam;
        }
        public override string ToString()
        {
            return $"{num}/{znam}";
        }
        //
        public static bool operator ==(Rational a, Rational b)
        {
            return a.num == b.num && a.znam == b.znam;
        }
        public static bool operator !=(Rational a, Rational b)
        {
            return !(a == b);
        }
        //
        public override bool Equals(object obj)
        {
            if (obj is Rational other)
            {
                return this == other;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return num.GetHashCode() ^ znam.GetHashCode();
        }
        public static bool operator <(Rational a, Rational b)
        {
            return a.num * b.znam < b.num * a.znam;
        }
        public static bool operator >(Rational a, Rational b)
        {
            return a.num * b.znam > b.num * a.znam;
        }
        public static bool operator <=(Rational a, Rational b)
        {
            return a < b || a == b;
        }
        public static bool operator >=(Rational a, Rational b)
        {
            return a > b || a == b;
        }
        public static Rational operator +(Rational a, Rational b)
        {
            int newNum = a.num * b.znam + b.num * a.znam;
            int newZnam = a.znam * b.znam;
            return new Rational(newNum, newZnam);
        }
        public static Rational operator -(Rational a, Rational b)
        {
            int newNum = a.num * b.znam - b.num * a.znam;
            int newZnam = a.znam * b.znam;
            return new Rational(newNum, newZnam);
        }
        public static Rational operator ++(Rational a)
        {
            return a + new Rational(1, 1);
        }
        public static Rational operator --(Rational a)
        {
            return a - new Rational(1, 1);
        }
        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a.num * b.num, a.znam * b.znam);
        }
        public static Rational operator /(Rational a, Rational b)
        {
            if (b.num == 0)
                throw new DivideByZeroException("Деление на ноль.");
            return new Rational(a.num * b.znam, a.znam * b.num);
        }

        // не знаю как сделать %

        public static explicit operator float(Rational r)//явное преобразование, когда нужно класс во что то определить
        {
            return (float)r.num / r.znam;
        }

        public static explicit operator int(Rational r)
        {
            return (int)r.num / r.znam;
        }

        public static implicit operator Rational(float f)//неявное преобразование, когда маленький в большой
        {
            int z = 1;
            while (f % 1 != 0)
            {
                f *= 10;
                z *= 10;
            }
            return new Rational((int)f, z); //3547242/1000000
        }

        public static implicit operator Rational(int i)
        {
            return new Rational(i, 1);
        }
    }
}
