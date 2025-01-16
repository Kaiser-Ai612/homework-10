using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*У каждого есть хобби. Написать программу для слежения за интересующим вас событием
(выход сериала, концерт и т.д.)
Создать не менее трех человек с разными увлечениями. Пользователь вводит (можно из
заранее определенного списка) событие. Если событие совпало с увлечением кого-либо,
вывести его реакцию на событие.
 */

namespace дз_10
{
    internal class Person
    {
        public string Name { get; }
        public List<string> Hobbies { get; }

        public Person(string name, List<string> hobbies)
        {
            Name = name;
            Hobbies = hobbies;
        }

        public void ReactToEvent(string eventDes)
        {
            Console.WriteLine($"{Name} очень ждет : {eventDes}");
        }
    }
}
