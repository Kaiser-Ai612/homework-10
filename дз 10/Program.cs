using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using дз_10;

namespace dz10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }
        static void Task2()
        /*У каждого есть хобби. Написать программу для слежения за интересующим вас событием
(выход сериала, концерт и т.д.)
Создать не менее трех человек с разными увлечениями. Пользователь вводит (можно из
заранее определенного списка) событие. Если событие совпало с увлечением кого-либо,
вывести его реакцию на событие.
         */
        {
            Person person1 = new Person("Стайлз", new List<string> { "читать книги", "слушать музыку" });
            Person person2 = new Person("Лидия", new List<string> { "просмотр сериалов", "играть на флейте" });
            Person person3 = new Person("Дерек", new List<string> { "рисовать", "играть в футбол" });

            List<Person> people = new List<Person> { person1, person2, person3 };

            Event events = new Event(people);

            Console.WriteLine("выберите :чтение книг, слушать музыку, смотреть сериал, играть на флейте,рисовать,играть в футбол");
            string userEvent = Console.ReadLine();
            events.CheckEvent(userEvent);
        }
    }
}