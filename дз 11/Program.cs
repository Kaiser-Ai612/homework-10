using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using лаба_12.@enum;
using лаба_12.classes;

namespace лаба_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        static void Task1()
        /*Упражнение 12.1 Для класса банковский счет переопределить операторы == и != для
сравнения информации в двух счетах. Переопределить метод Equals аналогично оператору
==, не забыть переопределить метод GetHashCode(). Переопределить метод ToString() для
печати информации о счете. Протестировать функционирование переопределенных методов
и операторов на простом примере.
         */
        {
            Console.WriteLine("Упражнение 12.1");
            Bank account1 = new Bank(1,200, accType.saving);
            Bank account2 = new Bank(1,200, accType.saving);
            Bank account3 = new Bank(61616, accType.credit);

            // Сравнение счетов с помощью операторов
            Console.WriteLine($"account1 == account2: {account1 == account2}"); // True
            Console.WriteLine($"account1 != account3: {account1 != account3}"); // True

            // Сравнение счетов с помощью метода Equals
            Console.WriteLine($"account1.Equals(account2): {account1.Equals(account2)}"); // True
            Console.WriteLine($"account1.Equals(account3): {account1.Equals(account3)}"); // False

            // Вывод информации о счетах
            Console.WriteLine(account1.ToString());
            Console.WriteLine(account2.ToString());
            Console.WriteLine(account3.ToString());
        }
        static void Task2()
        /*Упражнение 12.2 Создать класс рациональных чисел. В классе два поля – числитель и
знаменатель. Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <,
>, <=, >=, +, – , ++, --. Переопределить метод ToString() для вывода дроби. Определить
операторы преобразования типов между типом дробь, float, int. Определить операторы *, /,
%.
         */
        {
            Console.WriteLine("Упражнение 12.2");
            Rational r1 = new Rational(1, 2); 
            Rational r2 = new Rational(3, 4);
            Rational r3 = new Rational(5, 6); 

            Rational sum = r1 + r2;
            Console.WriteLine($"Сумма : {sum}");

            Rational minus = r2 - r1;
            Console.WriteLine($"Разность : {minus}"); 

            Rational multi = r1 * r3;
            Console.WriteLine($"Произведение: {multi}"); 

            Rational del = r3 / r2;
            Console.WriteLine($"Частное r3 и r2: {del}"); 

            Console.WriteLine($"{r1} == {r2}: {r1 == r2}"); 
            Console.WriteLine($"{r1} != {r2}: {r1 != r2}"); 
            Console.WriteLine($"{r1} < {r2}: {r1 < r2}"); 
            Console.WriteLine($"{r1} > {r2}: {r1 > r2}"); 
            Console.WriteLine($"{r1} <= {r2}: {r1 <= r2}"); 
            Console.WriteLine($"{r1} >= {r2}: {r1 >= r2}"); 

            Rational r4 = new Rational(4, 7); 
            r4++;
            Console.WriteLine(r4);
            r4--;
            Console.WriteLine(r4); 

            float floatValue = (float)r1;
            int intValue = (int)r3;
            Console.WriteLine($"{floatValue}"); 
            Console.WriteLine($"{intValue}"); 

            Rational r5 = (Rational)2.5f; 
            Console.WriteLine($"{r5}");
        }
        static void Task3()
        /*Домашнее задание 12.1 На перегрузку операторов. Описать класс комплексных чисел.
Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух
комплексных чисел. Переопределить метод ToString() для комплексного числа.
Протестировать на простом примере.
         */
        {
            Console.WriteLine("Домашнее задание 12.1");

            Complex complex = new Complex(3, 4);
            Complex complex1 = new Complex(1, 5);
            Complex complex2 = new Complex(1, 5);
            complex.ToString();
            complex1.ToString();

            if (complex1 == complex2)
            {
                Console.WriteLine("комплексные числа равны");
            }
            if (complex1 != complex) 
            {
                Console.WriteLine("комплексные числа не равны");
            }
            Complex sumcomplex = complex1 + complex;
            Complex mincoplex = complex1 - complex;
            Complex umncoplex = complex1 * complex;

            Console.WriteLine($"{complex.ToString()} +{complex1.ToString()} = {sumcomplex.ToString()}" +
                $"\n{complex.ToString()} - {complex1.ToString()} = {mincoplex.ToString()} \n " +
                $"{complex.ToString()}*{complex1.ToString()} = {umncoplex.ToString()}");
        }
        static void Task4()
        /*Домашнее задание 12.2 Написать делегат, с помощью которого реализуется сортировка
книг. Книга представляет собой класс с полями Название, Автор, Издательство и
конструктором. Создать класс, являющийся контейнером для множества книг (массив книг).
В этом классе предусмотреть метод сортировки книг. Критерий сортировки определяется
экземпляром делегата, который передается методу в качестве параметра. Каждый экземпляр
делегата должен сравнивать книги по какому-то одному полю: названию, автору,
издательству.
         */
        {
            Console.WriteLine("");
        }
    }
}