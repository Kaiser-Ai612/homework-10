using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using лаба_11;
//using лаба_11.classes;
using libr;
using libr2;

namespace laba_11
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
        /*Упражнение 11.1 Создать новый класс, который будет являться фабрикой объектов класса
банковский счет. Изменить модификатор доступа у конструкторов класса банковский счет на
internal. Добавить в фабричный класс перегруженные методы создания счета CreateAccount,
которые бы вызывали конструктор класса банковский счет и возвращали номер созданного
счета. Использовать хеш-таблицу для хранения всех объектов банковских счетов в
фабричном классе. В фабричном классе предусмотреть метод закрытия счета, который
удаляет счет из хеш-таблицы (методу в качестве параметра передается номер банковского
счета). Использовать утилиту ILDASM для просмотра структуры классов.
             */
        {
            Console.WriteLine("Упражнение 11.1");
            BankAccFactory factory = new BankAccFactory();

            string account1 = factory.CreateAccount(5615326);
            string account2 = factory.CreateAccount();

            Console.WriteLine($"Создан счет: {account1}, начальный баланс: 5615326");
            Console.WriteLine($"Создан счет: {account2}, начальный баланс: 0");

            BankAcc account = factory.GetAccount(account1);
            Console.WriteLine($"Счет {account.AccountNumber} имеет баланс: {account.Balance}");
            if (factory.CloseAccount(account1))
            {
                Console.WriteLine($"Счет {account1} закрыт.");
            }
        }
        static void Task2()
        /*Упражнение 11.2 Разбить созданные классы, связанные с банковским счетом, и тестовый
пример в разные исходные файлы. Разместить классы в одно пространство имен и создать
сборку. Подключить сборку к проекту и откомпилировать тестовый пример со сборкой.
Получить исполняемый файл, проверить с помощью утилиты ILDASM, что тестовый
пример ссылается на сборку и не содержит в себе классов, связанный с банковским счетом.
         */
        //чтобы не выдавало ошибку поменяла название класса
        {
            Console.WriteLine("Упражнение 11.2");
            BankAccFactory factory = new BankAccFactory();

            string account1 = factory.CreateAccount(5615326);
            string account2 = factory.CreateAccount();

            Console.WriteLine($"{account1}, начальный баланс: 5615326");
            Console.WriteLine($"{account2}, начальный баланс: 0");

            BankAcc account = factory.GetAccount(account1);
            Console.WriteLine($"Счет {account.AccountNumber} имеет баланс: {account.Balance}");
            if (factory.CloseAccount(account1))
            {
                Console.WriteLine($"Счет {account1} закрыт.");
            }
        }
        static void Task3()
        /*Домашнее задание 11.1 Для реализованного класса из домашнего задания 7.1 создать
новый класс Creator, который будет являться фабрикой объектов класса здания. Для этого
изменить модификатор доступа к конструкторам класса, в новый созданный класс добавить
перегруженные фабричные методы CreateBuild для создания объектов класса здания. В
классе Creator все методы сделать статическими, конструктор класса сделать закрытым. Для
хранения объектов класса здания в классе Creator использовать хеш-таблицу. Предусмотреть
возможность удаления объекта здания по его уникальному номеру из хеш-таблицы. Создать
тестовый пример, работающий с созданными классами.
         */
        //я закоментровала классы , но использовала ссылку на сборку
        {
            Console.WriteLine("Домашнее задание 11.1");
            House house1 = Creator.CreateBuild(6, 7, 4, 1);
            House house2 = Creator.CreateBuild(15, 10, 50, 3);
            House house3 = Creator.CreateBuild(8, 4, 12, 1);

            Console.WriteLine("Список созданных домов:");
            Creator.PrintAllHouses();

            Creator.RemoveHouse(house1.Id);

            Console.WriteLine("Список домов после удаления:");
            Creator.PrintAllHouses();
        }
        static void Task4()
        /*Домашнее задание 11.2 Разбить созданные классы (здания, фабричный класс) и тестовый
пример в разные исходные файлы. Разместить классы в одном пространстве имен. Создать
сборку (DLL), включающие эти классы. Подключить сборку к проекту и откомпилировать
тестовый пример со сборкой. Получить исполняемый файл, проверить с помощью утилиты
ILDASM, что тестовый пример ссылается на сборку и не содержит в себе классов здания и
Creator.
         */
        {
            Console.WriteLine("Домашнее задание 11.2");
        }
    }
}